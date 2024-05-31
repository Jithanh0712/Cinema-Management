using RapChieuPhim.Forms;
using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.UserControls
{
    public partial class UCLichChieu : UserControl
    {
        QuanLyPhim qlPhim = new QuanLyPhim();
        public UCLichChieu(String[] MaPhim, DateTime ngayChieu)
        {
            InitializeComponent();
            this.pnlLichChieu.Visible = false;
            int n = 0;
            for (int i = 0; i < MaPhim.Length; i++, n++)
            {
                Point point = new Point(this.pnlLichChieu.Location.X, this.pnlLichChieu.Location.Y
                    + this.pnlLichChieu.Height * n);
                Panel pnl = TaoPanel(point, MaPhim[i], ngayChieu);
                if(pnl != null)
                    this.Controls.Add(pnl);
                else
                    n--;
            }
        }

        private Panel TaoPanel(Point location, String MaPhim, DateTime ngayChieu)
        {
            DataTable dtChiTiet = new DataTable();
            dtChiTiet = qlPhim.ChiTietPhim(MaPhim);
            DataRow row = dtChiTiet.Rows[0];

            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Location = location;
            panel.Size = this.pnlLichChieu.Size;

            PictureBox pic = new PictureBox();
            pic.Location = this.picPhim.Location;
            pic.Size = this.picPhim.Size;
            pic.SizeMode  = PictureBoxSizeMode.Zoom;

            byte[] HinhAnh = (byte[])row["HinhAnh"];
            using (MemoryStream ms = new MemoryStream(HinhAnh))
            {
                Image hinhAnh = Image.FromStream(ms);
                pic.Image = hinhAnh;
            }

            panel.Controls.Add(pic);
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label label = new Label();
            label.Text = row["TenPhim"].ToString();
            label.Location = this.lblTenPhim.Location;
            label.Size = this.lblTenPhim.Size;
            label.AutoSize = true;
            label.Font = this.lblTenPhim.Font;
            
            panel.Controls.Add(label);
            panel.Tag = MaPhim;

            List<string> dsLC = new List<string>();
            dsLC = qlPhim.LayThoiGianLichChieu(MaPhim);
            List<string> dsLCSauKhiLoc = new List<string>();
            for (int i = 0; i < dsLC.Count; i++)
            {
                string lc = dsLC[i];
                string dateString = lc.Substring(18, 8).TrimEnd();
                dateString = $"{dateString.Substring(0,4)}/{dateString.Substring(4, 2)}/{dateString.Substring(6, 2)}";
                if (dateString == ngayChieu.ToString("yyyy/MM/dd"))
                    dsLCSauKhiLoc.Add(lc);
            }
            if (dsLCSauKhiLoc.Count == 0)
                return null;
            for (int j = 0; j < dsLCSauKhiLoc.Count; ++j)
            {
                 Button btn = new Button();
                 btn.Location = new Point(this.btnGioChieu.Location.X + (this.btnGioChieu.Width + 30)*j
                                , this.btnGioChieu.Location.Y);
                 btn.Font = this.btnGioChieu.Font;
                 btn.Text = dsLC[j].Substring(dsLCSauKhiLoc[j].Length - 4).Insert(2, ":");
                 btn.Size = this.btnGioChieu.Size;
                 btn.Tag = dsLCSauKhiLoc[j];
                 btn.Click += new EventHandler(btnLichChieu_Click);
                 panel.Controls.Add(btn);
             }
            return panel;
        }
        public void btnLichChieu_Click(object sender, EventArgs e)
        {
            FormPhongChieu form = new FormPhongChieu((sender as Button).Tag.ToString());
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
