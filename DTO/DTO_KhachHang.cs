using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_KhachHang
    {
        private string makh;
        private string hoten;
        private string diachi;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sdt;
        private int diemtl;
        private string loaikh;
        private string mataikhoan;

        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public int DiemTL
        {
            get { return diemtl; }
            set { diemtl = value; }
        }

        public string LoaiKH
        {
            get { return loaikh; }
            set { loaikh = value; }
        }

        public string MaTaiKhoan
        {
            get { return makh; }
            set { makh = value; }
        }

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string makh, string hoten, string diachi, string gioitinh, DateTime ngaysinh, string sdt, int diemtl, string loaikh, string mataikhoan)
        {
            this.MaKH = makh;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
            this.DiemTL = diemtl;
            this.LoaiKH = loaikh;
            this.MaTaiKhoan = mataikhoan;
        }

        public DTO_KhachHang(string makh, string hoten, string diachi, string gioitinh, DateTime ngaysinh, string sdt)
        {
            this.MaKH = makh;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
        }
        public DTO_KhachHang(string hoten, string diachi, string gioitinh, DateTime ngaysinh, string sdt, string mataikhoan)
        {
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
            this.MaTaiKhoan = mataikhoan;
        }
    }
}
