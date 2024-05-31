-------PROCEDURES---------------------------------------
-- Cập nhật đánh giá phim
CREATE PROCEDURE dbo.CapNhatDanhGiaPhim
    @MaPhim CHAR(10),
    @DanhGia FLOAT
AS
BEGIN
    UPDATE PHIM
    SET DanhGia = @DanhGia
    WHERE MaPhim = @MaPhim;
END;
GO

-- Cập nhật hang hoa
CREATE PROCEDURE dbo.CapNhatHangHoa
    @MaHH CHAR(10),
	@TenHH NVARCHAR(30),
	@DonGia FLOAT,
    @SLTon INT,
	@NhaCC CHAR(10)
AS
BEGIN
    UPDATE HANGHOA
    SET TenHH = @TenHH, DonGia = @DonGia, SLTon = @SLTon, NhaCC = @NhaCC
    WHERE MaHH = @MaHH;
END;
GO

--xóa mã giảm giá 
CREATE PROCEDURE dbo.XoaMaGG
AS
BEGIN
    DELETE GIAMGIA
    WHERE NgayHet < GetDate();
END;
GO


--Procedure thêm hàng hóa
CREATE PROCEDURE dbo.ThemHangHoa(@TenHH NVARCHAR(30), @DonGia FLOAT, @SLTon INT, @NhaCC CHAR(10)) 
AS
BEGIN
	BEGIN
		DECLARE @MaHH CHAR(10)
		DECLARE @MaHangHoa CHAR(10) = 'HH00000001'
		DECLARE @idx int 
		SET @idx = 1
		WHILE EXISTS (SELECT MaHH FROM HANGHOA WHERE MaHH = @MaHangHoa)
		BEGIN
			SET @idx = @idx + 1
			SET @MaHangHoa = 'HH' + REPLICATE('0', 8 - len (cast(@idx as CHAR))) +cast(@idx as CHAR)
		END
		SET @MaHH = @MaHangHoa
	END
	BEGIN
	INSERT INTO HANGHOA (MaHH, TenHH, DonGia, SLTon, NhaCC) VALUES (@MaHH, @TenHH, @DonGia, @SLTon, @NhaCC)
	END
END;
GO

--Procedure xóa hàng hóa 
CREATE PROCEDURE dbo.XoaHangHoa(@MaHH CHAR(10))
AS
BEGIN
    DELETE FROM HANGHOA
    WHERE MaHH = @MaHH;
END;
GO

--Procedure thêm giảm giá
CREATE PROCEDURE dbo.ThemMaGG(@LoaiGG VARCHAR(20), @MaHH CHAR(10), @GiaTri INT, @NgayHet DATE, @DieuKien INT, @MaNQL CHAR(10)) 
AS
BEGIN
	BEGIN
		DECLARE @MaGG CHAR(10)
		DECLARE @MaGiamGia CHAR(10) = 'GG00000001'
		DECLARE @idx int 
		SET @idx = 1
		WHILE EXISTS (SELECT MaGG FROM GIAMGIA WHERE MaGG = @MaGiamGia)
		BEGIN
			SET @idx = @idx + 1
			SET @MaGiamGia = 'GG' + REPLICATE('0', 8 - len (cast(@idx as CHAR))) +cast(@idx as CHAR)
		END
		SET @MaGG = @MaGiamGia
	END
	BEGIN
	INSERT INTO GIAMGIA(MaGG, LoaiGG, MaHH, GiaTri, NgayHet, DieuKien, MaNQL) VALUES (@MaGG, @LoaiGG, @MaHH, @GiaTri, @NgayHet, @DieuKien, @MaNQL)
	END
END;
GO

--Procedure thêm khách hàng
CREATE PROCEDURE dbo.ThemKhachHang(@HoTen NVARCHAR(30), @DiaChi NVARCHAR(255), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @SDT VARCHAR(10), @MaTaiKhoan CHAR(10)) 
AS
BEGIN
	BEGIN
		DECLARE @MaKH CHAR(10)
		DECLARE @MaKhachHang CHAR(10) = 'KH00000001'
		DECLARE @idx int 
		SET @idx = 1
		WHILE EXISTS (SELECT MaKH FROM KHACHHANG WHERE MaKH = @MaKhachHang)
		BEGIN
			SET @idx = @idx + 1
			SET @MaKhachHang = 'KH' + REPLICATE('0', 8 - len (cast(@idx as CHAR))) +cast(@idx as CHAR)
		END
		SET @MaKH = @MaKhachHang
	END
	BEGIN
	INSERT INTO KHACHHANG (MaKH, HoTen, DiaChi, GioiTinh, NgaySinh, SDT, MaTaiKhoan) VALUES (@MaKH, @HoTen, @DiaChi, @GioiTinh, @NgaySinh, @SDT, @MaTaiKhoan)
	END
