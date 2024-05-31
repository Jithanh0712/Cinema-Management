using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_HangHoa
    {
        private string mahh;
        private string tenhh;
        private float dongia;
        private int slton;
        private string nhacc;
        public string MaHH
        {
            get { return mahh; }
            set { mahh = value; }
        }
        public string TenHH
        {
            get { return tenhh; }
            set { tenhh = value; }
        }
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public int SLTon
        {
            get { return slton; }
            set { slton = value; }
        }
        public string NhaCC
        {
            get { return nhacc; }
            set { nhacc = value; }
        }
        public DTO_HangHoa()
        {

        }
        public DTO_HangHoa(string mahh, string tenhh, float dongia, int slton, string nhacc)
        {
            this.MaHH = mahh;
            this.TenHH = tenhh;
            this.DonGia = dongia;
            this.SLTon = slton;
            this.NhaCC = nhacc;
        }

        public DTO_HangHoa(string tenhh, float dongia, int slton, string nhacc)
        {
            this.TenHH = tenhh;
            this.DonGia = dongia;
            this.SLTon = slton;
            this.NhaCC = nhacc;
        }
    }
}
