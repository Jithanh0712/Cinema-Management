using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_TheLoaiPhim
    {
        private string maphim;
        private string theloai;
        public string MaPhim
        {
            get { return maphim; }
            set { maphim = value; }
        }
        public string TheLoai
        {
            get { return theloai; }
            set { theloai = value; }    
        }
        public DTO_TheLoaiPhim() { }
        public DTO_TheLoaiPhim(string maphim, string theloai)
        {
            this.MaPhim = maphim;
            this.TheLoai = theloai;
        }    
    }
}
