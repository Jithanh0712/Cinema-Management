using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_DienVien
    {
        private string madv;
        private string tendv;
        public string MaDV
        { get { return madv; } set {  madv = value; } }
        public string TenDV
        { get { return tendv; } set { tendv = value; } }
        public DTO_DienVien() { }
        public DTO_DienVien(string madv, string tendv)
        {
            this.madv = madv;
            this.tendv = tendv;
        }
    }
}
