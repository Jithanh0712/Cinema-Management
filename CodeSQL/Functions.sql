------------------FUNCTIONS--------------------------------------------
--Danh sách phim theo năm sản xuất
CREATE FUNCTION dbo.LayDSPhimTheoNamSX(@NamSX INT)
RETURNS TABLE
AS
RETURN (
    SELECT TenPhim, DaoDien
    FROM PHIM
    WHERE NamSX = @NamSX
);
GO
-- Doanh thu theo tháng
CREATE FUNCTION dbo.TongDoanhThuTheoThang(@Thang INT, @Nam INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @TongDoanhThu FLOAT;
    SELECT @TongDoanhThu = SUM(TongTien)
    FROM HOADON
    WHERE MONTH(ThoiGian) = @Thang AND YEAR(ThoiGian) = @Nam;
    RETURN @TongDoanhThu;
END;
GO
-- Danh sách phim theo the loai
CREATE FUNCTION dbo.LayDSPhimTheoTheLoai(@TheLoai NVARCHAR(20))
RETURNS TABLE
AS
RETURN (
    SELECT * FROM PHIM
    WHERE EXISTS (
        SELECT 1 FROM THELOAIPHIM
        WHERE MaPhim = PHIM.MaPhim AND TheLoai = @TheLoai
    )
);
GO
-- Danh sách hàng hóa giảm giá
CREATE FUNCTION dbo.LayDSHangHoaGiamGia()
RETURNS TABLE
AS
RETURN (
    SELECT HH.MaHH, HH.TenHH, HH.DonGia, HH.SLTon, GG.GiaTri, GG.NgayHet
    FROM HANGHOA HH
    JOIN GIAMGIA GG ON HH.MaHH = GG.MaHH
    WHERE GG.GiaTri > 0 AND GG.NgayHet >= GETDATE()
);
GO
-- Danh sách vé theo lịch chiếu
CREATE FUNCTION dbo.LayDSVeTrongLichChieu
(
    @MaLC CHAR(30)
)
RETURNS TABLE
AS
RETURN
(
    SELECT V.MaVe, V.LoaiVe, V.Gia, V.MaLC, V.TrangThai
    FROM VE V
    WHERE V.MaLC = @MaLC
);
GO

-- Lấy ngày khởi chiếu của phim --
CREATE FUNCTION dbo.LayNgayKhoiChieu(@MaPhim CHAR(10))
RETURNS @NgayKhoiChieuTable TABLE 
(
    MaPhim CHAR(10),
    NgayKhoiChieu DATE
)
AS
BEGIN
    INSERT INTO @NgayKhoiChieuTable (MaPhim, NgayKhoiChieu)
    SELECT @MaPhim, CONVERT(DATE, MIN(ThoiGianChieu))
    FROM LICHCHIEU
    WHERE MaPhim = @MaPhim;

    RETURN;
END;
GO

-- Lay Lich Chieu cua mot phim ---
CREATE FUNCTION dbo.LayLichChieuPhim(@MaPhim CHAR(10))
RETURNS TABLE 
AS
RETURN (
    SELECT MaLC as MaLC
    FROM LICHCHIEU
    WHERE MaPhim = @MaPhim
);
GO

-- Tìm kiếm phim theo tên phim
CREATE FUNCTION dbo.TimKiemTenPhim 
(
    @TenPhim NVARCHAR(30)
)
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM PHIM
    WHERE TenPhim LIKE '%' + @TenPhim + '%'
);
GO

--Tìm kiếm phim theo thể loại----
CREATE Function dbo.TimPhimTheoTheLoai(@TheLoai NVARCHAR(20))
RETURNS TABLE
AS RETURN(
    SELECT P.*
    FROM PHIM P
    INNER JOIN THELOAIPHIM TLP ON P.MaPhim = TLP.MaPhim
    WHERE TLP.TheLoai = @TheLoai
)
GO


