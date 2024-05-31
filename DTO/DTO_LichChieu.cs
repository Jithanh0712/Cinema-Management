using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_LichChieu
    {
        private string malc;
        private string maphong;
        private string maphim;
        private DateTime thoigianchieu;
        private DateTime thoigianhet;
        public string MaLC
        {
            get { return malc; }
            set { malc = value; }
        }
        public string MaPhong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        public string MaPhim
        {
            get { return maphim; }
            set { maphim = value; }
        }
        public DateTime ThoiGianChieu
        {
            get { return thoigianchieu; }
            set { thoigianchieu = value; }
        }
        public DateTime ThoiGianHet
        {
            get { return thoigianhet; }
            set { thoigianhet = value; }
        }
        public DTO_LichChieu()
        {

        }
        public DTO_LichChieu(string malc, DateTime thoigianchieu, DateTime thoigianhet, string maphong, string maphim)
        {
            this.MaLC = malc;
            this.MaPhong = maphong;
            this.MaPhim = maphim;
            this.ThoiGianChieu = thoigianchieu;
            this.ThoiGianHet = thoigianhet;
        }
        public DTO_LichChieu(DateTime thoigianchieu, DateTime thoigianhet, string maphong, string maphim)
        {
            this.MaPhong = maphong;
            this.MaPhim = maphim;
            this.ThoiGianChieu = thoigianchieu;
            this.ThoiGianHet = thoigianhet;
        }
    }
}
