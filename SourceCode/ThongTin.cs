using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class ThongTin
    {
        private string manguoidung;
        private string hoten;
        private string diachi;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sdt;
        private int diemtl;
        private string loaikh;
        public ThongTin()
        {

        }
        public ThongTin(string maNguoiDung, string hoTen, string diaChi, string gioiTinh, DateTime ngaySinh, string sdt, int diemTL, string loaiKH)
        {
            manguoidung = maNguoiDung;
            hoten = hoTen;
            diachi = diaChi;
            gioitinh = gioiTinh;
            ngaysinh = ngaySinh;
            this.sdt = sdt;
            diemtl = diemTL;
            loaikh = loaiKH;
        }

        public string MaNguoiDung
        {
            get { return manguoidung; }
            set { manguoidung = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
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
    }
}
