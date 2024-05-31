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
    public class DTO_NhanVien
    {
        private string manv;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private string sdt;
        private string gioitinh;
        private string chucvu;
        private string mataikhoan;
        private float luong;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
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
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public string MaTaiKhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string manv, string hoten, string diachi, DateTime ngaysinh, string sdt, string gioitinh, string chucvu, float luong)
        {
            this.MaNV = manv;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
            this.GioiTinh = gioitinh;
            this.ChucVu = chucvu;
            this.Luong = luong;
        }

        public DTO_NhanVien(string hoten, string diachi, DateTime ngaysinh, string sdt, string gioitinh, string chucvu, string mataikhoan, float luong)
        {
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
            this.GioiTinh = gioitinh;
            this.ChucVu = chucvu;
            this.MaTaiKhoan = mataikhoan;
            this.Luong = luong;
        }
    }
}
