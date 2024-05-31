using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_ThamGia
    {
        private string maphim;
        private string madv;
        private string vaitro;
        public string MaPhim { get { return maphim; } set {  maphim = value; } }
        public string MaDV { get { return madv; } set {  madv = value; } }
        public string VaiTro { get { return vaitro; } set {  vaitro = value; } }
        public DTO_ThamGia() { }
        public DTO_ThamGia(string madv, string maphim, string vaitro)
        {
            this.madv = madv;
            this.maphim = maphim;
            this.vaitro = vaitro;
        }
    }
}