-- Nhân viên Đăng nhập
CREATE FUNCTION dbo.DangNhap (
    @TaiKhoan VARCHAR(255),
    @MatKhau VARCHAR(255)
)
RETURNS TABLE
AS
RETURN (
    SELECT 
        CASE 
            WHEN EXISTS (
                SELECT 1
                FROM TAIKHOAN
                WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
            ) THEN 1
            ELSE 0
        END AS KetQua,
        MaTaiKhoan,
        PhanQuyen
    FROM TAIKHOAN
    WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
);
GO

CREATE FUNCTION dbo.LayMaNV (
    @MaTaiKhoan CHAR(10)
)
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @KetQua CHAR(10);
    BEGIN
        SELECT @KetQua = MaNV
            FROM NHANVIEN
            WHERE MaTaiKhoan = @MaTaiKhoan
    END
    RETURN @KetQua;
END
GO

CREATE FUNCTION dbo.LayMaKH (
    @MaTaiKhoan CHAR(10)
)
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @KetQua CHAR(10);
    BEGIN
        SELECT @KetQua = MaKH
            FROM KHACHHANG
            WHERE MaTaiKhoan = @MaTaiKhoan
    END
    RETURN @KetQua;
END
GO

-- Lấy ChiTietPhim
CREATE FUNCTION dbo.GetChiTietPhim
(
    @MaPhim CHAR(10)
)
RETURNS TABLE
AS
RETURN(
    SELECT TenPhim, DaoDien, NamSX, DoDai, HinhThuc, DinhDang, DanhGia, XepLoai
    FROM PHIM
    WHERE MaPhim = @MaPhim
    )
GO

-- Lấy Các Thể Loại của tất cả Phim
CREATE FUNCTION dbo.LayTatCaTheLoai()
RETURNS TABLE
AS
RETURN (
    SELECT DISTINCT TheLoai
    FROM THELOAIPHIM
);
GO

-- Lấy Thể Loại của 1 bộ phim
CREATE FUNCTION dbo.LayTheLoaiPhim (@MaPhim CHAR(10))
RETURNS TABLE
AS
RETURN (
    SELECT TheLoai
    FROM THELOAIPHIM
    WHERE MaPhim = @MaPhim
);
GO

