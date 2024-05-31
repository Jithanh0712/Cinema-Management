using RapChieuPhim.Forms;
using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.UserControls
{
    public partial class UCChiTietPhim : UserControl
    {
        private String maPhimCurClick;
        QuanLyPhim qlPhim;
        public UCChiTietPhim(DataTable dtPhim)
        {
            InitializeComponent();
            qlPhim = new QuanLyPhim();
            this.pnlPhim.Visible = false;
            int slPhim = dtPhim.Rows.Count;
            for (int i = 0; i < dtPhim.Rows.Count; ++i)
            {
                Point point = new Point(this.pnlPhim.Location.X, this.pnlPhim.Location.Y + this.pnlPhim.Height * i);
                this.pnlPhims.Controls.Add(TaoPanel(point, dtPhim.Rows[i]));
            }
        }

        private Panel TaoPanel(Point location, DataRow phim)
        {
            string tenPhim = phim["TenPhim"].ToString();
            string ngayKhoiChieu = phim["NgayKhoiChieu"].ToString();
            string maPhim = phim["MaPhim"].ToString();

            Panel panel = new Panel();
            panel.Location = new Point(location.X, location.Y);
            panel.Size = this.pnlPhim.Size;

            Label lblTen = new Label();
            lblTen.AutoSize = true;
            lblTen.Location = this.lblTenPhim_pnl.Location;
            lblTen.Font = this.lblTenPhim_pnl.Font;
            lblTen.Size = this.lblTenPhim_pnl.Size;
            lblTen.Text = tenPhim;
            lblTen.MaximumSize = new System.Drawing.Size(200, 0);

            Label lblNgayKC = new Label();
            lblNgayKC.Location = new Point(lblTen.Location.X,
                this.lblNgayKhoiChieu_pnl.Location.Y + (lblTen.Height - this.lblTenPhim_pnl.Height));
            lblNgayKC.Font = this.lblNgayKhoiChieu_pnl.Font;
            lblNgayKC.Size = this.lblNgayKhoiChieu_pnl.Size;
            lblNgayKC.Text = ngayKhoiChieu;

            //panel.Size = new Size(this.pnlPhim.Width, this.pnlPhim.Height + (lblTen.Height - this.lblTenPhim_pnl.Height));
            panel.Controls.Add(lblTen);
            panel.Controls.Add(lblNgayKC);


            panel.Click += new EventHandler(pnlPhim_Click);
            panel.Tag = maPhim;

            foreach (Label control in panel.Controls)
            {
                control.Tag = maPhim;
                control.Click += new EventHandler(pnlLable_Click);
            }

            return panel;
        }

        private void pnlPhim_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            string maPhim = (sender as Panel).Tag.ToString();

            DataTable dataTable = new DataTable();
            dataTable = qlPhim.ChiTietPhim(maPhim);
            DataRow row = dataTable.Rows[0];

            this.txtTenPhim.Text = row["TenPhim"].ToString();
            this.txtDaoDien.Text = row["DaoDien"].ToString();
            this.txtNhaSX.Text = row["NhaSX"].ToString();
            this.txtNamSX.Text = row["NamSX"].ToString();
            this.txtHinhThuc.Text = row["HinhThuc"].ToString();
            this.btnDinhDang.Text = row["DinhDang"].ToString();
            this.btnDanhGia.Text = row["DanhGia"].ToString();
            this.btnXepLoai.Text = row["XepLoai"].ToString();
            this.txtDoDai.Text = row["DoDai"].ToString();
            byte[] HinhAnh = (byte[])row["HinhAnh"];
            using (MemoryStream ms = new MemoryStream(HinhAnh))
            {
                Image hinhAnh = Image.FromStream(ms);
                picPhim.Image = hinhAnh;
            }
            DateTime ngayChieu = qlPhim.LayNgayKhoiChieu(maPhim);
            if (ngayChieu >= dtpNgayKhoiChieu.MinDate && ngayChieu <= dtpNgayKhoiChieu.MaxDate)
            {
                this.dtpNgayKhoiChieu.Value = ngayChieu;
            }
            else
            {
                this.dtpNgayKhoiChieu.Value = DateTime.Now;
            }
            rtbDienVien.Text = string.Join(", ", qlPhim.LayDSDienVien(maPhim));
            rtbMoTa.Text = row["MoTa"].ToString();
            maPhimCurClick = (sender as Panel).Tag.ToString();
        }

        private void pnlLable_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            string maPhim = (sender as Label).Tag.ToString();

            DataTable dataTable = new DataTable();
            dataTable = qlPhim.ChiTietPhim(maPhim);
            DataRow row = dataTable.Rows[0];

            this.txtTenPhim.Text = row["TenPhim"].ToString();
            this.txtDaoDien.Text = row["DaoDien"].ToString();
            this.txtNhaSX.Text = row["NhaSX"].ToString();
            this.txtNamSX.Text = row["NamSX"].ToString();
            this.txtHinhThuc.Text = row["HinhThuc"].ToString();
            this.btnDinhDang.Text = row["DinhDang"].ToString();
            this.btnDanhGia.Text = row["DanhGia"].ToString();
            this.btnXepLoai.Text = row["XepLoai"].ToString();
            this.txtDoDai.Text = row["DoDai"].ToString();
            byte[] HinhAnh = (byte[])row["HinhAnh"];
            using (MemoryStream ms = new MemoryStream(HinhAnh))
            {
                Image hinhAnh = Image.FromStream(ms);
                picPhim.Image = hinhAnh;
            }
            //this.dtpNgayKhoiChieu.Value
            DateTime ngayChieu = qlPhim.LayNgayKhoiChieu(maPhim);
            if (ngayChieu >= dtpNgayKhoiChieu.MinDate && ngayChieu <= dtpNgayKhoiChieu.MaxDate)
            {
                this.dtpNgayKhoiChieu.Value = ngayChieu;
            }
            else
            {
                this.dtpNgayKhoiChieu.Value = DateTime.Now;
            }
            rtbDienVien.Text = string.Join(", ", qlPhim.LayDSDienVien(maPhim));
            rtbMoTa.Text = row["MoTa"].ToString();
            maPhimCurClick = (sender as Label).Tag.ToString();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (maPhimCurClick == null)
                return;
            FormLichChieu form = new FormLichChieu(new string[] { maPhimCurClick });
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void XoaTextBox()
        {
            this.txtTenPhim.Text = "";
            this.txtDaoDien.Text = "";
            this.txtDoDai.Text = "";
            this.txtHinhThuc.Text = "";
            this.txtNamSX.Text = "";
            this.txtNhaSX.Text = "";
            this.btnDanhGia.Text = "";
            this.btnDinhDang.Text = "";
            this.btnXepLoai.Text = "";
            this.picPhim.Image = null;
            this.rtbDienVien.Text = "";
            this.rtbMoTa.Text = "";
        }
    }
}