END;
GO

--Procedure xóa khách hàng
CREATE PROCEDURE dbo.XoaKhachHang(@MaKH CHAR(10)) 
AS
BEGIN
	DELETE FROM KHACHHANG 
	WHERE MaKH = @MaKH;
END;
GO

--Procedure cập nhật khách hàng
CREATE PROCEDURE dbo.CapNhatKhachHang(@MaKH CHAR(10), @HoTen NVARCHAR(30), @DiaChi NVARCHAR(255), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @SDT VARCHAR(10)) 
AS
BEGIN
	UPDATE KHACHHANG 
	SET HoTen = @HoTen,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh,
		NgaySinh = @NgaySinh,
		SDT = @SDT
	WHERE MaKH = @MaKH
END;
GO


--Procedure thêm tài khoản
CREATE PROCEDURE dbo.ThemTaiKhoan(@MaTaiKhoan CHAR(10), @TaiKhoan VARCHAR(255), @MatKhau VARCHAR(255), @PhanQuyen VARCHAR(50))
AS
BEGIN
    INSERT INTO TAIKHOAN (MaTaiKhoan, TaiKhoan, MatKhau, PhanQuyen)
    VALUES (@MaTaiKhoan, @TaiKhoan, @MatKhau, @PhanQuyen);
    BEGIN TRY
	DECLARE @sqlString nvarchar(2000)
		SET @sqlString = 'CREATE LOGIN [' + @TaiKhoan + '] WITH PASSWORD=N''' + @MatKhau
						 + ''', DEFAULT_DATABASE=[RAPCHIEUPHIM], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
		EXEC (@sqlString)
	
		SET @sqlString = 'CREATE USER ' + QUOTENAME(@TaiKhoan) + ' FOR LOGIN ' + QUOTENAME(@TaiKhoan)
		EXEC (@sqlString)
		-- Phân quyền cho user
		IF @PhanQuyen = 'QuanLy'
		BEGIN
			SET @sqlString = 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + QUOTENAME(@TaiKhoan)
		END
		ELSE IF @PhanQuyen = 'KhachHang'
		SET @sqlString = 'ALTER ROLE dbmsKhachHangRole ADD MEMBER ' + QUOTENAME(@TaiKhoan)
		ELSE IF @PhanQuyen = 'NhanVien'
		SET @sqlString = 'ALTER ROLE dbmsNhanVienRole ADD MEMBER ' + QUOTENAME(@TaiKhoan)
		EXEC (@sqlString)
     END TRY
     BEGIN CATCH
            -- Nếu có lỗi khi thêm login hoặc user, hiển thị thông báo lỗi
            RAISERROR('Lỗi khi thêm login, login đã tồn tại', 16, 1);
     END CATCH
END;
GO


----procedure xóa tài khoản
CREATE PROCEDURE [dbo].[XoaTaiKhoan]
    @MaTaiKhoan CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @username NVARCHAR(255);
    DECLARE @sql NVARCHAR(100);
    
    -- Lấy tên đăng nhập
    SELECT @username = TaiKhoan
    FROM TAIKHOAN
    WHERE MaTaiKhoan = @MaTaiKhoan;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Xóa thông tin từ bảng TAIKHOAN
        DELETE FROM TAIKHOAN WHERE MaTaiKhoan = @MaTaiKhoan;

        -- Xóa USER và LOGIN tương ứng (nếu tồn tại)
        IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @username)
        BEGIN
            -- Xóa USER
            SET @sql = 'DROP USER ' + QUOTENAME(@username);
            EXEC sp_executesql @sql;
            
            -- Xóa ROLE
            SET @sql = 'DROP ROLE ' + QUOTENAME(@username);
            EXEC sp_executesql @sql;
        END
        
        -- Xóa LOGIN
        IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = @username)
        BEGIN
            SET @sql = 'DROP LOGIN ' + QUOTENAME(@username);
            EXEC sp_executesql @sql;
        END
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Lỗi ' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH

    COMMIT TRANSACTION;
END;
GO


--Procedure thêm nhân viên
CREATE PROCEDURE dbo.ThemNhanVien(@HoTen NVARCHAR(30), @DiaChi NVARCHAR(50), @NgaySinh DATE, @SDT VARCHAR(10), @GioiTinh VARCHAR(10), @ChucVu VARCHAR(20), @MaTaiKhoan CHAR(10), @Luong FLOAT) 
AS
BEGIN
	BEGIN
		DECLARE @MaNV CHAR(10)
		DECLARE @MaNhanVien CHAR(10) = 'NV00000001'
		DECLARE @idx int 
		SET @idx = 1
		WHILE EXISTS (SELECT MaNV FROM NHANVIEN WHERE MaNV = @MaNhanVien)
		BEGIN
			SET @idx = @idx + 1
			SET @MaNhanVien = 'NV' + REPLICATE('0', 8 - len (cast(@idx as CHAR))) +cast(@idx as CHAR)
		END
		SET @MaNV = @MaNhanVien
	END
	BEGIN
	INSERT INTO NHANVIEN (MaNV, HoTen, DiaChi, NgaySinh, SDT, GioiTinh, ChucVu, MaTaiKhoan, Luong) VALUES (@MaNV, @HoTen, @DiaChi, @NgaySinh, @SDT, @GioiTinh, @ChucVu, @MaTaiKhoan, @Luong)
	END
END;
GO

--Procedure xóa nhân viên
CREATE PROCEDURE dbo.XoaNhanVien(@MaNV CHAR(10)) 
AS
BEGIN
	DELETE FROM NHANVIEN 
	WHERE MaNV = @MaNV;
END;
GO

--Procedure cập nhật nhân viên
CREATE PROCEDURE dbo.CapNhatNhanVien(@MaNV CHAR(10), @HoTen NVARCHAR(30), @DiaChi NVARCHAR(50), @NgaySinh DATE, @SDT VARCHAR(10), @GioiTinh VARCHAR(10), @ChucVu VARCHAR(20), @Luong FLOAT) 
AS
BEGIN
	UPDATE NHANVIEN 
	SET 	HoTen = @HoTen,
		DiaChi = @DiaChi,
		NgaySinh = @NgaySinh,
		SDT = @SDT,
		GioiTinh = @GioiTinh,
		ChucVu = @ChucVu,
		Luong = @Luong
	WHERE MaNV = @MaNV
END;
GO

--Procedure về thêm thể loại phim (trigger)
CREATE PROCEDURE dbo.ThemTheLoai(@MaPhim CHAR(10), @TheLoai NVARCHAR(20)) 
AS
BEGIN
	INSERT INTO THELOAIPHIM(MaPhim, TheLoai) VALUES(@MaPhim, @TheLoai)
END;
GO

--Procedure Them Phim
CREATE PROCEDURE dbo.ThemPhim (@MaPhim CHAR(10), @TenPhim NVARCHAR(30), @DaoDien NVARCHAR(30), @NhaSX NVARCHAR(30), @NamSX INT, @HinhThuc NVARCHAR(20), @DinhDang VARCHAR(2), @XepLoai VARCHAR(5), @DoDai INT, @MoTa TEXT, @HinhAnh VARBINARY(MAX))
AS
BEGIN
	INSERT INTO PHIM (MaPhim, TenPhim, DaoDien, NhaSX, NamSX, HinhThuc, DinhDang, XepLoai, DoDai, MoTa, HinhAnh) VALUES (@MaPhim, @TenPhim, @DaoDien, @NhaSX, @NamSX, @HinhThuc, @DinhDang, @XepLoai, @DoDai, @MoTa, @HinhAnh);
END;
GO

--Procedure Xoa Phim
CREATE PROCEDURE dbo.XoaPhim
	@MaPhim CHAR(10)
AS
BEGIN
	DELETE FROM PHIM
	WHERE MaPhim = @MaPhim;
END;
GO

--Procedure Them lich chieu
CREATE PROCEDURE dbo.ThemLichChieu
    @ThoiGianChieu DATETIME,
    @ThoiGianHet DATETIME,
    @MaPhong CHAR(10),
    @MaPhim CHAR(10)
AS
BEGIN
    DECLARE @MaLC CHAR(30);
	DECLARE @MaPhongTemp CHAR(7);
	DECLARE @MaPhimTemp CHAR(7);

    SET @MaPhongTemp = RIGHT(@MaPhong, 7);
    SET @MaPhimTemp = RIGHT(@MaPhim, 7);

    -- Tạo MaLC bằng cách kết hợp MaPhong, MaPhim, và ThoiGianChieu
    SET @MaLC = @MaPhongTemp + '_' + @MaPhimTemp + 'TGC' + REPLACE(REPLACE(REPLACE(CONVERT(VARCHAR(17), @ThoiGianChieu, 120), '-', ''), ' ', ''), ':', '');
    -- Insert dữ liệu vào bảng LICHCHIEU với MaLC được tạo
    INSERT INTO LICHCHIEU(MaLC, ThoiGianChieu, ThoiGianHet, MaPhong, MaPhim)
    VALUES (@MaLC, @ThoiGianChieu, @ThoiGianHet, @MaPhong, @MaPhim);
END;
GO

--Procedure xoa lich chieu
CREATE PROCEDURE dbo.XoaLichChieu
	@MaLC CHAR(30)
AS
BEGIN
	DELETE FROM LICHCHIEU
	WHERE MaLC = @MaLC;
END;
GO

--Procedure Them NhaCC
CREATE PROCEDURE dbo.ThemNhaCungCap
    	@TenNCC NVARCHAR(30),
    	@DiaChi NVARCHAR(50),
    	@SDT VARCHAR(10)
AS
BEGIN
	BEGIN
		DECLARE @MANCC CHAR(10) = 'NCC0000001'
		DECLARE @idx int 
		SET @idx = 1
		WHILE EXISTS (SELECT MaNCC FROM NHACUNGCAP WHERE MaNCC = @MANCC)
		BEGIN
			SET @idx = @idx + 1
			SET @MANCC = 'NCC' + REPLICATE('0', 7 - len (cast(@idx as CHAR))) +cast(@idx as CHAR)
		END
		SET @MaNCC = @MANCC
	END
	BEGIN
	INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SDT) VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT);
	END
END;
GO

--Procedure Xoa NhaCC
CREATE PROCEDURE dbo.XoaNhaCungCap
	@MaNCC CHAR(10)
AS
BEGIN 
	DELETE NHACUNGCAP
	WHERE MaNCC = @MaNCC;
END;
GO

--Procedure Them Dien vien
CREATE PROCEDURE dbo.ThemDienVien
		@MaDV CHAR(10),
    	@TenDV NVARCHAR(30)
AS
BEGIN
	INSERT INTO DIENVIEN(MaDV, TenDV) VALUES (@MaDV, @TenDV);
END;
GO

--- Procedure Xóa hóa đơn
CREATE PROCEDURE dbo.XoaHoaDon
	@MaHD CHAR(10)
AS
BEGIN 
	DELETE HOADON
	WHERE MaHD = @MaHD;
END;
GO

CREATE PROCEDURE dbo.CapNhatThongTinKhachHang
	@MaKH CHAR(10),
	@HoTen NVARCHAR(30),
	@DiaChi NVARCHAR(255),
	@GioiTinh NVARCHAR(10),
	@NgaySinh DATE, 
	@SDT VARCHAR(10)
AS
BEGIN
	UPDATE KHACHHANG
	SET HoTen = @HoTen,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh,
		NgaySinh = @NgaySinh,
		SDT = @SDT
	WHERE MaKH = @MaKH;
END;
GO

CREATE PROCEDURE dbo.CapNhatThongTinNhanVien
	@MaNV CHAR(10),
	@HoTen NVARCHAR(30),
	@DiaChi NVARCHAR(255),
	@GioiTinh NVARCHAR(10),
	@NgaySinh DATE, 
	@SDT VARCHAR(10)
AS
BEGIN
	UPDATE NHANVIEN
	SET HoTen = @HoTen,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh,
		NgaySinh = @NgaySinh,
		SDT = @SDT
	WHERE MaNV = @MaNV;
END;
GO



--Procedure Them Tham Gia
CREATE PROCEDURE dbo.ThemThamGia
		@MaDV CHAR(10),
    	@MaPhim CHAR(10),
		@VaiTro NVARCHAR(50)
AS
BEGIN
	INSERT INTO THAMGIA(MaDV, MaPhim, VaiTro) VALUES (@MaDV, @MaPhim, @VaiTro);
END;
GO

---Thêm phòng chiếu
CREATE PROCEDURE dbo.ThemPhongChieu
	@MaPhong CHAR(10),
	@SLGheVIP INT,
	@SLGheThuong INT,
	@SLGheDoi INT
AS
BEGIN
	INSERT INTO PHONGCHIEU VALUES(@MaPhong, @SLGheVip, @SLGheThuong, @SLGheDoi);
END;
GO

--Cập nhật phòng chiếu
CREATE PROCEDURE dbo.CapNhatPhongChieu
	@MaPhong CHAR(10),
	@SLGheVIP INT,
	@SLGheThuong INT,
	@SLGheDoi INT
AS
BEGIN
	UPDATE PHONGCHIEU
	SET SLGheVIP = @SLGheVIP,
		SLGheThuong = @SLGheThuong,
		SLGheDoi = @SLGheDoi
	WHERE MaPhong = @MaPhong
END;
GO


CREATE PROCEDURE dbo.ThemHoaDon
	@MaHD CHAR(10),
	@ThoiGian DATETIME,
	@TongTien FLOAT,
	@PhuongThucTT VARCHAR(20),
	@MaKH CHAR(10),
	@MaNV CHAR(10),
	@MaGG CHAR(10)
AS
BEGIN
	IF (@MaKH = '0' and @MaNV <> '0' and @MaGG <> '0')
	BEGIN
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, NULL, @MaNV, @MaGG);
	END
	ELSE IF (@MaKH = '0' and @MaGG = '0' and @MaNV <> '0')
	BEGIN 
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, NULL, @MaNV, NULL);
	END
	ELSE IF (@MaKH <> '0' and @MaNV <> '0' and  @MaGG = '0')
	BEGIN 
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, @MaKH, @MaNV, NULL);
	END
	ELSE IF (@MaGG = '0' and @MaKH <> '0' and @MaNV = '0')
	BEGIN 
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, @MaKH, NULL, NULL);
	END
	ELSE IF (@MaGG <> '0' and @MaNV = '0' and @MaKH <> '0')
	BEGIN 
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, @MaKH, NULL, @MaGG);
	END
	ELSE
	BEGIN
		INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG) VALUES(@MaHD, @ThoiGian, @TongTien, @PhuongThucTT, @MaKH, @MaNV, @MaGG);
	END
END;
GO


CREATE PROCEDURE dbo.ThemCHITIETHDHH
	@MaHD CHAR(10),
	@MaHH CHAR(10),
	@SL INT,
	@TongTien FLOAT
AS
BEGIN
	INSERT INTO CHITIETHDHH(MaHD, MaHH, SL, TongTien) VALUES(@MaHD, @MaHH, @SL, @TongTien);
END;
GO


CREATE PROCEDURE dbo.CapNhatMaHDVaTrangThai
	@MaVe CHAR(36),
	@MaHD CHAR(10),
	@TrangThai BIT
AS
BEGIN
	UPDATE VE
	SET MaHD = @MaHD,
		TrangThai = @TrangThai
	WHERE MaVe = @MaVe
END;
GO

CREATE PROCEDURE dbo.ThemGiamGia
	@MaGG CHAR(10),
	@LoaiGG VARCHAR(20),
	@MaHH CHAR(10),
	@GiaTri INT,
	@NgayHet DATE,
	@DieuKien INT,
	@MaNQL CHAR(10)
AS
BEGIN
	INSERT INTO GIAMGIA VALUES(@MaGG, @LoaiGG, @MaHH, @GiaTri, @NgayHet, @DieuKien, @MaNQL)
END;
GO

CREATE PROCEDURE dbo.CapNhatGiamGia
	@MaGG CHAR(10),
	@LoaiGG VARCHAR(20),
	@MaHH CHAR(10),
	@GiaTri INT,
	@NgayHet DATE,
	@DieuKien INT
AS
BEGIN
	UPDATE GIAMGIA SET LoaiGG = @LoaiGG, MaHH = @MaHH, GiaTri = @GiaTri, NgayHet = @NgayHet, DieuKien = @DieuKien
	WHERE MaGG = @MaGG
END;
GO

CREATE PROCEDURE dbo.XoaGiamGia
	@MaGG CHAR(10)
AS
BEGIN
	DELETE FROM GIAMGIA WHERE MaGG = @MaGG
END;
GO

CREATE PROCEDURE dbo.KiemTraGiamGiaHetHan
AS
BEGIN
	DECLARE @MaGG CHAR(10), @NgayHet DATE;
	DECLARE @Cursor CURSOR;
	SET @Cursor = CURSOR FOR
		SELECT MaGG, NgayHet
		FROM GIAMGIA;
	OPEN @Cursor;
	FETCH NEXT FROM @Cursor INTO @MaGG, @NgayHet;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @NgayHet <= GETDATE()
		BEGIN
			DELETE NHAN WHERE MaGG = @MaGG;
			DELETE GIAMGIA WHERE MaGG = @MaGG;
		END
		FETCH NEXT FROM @Cursor INTO @MaGG, @NgayHet;
	END
	CLOSE @Cursor;
    DEALLOCATE @Cursor;
END;
GO