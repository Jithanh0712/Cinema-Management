using RapChieuPhim.DTO;
using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Forms
{
    public partial class FormKhachHang : Form
    {
        QuanLyPhim phim = new QuanLyPhim();
        KhachHang kh = new KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private Image ByteArrayToImage(byte[] HinhAnh)
        {
            if (HinhAnh == null)
            {
                return null;
            }
            MemoryStream stream = new MemoryStream(HinhAnh);
            return Image.FromStream(stream);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiemPhim formTimKiemPhim = new FormTimKiemPhim();
            this.Visible = false;
            formTimKiemPhim.ShowDialog();
            this.Visible = true;
        }

        private void btnXemLC_Click(object sender, EventArgs e)
        {
            FormLichChieu formLC = new FormLichChieu();
            this.Visible = false;
            formLC.ShowDialog();
            this.Visible = true;
        }

        private void lblThongTinCN_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan formTTKH = new FormThongTinCaNhan();
            this.Visible = false;
            formTTKH.ShowDialog();
            this.Visible = true;
        }

        private void lblLSTT_Click(object sender, EventArgs e)
        {
            FormLichSuTT formLichSuTT = new FormLichSuTT();
            this.Visible = false;
            formLichSuTT.ShowDialog();
            this.Visible = true;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtphim = new DataTable();
            dtphim = phim.LayDanhSachPhim();
            DateTime dateNow = DateTime.Now;
            List<string> listmhd = new List<string>();
            List<string> listtenp = new List<string>();
            int count = 0;
            foreach (DataRow dr in dtphim.Rows)
            {

                if (phim.LayNgayKhoiChieu(dr["MaPhim"].ToString()) != null)
                {
                    listmhd.Add(Convert.ToString(dr["MaPhim"]));
                    listtenp.Add(Convert.ToString(dr["TenPhim"]));
                    count++;
                }
                if (count == 3) break;
            }
            if (listmhd.Count > 0 && listtenp.Count > 0)
            {
                int numberOfMovies = Math.Min(listmhd.Count, listtenp.Count);

                if (numberOfMovies >= 1)
                {
                    string maPhim_1 = listmhd[0];
                    string tenPhim_1 = listtenp[0];
                    byte[] imageData1 = phim.GetImageByMaPhim(maPhim_1);
                    DateTime ngayKhoiChieu_1 = phim.LayNgayKhoiChieu(maPhim_1);

                    if (imageData1 != null)
                    {
                        picPhim_1.Image = ByteArrayToImage(imageData1);
                        picPhim_1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        picPhim_1.Image = null;
                    }

                    lblNgayKhoiChieu_1.Text = ngayKhoiChieu_1.ToShortDateString();
                    lblTenPhim_1.Text = tenPhim_1;
                    panelHinhAnhPhim_1.Tag = maPhim_1;
                }

                if (numberOfMovies >= 2)
                {
                    string maPhim_2 = listmhd[1];
                    string tenPhim_2 = listtenp[1];
                    byte[] imageData2 = phim.GetImageByMaPhim(maPhim_2);
                    DateTime ngayKhoiChieu_2 = phim.LayNgayKhoiChieu(maPhim_2);

                    if (imageData2 != null)
                    {
                        picPhim_2.Image = ByteArrayToImage(imageData2);
                        picPhim_2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        picPhim_2.Image = null;
                    }

                    lblNgayKhoiChieu_2.Text = ngayKhoiChieu_2.ToShortDateString();
                    lblTenPhim_2.Text = tenPhim_2;

                    panelHinhAnhPhim_2.Tag = maPhim_2;
                }

                if (numberOfMovies >= 3)
                {
                    string maPhim_3 = listmhd[2];
                    string tenPhim_3 = listtenp[2];
                    byte[] imageData3 = phim.GetImageByMaPhim(maPhim_3);
                    DateTime ngayKhoiChieu_3 = phim.LayNgayKhoiChieu(maPhim_3);

                    if (imageData3 != null)
                    {
                        picPhim_3.Image = ByteArrayToImage(imageData3);
                        picPhim_3.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        picPhim_3.Image = null;
                    }

                    lblNgayKhoiChieu_3.Text = ngayKhoiChieu_3.ToShortDateString();
                    lbl_TenPhim3.Text = tenPhim_3;

                    panelHinhAnhPhim_3.Tag = maPhim_3;
                }
            }
        }

        private void panelHinhAnhPhim_1_Click(object sender, EventArgs e)
        {
            string[] maPhim = new string[1];
            maPhim[0] = panelHinhAnhPhim_1.Tag.ToString();
            FormLichChieu formLichChieu = new FormLichChieu(maPhim);
            this.Visible = false;
            formLichChieu.ShowDialog();
            this.Visible = true;
        }

        private void panelHinhAnhPhim_2_Click(object sender, EventArgs e)
        {
            string[] maPhim = new string[1];
            maPhim[0] = panelHinhAnhPhim_2.Tag.ToString();
            FormLichChieu formLichChieu = new FormLichChieu(maPhim);
            this.Visible = false;
            formLichChieu.ShowDialog();
            this.Visible = true;
        }

        private void panelHinhAnhPhim_3_Click(object sender, EventArgs e)
        {
            string[] maPhim = new string[1];
            maPhim[0] = panelHinhAnhPhim_3.Tag.ToString();
            FormLichChieu formLichChieu = new FormLichChieu(maPhim);
            this.Visible = false;
            formLichChieu.ShowDialog();
            this.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất", "Đăng xuất", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                FormDangNhap.nguoiDung = null;
                this.Close();
            }

        }
    }
}