-- Tạo mã tài khoản tự động
CREATE FUNCTION dbo.TaoMaTaiKhoanTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaTaiKhoan CHAR(10)

    SELECT @MaTaiKhoan = 'TK' + RIGHT('00000000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaTaiKhoan, 3, 8) AS INT)), 0) + 1 AS VARCHAR(8)), 8)
    FROM TAIKHOAN

    IF @MaTaiKhoan IS NULL
        SET @MaTaiKhoan = 'TK00000001'

    RETURN @MaTaiKhoan
END;
GO

-- Lay chitiethdhh
CREATE FUNCTION dbo.GetChiTietHDHH
(
    @MaHD CHAR(10)
)
RETURNS TABLE
AS
RETURN(
    SELECT MaHH, SL, TongTien
    FROM CHITIETHDHH
    WHERE MaHD = @MaHD
    )
GO

--Tinh tong chi tiet hoa don hh
CREATE FUNCTION dbo.TongTienChiTietHDHH(@MaHD CHAR(10))
RETURNS FLOAT
AS
BEGIN
    DECLARE @Tong FLOAT;

    SELECT @Tong = SUM(TongTien)
    FROM CHITIETHDHH
    WHERE MaHD = @MaHD;
    RETURN @Tong;
END;
GO


---Func lấy ra hình ảnh
CREATE FUNCTION dbo.GetImageByMaPhim (@MaPhim CHAR(10))
RETURNS VARBINARY(MAX)
AS
BEGIN
    DECLARE @HinhAnh VARBINARY(MAX)

    SELECT @HinhAnh = HinhAnh
    FROM PHIM
    WHERE MaPhim = @MaPhim

    RETURN @HinhAnh
END;
GO


-- Tạo mã phim tự động
CREATE FUNCTION dbo.TaoMaPhimTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaPhim CHAR(10) = 'P000000001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MaPhim FROM PHIM WHERE MaPhim = @MaPhim)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPhim = 'P' + REPLICATE('0', 9 - LEN(CAST(@idx AS CHAR))) + CAST(@idx AS CHAR)
    END

    RETURN @MaPhim
END
GO

CREATE FUNCTION dbo.GetDanhSachHangHoaVaVe
(
    @MaHD CHAR(10)
)
RETURNS TABLE
AS
RETURN (
    SELECT 'HangHoa' AS Loai, MaHH AS Ma, SL, TongTien
    FROM CHITIETHDHH
    WHERE MaHD = @MaHD

    UNION ALL

    SELECT 'Ve' AS Loai, MaVe AS Ma, 1 AS SL, Gia AS TongTien
    FROM VE
    WHERE MaHD = @MaHD
);
GO

-- Lấy danh sách diễn viên của Phim
CREATE FUNCTION dbo.LayDSDienVien(@MaPhim CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT TenDV 
    FROM DienVien
    WHERE MaDV IN (
        SELECT MaDV
        FROM THAMGIA
        WHERE MaPhim = @MaPhim
    )
)
GO

-- Lấy thông tin hàng hóa: tên, đơn giá
CREATE FUNCTION dbo.ThongTinHangHoa
(
    @MaHH CHAR(10)
)
RETURNS TABLE
AS
RETURN (
    SELECT TenHH, DonGia
    FROM HANGHOA
    WHERE MaHH = @MaHH
);
GO

CREATE FUNCTION dbo.LayThongTinKhachHang(@MaKH CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT *
    FROM KHACHHANG
    WHERE MaKH = @MaKH
)
GO

CREATE FUNCTION dbo.LayThongTinNhanVien(@MaNV CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT *
    FROM NHANVIEN
    WHERE MaNV = @MaNV
)
GO


--function lay danh sach magg cua khach hang
CREATE FUNCTION LayMaGGKhachHang(@MaKH CHAR(10))
RETURNS TABLE
AS
RETURN (
    SELECT MaGG
    FROM NHAN
    WHERE MaKH = @MaKH
    );
GO

-- lay mahh theo magg
CREATE FUNCTION dbo.LayMaHangHoaVaGiaTri(@MaGG CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT MaHH,LoaiGG, GiaTri
    FROM GIAMGIA
    WHERE MaGG = @MaGG
);
GO

-- lay gia tri ma gg
CREATE FUNCTION dbo.LayGiaTriGiamGia(@MaGG CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT GiaTri
    FROM GIAMGIA
    WHERE MaGG = @MaGG
);
GO

-- Lấy Các mã phòng
CREATE FUNCTION dbo.LayTatCaMaPhong()
RETURNS TABLE
AS
RETURN (
    SELECT MaPhong
    FROM PHONGCHIEU
);
GO


-- Lấy Các mã phim
CREATE FUNCTION dbo.LayTatCaMaPhim()
RETURNS TABLE
AS
RETURN (
    SELECT MaPhim
    FROM PHIM
);
GO


-- Lấy Các mã nhà CC
CREATE FUNCTION dbo.LayTatCaMaNCC()
RETURNS TABLE
AS
RETURN (
    SELECT MaNCC
    FROM NHACUNGCAP
);
GO


-- Tạo mã diễn viên tự động
CREATE FUNCTION dbo.TaoMaDVTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaDV CHAR(10) = 'DV00000001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MaDV FROM DIENVIEN WHERE MaDV = @MaDV)
    BEGIN
        SET @idx = @idx + 1
        SET @MaDV = 'DV' + REPLICATE('0', 8 - LEN(CAST(@idx AS CHAR))) + CAST(@idx AS CHAR)
    END

    RETURN @MaDV
END;
GO

-- Lấy mã diễn viên theo tên diễn viên
CREATE FUNCTION dbo.LayMaDV
(  
	@TenDV NVARCHAR(30)
)
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @Result CHAR(10); 
	BEGIN
    SELECT @Result = MaDV
		FROM DIENVIEN
		WHERE TenDV LIKE '%' + @TenDV + '%'
	END
    RETURN ISNULL(@Result, '') 
END;
GO

CREATE FUNCTION dbo.LayLichSuTTNV(@MaNV CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT MaHD, ThoiGian, TongTien
    FROM HOADON
    WHERE MaNV = @MaNV
)
GO

CREATE FUNCTION dbo.LayLichSuTTKH(@MaKH CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT MaHD, ThoiGian, TongTien
    FROM HOADON
    WHERE MaKH = @MaKH
)
GO

CREATE FUNCTION dbo.LayChiTietHD(@MaHD CHAR(10))
RETURNS TABLE
AS RETURN(
    SELECT ThoiGian, TongTien, PhuongThucTT
    FROM HOADON
    WHERE MaHD = @MaHD
)
GO

CREATE FUNCTION dbo.LayChiTietHDHH(@MaHD CHAR(10))
RETURNS TABLE
AS RETURN(
    SELECT TenHH, SL, TongTien
    FROM (CHITIETHDHH JOIN HANGHOA ON CHITIETHDHH.MaHH = HANGHOA.MaHH)
    WHERE MaHD = @MaHD
)
GO

CREATE FUNCTION dbo.LayChiTietHDVe(@MaHD CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT LoaiVe, COUNT(LoaiVe) AS SL, Gia 
    FROM VE 
    WHERE MaHD = @MaHD
    GROUP BY LoaiVe, Gia
)
GO

CREATE FUNCTION dbo.LayDiemTL(@MaKH CHAR(10))
RETURNS TABLE
AS RETURN (
    SELECT DiemTL
    FROM KHACHHANG
    WHERE MaKH = @MaKH
)
GO

CREATE FUNCTION dbo.LayPhongChieu()
RETURNS TABLE
AS RETURN (
    SELECT *
    FROM PHONGCHIEU
)
GO

CREATE FUNCTION dbo.TaoMaPhongChieuTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaPhong CHAR(10) = 'PC00000001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MaPhong FROM PHONGCHIEU WHERE MaPhong = @MaPhong)
    BEGIN
        SET @idx = @idx + 1
        SET @MaPhong = 'PC' + REPLICATE('0', 8 - LEN(CAST(@idx AS CHAR))) + CAST(@idx AS CHAR)
    END

    RETURN @MaPhong
END
GO

CREATE FUNCTION dbo.TaoMaHoaDonTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaHD CHAR(10) = 'HD00000001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MaHD FROM HOADON WHERE MaHD = @MaHD)
    BEGIN
        SET @idx = @idx + 1
        SET @MaHD = 'HD' + REPLICATE('0', 8 - LEN(CAST(@idx AS CHAR))) + CAST(@idx AS CHAR)
    END

    RETURN @MaHD
END
GO

CREATE FUNCTION dbo.ThongTinVe
(
    @MaVe CHAR(36)
)
RETURNS TABLE
AS
RETURN (
    SELECT LoaiVe, Gia
    FROM VE
    WHERE Mave = @MaVe
);
GO

-- Lấy Các mã hàng hóa
CREATE FUNCTION dbo.LayTatCaMaHangHoa()
RETURNS TABLE
AS
RETURN (
    SELECT MaHH
    FROM HANGHOA
);
GO



--function lay danh sach magg cua khach hang
CREATE FUNCTION LayMaGGChoTatCa()
RETURNS TABLE
AS
RETURN (
    SELECT MaGG
    FROM GIAMGIA
    WHERE DieuKien = 0
    );
GO

CREATE FUNCTION dbo.TaoMaGiamGiaTuDong()
RETURNS CHAR(10)
AS
BEGIN
    DECLARE @MaGG CHAR(10) = 'GG00000001'
    DECLARE @idx INT = 1

    WHILE EXISTS (SELECT MaGG FROM GIAMGIA WHERE MaGG = @MaGG)
    BEGIN
        SET @idx = @idx + 1
        SET @MaGG = 'GG' + REPLICATE('0', 8 - LEN(CAST(@idx AS CHAR))) + CAST(@idx AS CHAR)
    END

    RETURN @MaGG
END
GO
