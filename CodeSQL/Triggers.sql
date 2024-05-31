-----------------TRIGGERS------------------------------------------------

-- Trigger kiểm tra trùng thời gian chiếu và độ dài của bộ phim phù hợp với thời gian chiếu và thời gian hết
CREATE TRIGGER KiemTraThoiGianChieu
ON LICHCHIEU
INSTEAD OF INSERT
AS
BEGIN
    -- Kiểm tra trùng thời gian chiếu ở cùng một phòng
    IF NOT EXISTS (
        SELECT 1
        FROM LICHCHIEU lc
        INNER JOIN inserted i ON lc.MaPhong = i.MaPhong
        WHERE (
            (i.ThoiGianChieu >= lc.ThoiGianChieu AND i.ThoiGianChieu < lc.ThoiGianHet)
            OR (i.ThoiGianChieu < lc.ThoiGianChieu AND i.ThoiGianHet > lc.ThoiGianChieu)
        )
    )
    BEGIN
        -- Kiểm tra độ dài của phim
        IF EXISTS (
            SELECT 1
            FROM PHIM p
            INNER JOIN inserted i ON p.MaPhim = i.MaPhim
            WHERE DATEDIFF(MINUTE, i.ThoiGianChieu, i.ThoiGianHet) >= p.DoDai
        )
        BEGIN
            INSERT INTO LICHCHIEU (MaLC, ThoiGianChieu, ThoiGianHet, MaPhong, MaPhim)
            SELECT MaLC, ThoiGianChieu, ThoiGianHet, MaPhong, MaPhim
            FROM inserted;
        END
        ELSE
        BEGIN
            RAISERROR('Độ dài của phim không phù hợp với thời gian chiếu.', 16, 1);
        END
    END
    ELSE
    BEGIN
        RAISERROR('Trùng thời gian chiếu ở cùng một phòng.', 16, 1);
    END
END;
GO

-- Tạo trigger kiểm tra khi cập nhật trạng thái của vé
CREATE TRIGGER KiemTraCapNhatTrangThaiVe
ON VE
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TrangThai)
    BEGIN
        IF EXISTS (
                SELECT 1
                FROM deleted
                WHERE MaVe IN (SELECT MaVe FROM inserted) AND TrangThai = 1
            )
        BEGIN
                RAISERROR('Vé đã được mua trước đó.', 16, 1);
        END
        ELSE
        BEGIN
            -- Lấy thông tin về trạng thái cập nhật và MaHD cập nhật
            DECLARE @TrangThai BIT;
            DECLARE @MaHD CHAR(10);
            SELECT @TrangThai = TrangThai, @MaHD = MaHD FROM inserted;

            -- Kiểm tra nếu TrangThai được cập nhật từ 0 sang 1
            IF @TrangThai = 1
            BEGIN
                -- Cập nhật MaHD vào bản ghi trong bảng VE
                UPDATE VE
                SET MaHD = @MaHD
                WHERE MaVe IN (SELECT MaVe FROM inserted);               
            END
        END
    END
END;
GO

