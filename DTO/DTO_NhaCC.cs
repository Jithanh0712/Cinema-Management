using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_NhaCC
    {
        private string mancc;
        private string tenncc;
        private string diachi;
        private string sdt;
        public string MaNCC
        {
            get { return mancc; }
            set { mancc = value; }
        }
        public string TenNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public DTO_NhaCC()
        {

        }
        public DTO_NhaCC(string mancc, string tenncc, string diachi, string sdt)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.DiaChi = diachi;
            this.SDT = sdt;
        }

        public DTO_NhaCC(string tenncc, string diachi, string sdt)
        {
            this.TenNCC = tenncc;
            this.DiaChi = diachi;
            this.SDT = sdt;
        }
    }
}
