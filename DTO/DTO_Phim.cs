using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.DTO
{
    public class DTO_Phim
    {
        private string maphim;
        private string tenphim;
        private string daodien;
        private string nhasx;
        private int namsx;
        private string hinhthuc;
        private string dinhdang;
        private float danhgia;
        private string xeploai;
        private int dodai;
        private string mota;
        private byte[] hinhanh;
        public string MaPhim { get {  return maphim; } set {  maphim = value; } }
        public string TenPhim { get { return tenphim; } set {  tenphim = value; } }
        public string DaoDien { get {  return daodien; } set {  daodien = value; } }
        public string NhaSX { get { return nhasx; } set { nhasx = value; } }
        public int NamSX { get { return namsx; } set {  namsx = value; } }
        public string HinhThuc { get {  return hinhthuc; } set {  hinhthuc = value; } }
        public string DinhDang { get { return dinhdang; } set { dinhdang = value; } }
        public float DanhGia { get { return danhgia; } set { danhgia = value; } }
        public string XepLoai { get { return xeploai; } set { xeploai = value; } }
        public int DoDai { get { return dodai; } set { dodai = value; } }
        public string MoTa { get { return mota; } set { mota = value; } }
        public byte[] HinhAnh { get { return hinhanh; } set { hinhanh = value; } }
        public DTO_Phim() { }
        public DTO_Phim(string maphim, string tenphim, string daodien, string nhasx, int namsx, string hinhthuc, string dinhdang, float danhgia, string xeploai, int dodai, string mota, byte[] hinhanh) 
        {
            this.MaPhim = maphim;
            this.TenPhim = tenphim;
            this.DaoDien = daodien;
            this.NhaSX = nhasx;
            this.NamSX = namsx;
            this.HinhThuc = hinhthuc;
            this.DinhDang = dinhdang;
            this.DanhGia = danhgia;
            this.XepLoai = xeploai;
            this.DoDai = dodai;
            this.MoTa = mota;
            this.HinhAnh = hinhanh;
        }
        public DTO_Phim(string maphim, string tenphim, string daodien, string nhasx, int namsx, string hinhthuc, string dinhdang, string xeploai, int dodai, string mota, byte[] hinhanh)
        {
            this.MaPhim = maphim;
            this.TenPhim = tenphim;
            this.DaoDien = daodien;
            this.NhaSX = nhasx;
            this.NamSX = namsx;
            this.HinhThuc = hinhthuc;
            this.DinhDang = dinhdang;
            this.XepLoai = xeploai;
            this.DoDai = dodai;
            this.MoTa = mota;
            this.HinhAnh = hinhanh;
        }
    }
}