-- Tạo trigger sau khi thêm bản ghi vào bảng LICHCHIEU
CREATE TRIGGER TaoVeTuDong
ON LICHCHIEU
AFTER INSERT
AS
BEGIN
    -- Lấy MaLC từ bản ghi mới thêm vào
    DECLARE @MaLC CHAR(30)
    SELECT @MaLC = MaLC FROM inserted;

    -- Lấy số lượng ghế từ bản ghi mới thêm vào
    DECLARE @SLGheThuong INT, @SLGheVIP INT, @SLGheDoi INT
    SELECT @SLGheThuong = P.SLGheThuong, @SLGheVIP = P.SLGheVIP, @SLGheDoi = P.SLGheDoi
    FROM inserted I
    INNER JOIN PHONGCHIEU P ON I.MaPhong = P.MaPhong;

    -- Tạo biến ký tự cho mã vé
    DECLARE @MaVe CHAR(36)

    -- Tạo mã vé cho ghế thường
    DECLARE @Dem INT
    SET @Dem = 1
    WHILE @Dem <= @SLGheThuong
    BEGIN
        SET @MaVe = @MaLC + CHAR(64 + ((@Dem - 1) % 5) + 1) + 
                    RIGHT('0' + CAST((@Dem - 1) / 5 + 1 AS CHAR(2)), 2) + 'THU'
        -- Thêm mã vé vào bảng VE
        INSERT INTO VE (MaVe, LoaiVe, Gia, MaLC, TrangThai)
        VALUES (@MaVe, 'Thuong', 65000, @MaLC, 0);
        SET @Dem = @Dem + 1;
    END

    -- Tạo mã vé cho ghế VIP
    SET @Dem = 1
    WHILE @Dem <= @SLGheVIP
    BEGIN
        SET @MaVe = @MaLC + CHAR(69 + ((@Dem - 1) % 6) + 1) + 
                    RIGHT('0' + CAST((@Dem - 1) / 6 + 1 AS CHAR(2)), 2) + 'VIP'
        -- Thêm mã vé vào bảng VE
        INSERT INTO VE (MaVe, LoaiVe, Gia, MaLC, TrangThai)
        VALUES (@MaVe, 'VIP', 75000, @MaLC, 0);
        SET @Dem = @Dem + 1;
    END

    -- Tạo mã vé cho ghế Đối
    SET @Dem = 1
    WHILE @Dem <= @SLGheDoi
    BEGIN
        SET @MaVe = @MaLC + 'L' + 
                    RIGHT('0' + CAST(@Dem AS VARCHAR(2)), 2) + 'DOI'
        -- Thêm mã vé vào bảng VE
        INSERT INTO VE (MaVe, LoaiVe, Gia, MaLC, TrangThai)
        VALUES (@MaVe, 'Doi', 130000, @MaLC, 0);
        SET @Dem = @Dem + 1;
    END
END;
GO


CREATE TRIGGER KiemTraNgayHetGG
ON HOADON
AFTER INSERT AS
BEGIN
	DECLARE @MaHD CHAR(10);
	DECLARE @MaGG CHAR(10);
	
	SELECT @MaHD = MaHD, @MaGG = MaGG FROM inserted;

	IF EXISTS (SELECT 1 FROM GIAMGIA WHERE MaGG = @MaGG AND NgayHet < GETDATE())
		BEGIN
			UPDATE HOADON
			SET MAGG = null
			WHERE MaGG = @MaGG
			RAISERROR('Mã giảm giá đã hết hạn.', 16, 1);
		END
END;
GO
------Cap nhat diem tich luy
CREATE TRIGGER CapNhatDiemTichLuy
ON HOADON
AFTER INSERT
AS
BEGIN
    DECLARE @MaKH CHAR(10);
    DECLARE @TongTien FLOAT;

    -- Lấy mã khách hàng và tổng tiền từ hóa đơn mới được thêm vào
    SELECT @MaKH = i.MaKH, @TongTien = i.TongTien
    FROM HOADON h
    INNER JOIN INSERTED i ON h.MaHD = i.MaHD;

    -- Tính số điểm tích lũy dựa trên tổng tiền
    DECLARE @SoDiem INT;
    SET @SoDiem = CONVERT(INT, @TongTien / 1000);

    -- Cập nhật số điểm tích lũy cho khách hàng
    UPDATE KHACHHANG
    SET DiemTL = DiemTL + @SoDiem
    WHERE MaKH = @MaKH;

    -- Update LoaiKH
    DECLARE @LoaiKH VARCHAR(10),
            @DiemTL INT;
    SET @DiemTL = (SELECT DiemTL FROM KHACHHANG WHERE MaKH = @MaKH)
    IF @DiemTL >= 1000 AND @DiemTL < 2500
        SET @LoaiKH = 'Bac';
    ELSE IF @DiemTL >= 2500 AND @DiemTL < 5000
        SET @LoaiKH = 'Vang';
    ELSE IF @DiemTL >= 5000
        SET @LoaiKH = 'KimCuong';
    UPDATE KHACHHANG
    SET LoaiKH = @LoaiKH
    WHERE MaKH = @MaKH;

    -- Kiểm tra và thêm mã giảm giá vào bảng NHAN
    DECLARE @MaGG CHAR(10), @DieuKien INT;
    DECLARE @Cursor CURSOR;
    SET @Cursor = CURSOR FOR
        SELECT MaGG, DieuKien
        FROM GIAMGIA;
    OPEN @Cursor;
    FETCH NEXT FROM @Cursor INTO @MaGG, @DieuKien;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @SL INT;
        IF @LoaiKH = 'Dong'
            SET @SL = 1;
        ELSE IF @LoaiKH = 'Bac'
            SET @SL = 2;
        ELSE IF @LoaiKH = 'Vang'
            SET @SL = 3;
        ELSE IF @LoaiKH = 'KimCuong'
            SET @SL = 4;

        IF @DiemTL >= @DieuKien AND @DieuKien <> 0
        BEGIN
            -- Kiểm tra xem mã giảm giá đã tồn tại trong bảng NHAN với cùng mã khách hàng hay chưa
            IF NOT EXISTS (SELECT 1 FROM NHAN WHERE MaKH = @MaKH AND MaGG = @MaGG)
            BEGIN
                INSERT INTO NHAN (MaKH, MaGG, SL)
                VALUES (@MaKH, @MaGG, @SL);
            END
        END
        FETCH NEXT FROM @Cursor INTO @MaGG, @DieuKien;
    END
    CLOSE @Cursor;
    DEALLOCATE @Cursor;
