-------------------- VIEWS -----------------------------------------------------
--xem nhân viên

CREATE VIEW dbo.XemNhanVien
AS
SELECT NV.MaNV, NV.HoTen, NV.DiaChi, NV.NgaySinh, NV.SDT, NV.GioiTinh, NV.ChucVu, TK.TaiKhoan, TK.MatKhau, NV.Luong, TK.PhanQuyen, TK.MaTaiKhoan 
FROM NHANVIEN NV
JOIN TAIKHOAN TK ON NV.MaTaiKhoan = TK.MaTaiKhoan
GO

--xem lịch chiếu
CREATE VIEW dbo.XemLichChieu
AS
SELECT * FROM LICHCHIEU
GO

--xem phim
CREATE VIEW dbo.XemPhim
AS
SELECT MaPhim, TenPhim, DaoDien, NhaSX, NamSX, HinhThuc, DinhDang, DanhGia, XepLoai, DoDai, MoTa, HinhAnh
FROM     dbo.PHIM
GO

--xem nhà cc
CREATE VIEW dbo.XemNhaCC
AS
SELECT * FROM NHACUNGCAP
GO

--xem hàng hóa
CREATE VIEW dbo.XemHangHoa
AS
SELECT * FROM HANGHOA
GO


--xem khách hàng
CREATE VIEW dbo.XemKhachHang
AS
SELECT KH.MaKH, KH.HoTen, KH.DiaChi, KH.GioiTinh, KH.NgaySinh, KH.SDT, KH.DiemTL, KH.LoaiKH, TK.MaTaiKhoan, TK.TaiKhoan, TK.MatKhau, TK.PhanQuyen 
FROM KHACHHANG KH
JOIN TAIKHOAN TK ON KH.MaTaiKhoan = TK.MaTaiKhoan
GO

---Xem giảm giá
CREATE VIEW dbo.XemGiamGia
AS
SELECT *
FROM GIAMGIA
GO

