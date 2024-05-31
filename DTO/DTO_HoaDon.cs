using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_HoaDon
    {
        private string mahd;
        private DateTime thoigian;
        private float tongtien;
        private string phuongthuctt;
        private string makh;
        private string manv;
        private string magg;
        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public DateTime ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public string PhuongThucTT
        {
            get { return phuongthuctt; }
            set { phuongthuctt = value; }
        }
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public string MaGG
        {
            get { return magg; }
            set { magg = value; }
        }
        public DTO_HoaDon()
        {

        }
    }
}