END;
GO

--Trigger khi xóa nhân viên cx xóa lun tài khoản
CREATE TRIGGER XoaTaiKhoanNhanVien
ON NHANVIEN
AFTER DELETE
AS
BEGIN
    DELETE FROM TAIKHOAN
    WHERE MaTaiKhoan IN (SELECT MaTaiKhoan FROM DELETED);
END;
GO

-----trigger check tài khoản
CREATE TRIGGER KiemTraThemTaiKhoan
ON TAIKHOAN
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaTaiKhoan)) = '')
    BEGIN
        RAISERROR('Mã tài khoản không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(TaiKhoan)) = '')
    BEGIN
        RAISERROR('Tên tài khoản không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MatKhau)) = '')
    BEGIN
        RAISERROR('Mật khẩu không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(PhanQuyen)) = '')
    BEGIN
        RAISERROR('Phân Quyền không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    IF EXISTS (
        SELECT 1
        FROM [dbo].[TAIKHOAN] t
        JOIN inserted i ON RTRIM(LTRIM(t.TaiKhoan)) = RTRIM(LTRIM(i.TaiKhoan))
        WHERE t.TaiKhoan != i.TaiKhoan
    )
    BEGIN
        RAISERROR('Tên tài khoản đã tồn tại trong hệ thống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END
GO


-- trigger check thêm hàng hóa
CREATE TRIGGER KiemTraThemHangHoa
ON HANGHOA
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
	IF EXISTS (SELECT MaHH FROM inserted WHERE RTRIM(LTRIM(MaHH)) = '')
    BEGIN
        RAISERROR('Mã hàng hóa không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
    IF EXISTS (SELECT TenHH FROM inserted WHERE RTRIM(LTRIM(TenHH)) = '')
    BEGIN
        RAISERROR('Tên hàng hóa không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT DonGia FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), DonGia))) = '')
    BEGIN
        RAISERROR('Đơn giá không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
    IF EXISTS (SELECT DonGia FROM inserted WHERE DonGia <= 0)
    BEGIN
        RAISERROR ('Đơn giá phải lớn hơn 0', 16, 1);
        ROLLBACK; 
        RETURN;
    END
	IF EXISTS (SELECT SLTon FROM inserted WHERE SLTon < 0)
    BEGIN
        RAISERROR ('SL tồn phải lớn hơn hoặc bằng 0', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT SLTon FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), SLTon))) = '')
    BEGIN
        RAISERROR('SL tồn không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT NhaCC FROM inserted WHERE RTRIM(LTRIM(NhaCC)) = '')
    BEGIN
        RAISERROR('Nhà cung cấp không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END  
	IF NOT EXISTS (SELECT 1 FROM NHACUNGCAP WHERE MaNCC = (SELECT TOP 1 NhaCC FROM inserted))
    BEGIN
        RAISERROR('Nhà cung cấp không tồn tại trong bảng NHACUNGCAP', 16, 1);
		ROLLBACK;
        RETURN;
    END
	INSERT INTO HANGHOA (MaHH, TenHH, DonGia, SLTon, NhaCC)
    SELECT MaHH, TenHH, DonGia, SLTon, NhaCC FROM inserted;
END;
GO

-----trigger check cập nhật hàng hóa
CREATE TRIGGER KiemTraCapNhatHangHoa
ON HANGHOA
INSTEAD OF UPDATE
AS
BEGIN
	SET NOCOUNT ON;
    IF EXISTS (SELECT TenHH FROM inserted WHERE RTRIM(LTRIM(TenHH)) = '')
    BEGIN
        RAISERROR('Tên hàng hóa không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT DonGia FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), DonGia))) = '')
    BEGIN
        RAISERROR('Đơn giá không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
    IF EXISTS (SELECT DonGia FROM inserted WHERE DonGia <= 0)
    BEGIN
        RAISERROR('Đơn giá phải lớn hơn 0', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT SLTon FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), SLTon))) = '')
    BEGIN
        RAISERROR('SL tồn không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
    IF EXISTS (SELECT SLTon FROM inserted WHERE SLTon < 0)
    BEGIN
        RAISERROR('SL tồn phải lớn hơn hoặc bằng 0', 16, 1);
        ROLLBACK;
        RETURN;
    END

    IF EXISTS (SELECT NhaCC FROM inserted WHERE RTRIM(LTRIM(NhaCC)) = '')
    BEGIN
        RAISERROR('Nhà cung cấp không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END  

    IF NOT EXISTS (SELECT 1 FROM NHACUNGCAP WHERE MaNCC IN (SELECT NhaCC FROM inserted))
    BEGIN
        RAISERROR('Nhà cung cấp không tồn tại trong bảng NHACUNGCAP', 16, 1);
        ROLLBACK;
        RETURN;
    END
	UPDATE HANGHOA
    SET TenHH = i.TenHH,
        DonGia = i.DonGia,
        SLTon = i.SLTon,
        NhaCC = i.NhaCC
    FROM HANGHOA h
    INNER JOIN inserted i ON h.MaHH = i.MaHH;
END;
GO

-----trigger check nhà cung cấp
CREATE TRIGGER KiemTraThemNhaCC
ON NHACUNGCAP
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaNCC)) = '')
    BEGIN
        RAISERROR('Mã nhà cung cấp không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(TenNCC)) = '')
    BEGIN
        RAISERROR('Tên nhà cung cấp không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(DiaChi)) = '')
    BEGIN
        RAISERROR('Địa chỉ không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(SDT)) = '')
    BEGIN
        RAISERROR('Số điện thoại không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT 1 FROM inserted WHERE LEN(SDT) <> 10 OR SDT LIKE '%[^0-9]%')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Phải có đúng 10 chữ số và chỉ chứa chữ số.', 16, 1);
        ROLLBACK;
        RETURN;
    END
END
GO

-----trigger check thêm khách hàng
CREATE TRIGGER KiemTraThemKhachHang
ON KHACHHANG
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaKH)) = '')
    BEGIN
        RAISERROR('Mã khách hàng không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(HoTen)) = '')
    BEGIN
        RAISERROR('Tên khách hàng không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(DiaChi)) = '')
    BEGIN
        RAISERROR('Địa chỉ không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(GioiTinh)) = '')
    BEGIN
        RAISERROR('Giới tính không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT NgaySinh FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), NgaySinh))) = '')
    BEGIN
        RAISERROR('Ngày sinh không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT 1 FROM inserted WHERE NgaySinh > GETDATE())
    BEGIN
        RAISERROR('Ngày sinh không thể là ngày trong tương lai.', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(SDT)) = '')
    BEGIN
        RAISERROR('Số điện thoại không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT 1 FROM inserted WHERE LEN(SDT) <> 10 OR SDT LIKE '%[^0-9]%')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Phải có đúng 10 chữ số và chỉ chứa chữ số.', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT MaTaiKhoan FROM inserted WHERE RTRIM(LTRIM(MaTaiKhoan)) = '')
    BEGIN
        RAISERROR('Mã tài khoản không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END  

    IF NOT EXISTS (SELECT 1 FROM TAIKHOAN WHERE MaTaiKhoan IN (SELECT MaTaiKhoan FROM inserted))
    BEGIN
        RAISERROR('Mã tài khoản không tồn tại trong bảng TAIKHOAN', 16, 1);
        ROLLBACK;
        RETURN;
    END
END
GO

---TRIGGER CHECK cập nhật khách hàng
CREATE TRIGGER KiemTraCapNhatKhachHang
ON KHACHHANG
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaKH)) = '')
    BEGIN
        RAISERROR('Mã khách hàng không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(HoTen)) = '')
    BEGIN
        RAISERROR('Tên khách hàng không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(DiaChi)) = '')
    BEGIN
        RAISERROR('Địa chỉ không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(GioiTinh)) = '')
    BEGIN
        RAISERROR('Giới tính không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT NgaySinh FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), NgaySinh))) = '')
    BEGIN
        RAISERROR('Ngày sinh không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT 1 FROM inserted WHERE NgaySinh > GETDATE())
    BEGIN
        RAISERROR('Ngày sinh không thể là ngày trong tương lai.', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(SDT)) = '')
    BEGIN
        RAISERROR('Số điện thoại không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF EXISTS (SELECT 1 FROM inserted WHERE LEN(SDT) <> 10 OR SDT LIKE '%[^0-9]%')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Phải có đúng 10 chữ số và chỉ chứa chữ số.', 16, 1);
        ROLLBACK;
        RETURN;
    END
	UPDATE KHACHHANG
	SET HoTen = i.HoTen,
		DiaChi = i.DiaChi,
		GioiTinh = i.GioiTinh,
		NgaySinh = i.NgaySinh,
		SDT = i.SDT,
		DiemTL = i.DiemTL
	FROM KHACHHANG kh
    INNER JOIN inserted i ON kh.MaKH = i.MaKH;
END
GO


---trigger kiểm tra lịch chiếu
CREATE TRIGGER KiemTraThemLichChieu
ON LICHCHIEU
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaLC)) = '')
    BEGIN
        RAISERROR('Mã lịch chiếu không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaPhong)) = '')
    BEGIN
        RAISERROR('Mã phòng không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF NOT EXISTS (SELECT 1 FROM PHONGCHIEU WHERE MaPhong IN (SELECT MaPhong FROM inserted))
    BEGIN
        RAISERROR('Mã phòng không tồn tại trong bảng PHONGCHIEU', 16, 1);
        ROLLBACK;
        RETURN;
    END
    IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(MaPhim)) = '')
    BEGIN
        RAISERROR('Mã phim không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
	IF NOT EXISTS (SELECT 1 FROM PHIM WHERE MaPhim IN (SELECT MaPhim FROM inserted))
    BEGIN
        RAISERROR('Mã phim không tồn tại trong bảng PHIM', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT ThoiGianChieu FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), ThoiGianChieu))) = '')
    BEGIN
        RAISERROR('Thời gian chiếu không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	IF EXISTS (SELECT ThoiGianHet FROM inserted WHERE LTRIM(RTRIM(CONVERT(NVARCHAR(50), ThoiGianHet))) = '')
    BEGIN
        RAISERROR('Thời gian hết không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
END
GO




---- Trigger khi xóa tài khoản khách hàng
CREATE TRIGGER XoaTaiKhoanKhachHang
ON KHACHHANG
AFTER DELETE
AS
BEGIN
    DELETE FROM TAIKHOAN
    WHERE MaTaiKhoan IN (SELECT MaTaiKhoan FROM DELETED);
END;
GO


--trigger kiểm tra khi thêm hoặc cập nhật nhân viên
CREATE TRIGGER KIEMTRATHEMNHANVIEN
ON NHANVIEN
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM inserted WHERE LEN(SDT) <> 10 OR SDT LIKE '%[^0-9]%')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Phải có đúng 10 chữ số và chỉ chứa chữ số.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(HoTen)) = '')
	BEGIN
        RAISERROR('Họ tên không được để trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(DiaChi)) = '')
	BEGIN
        RAISERROR('Địa chỉ không được để trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(GioiTinh)) = '')
	BEGIN
        RAISERROR('Giới tính không được để trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT * FROM inserted WHERE RTRIM(LTRIM(HoTen)) = '')
	BEGIN
        RAISERROR('Chức vụ không được để trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT * FROM inserted WHERE Luong <= 0)
	BEGIN
        RAISERROR('Mức lương không được bé hơn 0.', 16, 1);
        ROLLBACK;
        RETURN;
    END
END;
GO

--trigger kiểm tra khi thêm hoặc cập nhật phòng chiếu
CREATE TRIGGER KiemTraThemPhongChieu
ON PHONGCHIEU
INSTEAD OF INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheVIP is null OR SLGheThuong is null OR SLGheDoi is null)
    BEGIN
        RAISERROR('Số lượng ghế không được để trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheVIP <= 0 OR SLGheThuong <= 0 OR SLGheDoi <= 0)
    BEGIN
        RAISERROR('Số lượng ghế không hợp lệ (số lượng ghế phải lớn hơn 0).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheVIP % 6 != 0)
    BEGIN
        RAISERROR('Số lượng ghế VIP không hợp lệ (số lượng ghế phải chia hết cho 6).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheThuong % 5 != 0)
    BEGIN
        RAISERROR('Số lượng ghế thường không hợp lệ (số lượng ghế phải chia hết cho 5).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheThuong != SLGheVIP * 5 / 6)
    BEGIN
        RAISERROR('Số lượng ghế không hợp lệ (số lượng ghế thường phải bằng 5/6 số lượng ghế VIP).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheDoi > SLGheVIP/12 AND SLGheVIP >= 12)
    BEGIN
        RAISERROR('Số lượng ghế không hợp lệ (số lượng ghế đôi  phải ít hơn hoặc bằng 1/12 số lượng ghế VIP).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE SLGheVIP < 12 AND SLGheDoi > 0)
    BEGIN
        RAISERROR('Số lượng ghế không hợp lệ (số lượng ghế đôi  phải ít hơn hoặc bằng 1/12 số lượng ghế VIP).', 16, 1);
        ROLLBACK;
        RETURN;
    END

	INSERT INTO PHONGCHIEU(MaPhong, SLGheVIP, SLGheThuong, SLGheDoi)
	SELECT MaPhong, SLGheVIP, SLGheThuong, SLGheDoi
	FROM inserted
END;
GO

--trigger kiểm tra khi thêm hoặc cập nhật phim
CREATE TRIGGER KiemTraThemPhim
ON PHIM
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	
	IF EXISTS (SELECT 1 FROM inserted WHERE RTRIM(LTRIM(TenPhim)) = '')
    BEGIN
        RAISERROR('Tên phim không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE RTRIM(LTRIM(DaoDien)) = '')
    BEGIN
        RAISERROR('Tên đạo diễn không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE RTRIM(LTRIM(NhaSX)) = '')
    BEGIN
        RAISERROR('Tên nhà sản xuất không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE RTRIM(LTRIM(TenPhim)) = '')
    BEGIN
        RAISERROR('Tên phim không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted WHERE DoDai <= 0)
    BEGIN
        RAISERROR('Độ dài phim không được bé hơn hoặc bằng 0.', 16, 1);
        ROLLBACK;
        RETURN;
    END
END;
GO


-----Trigger Kiem Tra PTTT 
CREATE TRIGGER KiemTraThemHoaDon
ON HOADON
INSTEAD OF INSERT
AS
BEGIN
	IF EXISTS (SELECT PhuongThucTT FROM inserted WHERE RTRIM(LTRIM(PhuongThucTT)) = '')
    BEGIN
        RAISERROR('Phương thức thanh toán không được để trống', 16, 1);
        ROLLBACK;
        RETURN;
    END
	INSERT INTO HOADON(MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG)
    SELECT MaHD, ThoiGian, TongTien, PhuongThucTT, MaKH, MaNV, MaGG FROM inserted;
END
go

--trigger kiem tra so luong ton
CREATE TRIGGER KiemTraSLTonKho
ON CHITIETHDHH
INSTEAD OF INSERT
AS
BEGIN
    -- Kiểm tra và thực hiện cập nhật
    IF NOT EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN HANGHOA h ON i.MaHH = h.MaHH
        WHERE i.SL <= h.SLTon
    )
    BEGIN
        -- Hiển thị thông báo lỗi "Số lượng tồn kho không đủ"
        RAISERROR('Số lượng tồn kho không đủ', 16, 1);
        ROLLBACK TRANSACTION; -- Hoàn tác giao dịch để hủy thao tác chèn dữ liệu
        
        -- Xóa hóa đơn tương ứng
        DELETE FROM HOADON
        WHERE MaHD IN (SELECT MaHD FROM inserted);

        -- Cập nhật bảng VE
        UPDATE VE
        SET MaHD = NULL
        WHERE MaHD IN (SELECT MaHD FROM inserted);

        RETURN; -- Thoát trigger
    END

    -- Cập nhật số lượng trong bảng HANGHOA
    UPDATE h
    SET SLTon = SLTon - i.SL
    FROM HANGHOA h
    INNER JOIN inserted i ON h.MaHH = i.MaHH;

	INSERT INTO CHITIETHDHH
    SELECT * FROM inserted;
END;
GO

-- trigger kiểm tra khi thêm hoặc cập nhật mã giảm giá
CREATE TRIGGER KiemTraThemGiamGia
ON GIAMGIA
AFTER INSERT, UPDATE
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM inserted where NgayHet < GETDATE())
    BEGIN
        RAISERROR('Ngày hết hạn không được ở quá khứ.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted where LTRIM(RTRIM(CONVERT(NVARCHAR(50), DieuKien))) = '')
    BEGIN
        RAISERROR('Điều kiện không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted where LTRIM(RTRIM(CONVERT(NVARCHAR(50), GiaTri))) = '')
    BEGIN
        RAISERROR('Giá trị không được trống.', 16, 1);
        ROLLBACK;
        RETURN;
    END

	IF EXISTS (SELECT 1 FROM inserted where GiaTri <= 0 OR GiaTri >= 100)
    BEGIN
        RAISERROR('Giá trị không được nhỏ hơn hoặc bằng 0 hoặc lớn hơn hoặc bằng 100.', 16, 1);
        ROLLBACK;
        RETURN;
    END
END;
GO

----trigger giảm số lượng khi mã gg được sử dụng
CREATE TRIGGER GiamSLGiamGia
ON HOADON
AFTER INSERT
AS
BEGIN
	DECLARE @MaGG CHAR(10);
	DECLARE @MaKH CHAR(10);
	SELECT @MaKH = MaKH FROM inserted;
	SELECT @MaGG = MaGG FROM inserted;
	IF @MaGG is not null
	BEGIN
		DECLARE @SL INT
		SET @SL = (SELECT SL FROM NHAN WHERE MaGG = @MaGG and MaKH = @MaKH) - 1;
		IF @SL = 0
		BEGIN
			DELETE FROM NHAN where MaGG = @MaGG and MaKH = @MaKH
		END;
		ELSE
			UPDATE NHAN SET SL = @SL WHERE MaGG = @MaGG and MaKH = @MaKH;
	END
END;
GO

-- Trigger them ma giam gia cho khach hang du dieu kien
CREATE TRIGGER NhanMaGiamGia
ON GIAMGIA
AFTER INSERT
AS
BEGIN
	DECLARE @MaGG CHAR(10), @DieuKien INT;
	DECLARE @MaKH CHAR(10), @DiemTL INT, @LoaiKH VARCHAR(10);
	SELECT @MaGG = MaGG, @DieuKien = DieuKien FROM inserted
	DECLARE @Cursor CURSOR;
	SET @Cursor = CURSOR FOR
		SELECT MaKH, DiemTL, LoaiKH
		FROM KHACHHANG;
	OPEN @Cursor;
	FETCH NEXT FROM @Cursor INTO @MaKH, @DiemTL, @LoaiKH;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @SL INT;
        IF @LoaiKH = 'Dong'
            SET @SL = 1;
        ELSE IF @LoaiKH = 'Bac'
            SET @SL = 2;
        ELSE IF @LoaiKH = 'Vang'
            SET @SL = 3;
        ELSE IF @LoaiKH = 'KimCuong'
            SET @SL = 4;
		IF @DiemTL >= @DieuKien AND @DieuKien <> 0
		BEGIN
			INSERT INTO NHAN VALUES(@MaKH, @MaGG, @SL)
		END
		FETCH NEXT FROM @Cursor INTO @MaKH, @DiemTL, @LoaiKH;
	END
	CLOSE @Cursor;
    DEALLOCATE @Cursor;
END;
GO

