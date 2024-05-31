using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class TaiKhoan
    {
        private string maTaiKhoan;
        private string phanQuyen;
        private string taiKhoan;
        private string matKhau;
        private string id;
        public TaiKhoan() { }
        public TaiKhoan(string maTaiKhoan, string phanQuyen, string id)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.phanQuyen = phanQuyen;
            this.id = id;
        }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string Id { get => id; set => id = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TaiKhoanLogin { get => taiKhoan; set => taiKhoan = value; }
    }
}
