
USE RAPCHIEUPHIM;
GO
-- Tạo role
CREATE ROLE dbmsKhachHangRole;
GO
CREATE ROLE dbmsNhanVienRole;
GO
--- Gán quyền cho role
--Role: KhachHang
--- Gán quyền cho role
GRANT SELECT, REFERENCES ON dbo.XemLichChieu TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.XemPhim TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.TimKiemTenPhim TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.TimPhimTheoTheLoai TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.XemHangHoa TO dbmsKhachHangRole;
GRANT UPDATE, SELECT ON dbo.KHACHHANG TO dbmsKhachHangRole;
GRANT UPDATE, SELECT ON dbo.VE TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.HOADON TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES ON dbo.GIAMGIA TO dbmsKhachHangRole;
GRANT SELECT, REFERENCES, INSERT ON dbo.NHAN TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.CapNhatMaHDVaTrangThai TO dbmsKhachHangRole;

--new
GRANT UPDATE ON dbo.NHAN TO dbmsKhachHangRole;

-- Quyền trên func, proc
GRANT SELECT ON dbo.LayDSVeTrongLichChieu TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.ThemHoaDon TO dbmsKhachHangRole;
GRANT SELECT ON dbo.ThongTinVe TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayLichSuTTKH TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayChiTietHD TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayChiTietHDHH TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayChiTietHDVE TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayDiemTL TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayThongTinKhachHang TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.CapNhatThongTinKhachHang TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.GetImageByMaPhim TO dbmsKhachHangRole;
GRANT SELECT ON dbo.DangNhap TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.LayMaKH TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.LayMaNV TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.ThemTaiKhoan TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.ThemKhachHang TO dbmsKhachHangRole;
GRANT SELECT ON dbo.TimKiemTenPhim TO dbmsKhachHangRole;
GRANT SELECT ON dbo.TimPhimTheoTheLoai TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayNgayKhoiChieu TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayTatCaTheLoai TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayDSDienVien TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayLichChieuPhim TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.TaoMaTaiKhoanTuDong TO dbmsKhachHangRole;
GRANT SELECT ON dbo.ThongTinHangHoa TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.ThemCHITIETHDHH TO dbmsKhachHangRole;
GRANT EXECUTE ON dbo.TaoMaHoaDonTuDong TO dbmsKhachHangRole;

----new grant
GRANT SELECT ON dbo.LayMaGGChoTatCa TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayMaGGKhachHang TO dbmsKhachHangRole;
GRANT SELECT ON dbo.LayMaHangHoaVaGiaTri TO dbmsKhachHangRole;


--Role: NhanVien
-- Quyền trên bảng, view
GRANT SELECT, REFERENCES ON dbo.XemHangHoa TO dbmsNhanVienRole;
GRANT SELECT ON dbo.TimPhimTheoTheLoai TO dbmsNhanVienRole;
GRANT UPDATE, SELECT ON dbo.KHACHHANG TO dbmsNhanVienRole;
GRANT SELECT, REFERENCES ON dbo.HOADON TO dbmsNhanVienRole;
GRANT SELECT, REFERENCES ON dbo.GIAMGIA TO dbmsNhanVienRole;
GRANT SELECT, REFERENCES, INSERT ON dbo.NHAN TO dbmsNhanVienRole;
GRANT UPDATE, SELECT ON dbo.VE TO dbmsNhanVienRole;

--new
GRANT UPDATE ON dbo.NHAN TO dbmsNhanVienRole;

-- Quyền trên func, proc
GRANT SELECT ON dbo.LayLichSuTTNV TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayChiTietHD TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayChiTietHDHH TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayChiTietHDVE TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayThongTinNhanVien TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayMaGGChoTatCa TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayDSVeTrongLichChieu TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayNgayKhoiChieu TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayDSDienVien TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayLichChieuPhim TO dbmsNhanVienRole;


GRANT EXECUTE ON dbo.CapNhatThongTinNhanVien TO dbmsNhanVienRole;

GRANT SELECT ON dbo.LayTatCaTheLoai TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayMaGGKhachHang TO dbmsNhanVienRole;
GRANT SELECT ON dbo.LayMaHangHoaVaGiaTri TO dbmsNhanVienRole;
GRANT SELECT ON dbo.ThongTinVe TO dbmsNhanVienRole;
GRANT SELECT ON dbo.ThongTinHangHoa TO dbmsNhanVienRole;


GRANT EXECUTE ON dbo.CapNhatMaHDVaTrangThai TO dbmsNhanVienRole;
GRANT EXECUTE ON dbo.ThemCHITIETHDHH TO dbmsNhanVienRole;
GRANT EXECUTE ON dbo.ThemHoaDon TO dbmsNhanVienRole;
GRANT EXECUTE ON dbo.TaoMaHoaDonTuDong TO dbmsNhanVienRole;

GRANT SELECT, REFERENCES ON dbo.XemPhim TO dbmsNhanVienRole;