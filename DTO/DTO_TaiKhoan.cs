using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_TaiKhoan
    {
        private string mataikhoan;
        private string taikhoan;
        private string matkhau;
        private string phanquyen;
        public string MaTaiKhoan { get => mataikhoan; set => mataikhoan = value; }
        public string TaiKhoan { get => taikhoan; set => taikhoan = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string PhanQuyen { get => phanquyen; set => phanquyen = value; }
        public DTO_TaiKhoan() { }
        public DTO_TaiKhoan(string mataikhoan, string taikhoan, string matkhau, string phanquyen)
        {
            this.MaTaiKhoan = mataikhoan;
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
            this.PhanQuyen = phanquyen;
        }
        
    }
}
