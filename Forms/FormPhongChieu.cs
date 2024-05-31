using RapChieuPhim.SourceCode;
using RapChieuPhim.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Forms
{
    public partial class FormPhongChieu : Form
    {
        QuanLyLichChieu qlLC;
        string maLC;
        public FormPhongChieu(string MaLichChieu)
        {
            InitializeComponent();
            this.maLC = MaLichChieu;
            AddScrollBar(pnlGhes);
            pnlGhes.AutoScroll = true;
            qlLC = new QuanLyLichChieu();
            DataTable dsVe = qlLC.LayDSVe(MaLichChieu);
            this.ThemGhe(dsVe);
        }
        public void AddScrollBar(Panel panel)
        {
            VScrollBar vsb = new VScrollBar();
            vsb.Dock = DockStyle.Right;
            vsb.Visible = false;
            panel.Controls.Add(vsb);
        }

        private void ThemGhe(DataTable dsVe)
        {
            int x = 30;
            char previousChar = '\0';
            DataView dv = dsVe.DefaultView;
            dv.Sort = "MaVe";
            DataTable sortedDsVe = dv.ToTable();
            foreach (DataRow row in sortedDsVe.Rows)
            {
                string maVe = row["MaVe"].ToString();

                //Lấy ký hàng của vé VD: A,B,C,...
                char loaiGhe = maVe[^6];
                // Lấy stt của vé VD: 1,2,..
                int soGhe = int.Parse(maVe.Substring(maVe.Length - 5, 2));
                Button button = new Button();
                button.Text = loaiGhe + soGhe.ToString();

                // Size của ghế đôi sẽ gấp đôi ghế thường
                button.Size = (maVe.Contains("DOI")) ? new Size(100, 50) : new Size(50, 50);

                // Màu nền cho từng loại ghế
                if (maVe.Contains("VIP"))
                {
                    button.BackColor = ColorTranslator.FromHtml("#E63946");
                    button.ForeColor = Color.Black;
                }
                else if (maVe.Contains("THU"))
                {
                    button.BackColor = ColorTranslator.FromHtml("#457B9D");
                    button.ForeColor = Color.White;
                }
                else if (maVe.Contains("DOI"))
                {
                    button.BackColor = ColorTranslator.FromHtml("#1D3557");
                    button.ForeColor = ColorTranslator.FromHtml("#F1FAEE");
                }

                // Tính tọa độ
                if (loaiGhe != previousChar)
                    x = 30;
                x = soGhe * (button.Width + 10);
                int y = (loaiGhe - 'A') * (button.Height + 10) + 10;
                button.Location = new Point(x, y);
                previousChar = loaiGhe;

                // Kiểm tra trạng thái và thực hiện chuyển nền và màu chữ nếu TrangThai là 0
                if (row["TrangThai"].ToString() == "True")
                {
                    button.BackColor = ColorTranslator.FromHtml("#F1FAEE");
                    button.ForeColor = Color.White;
                    pnlGhes.Controls.Add(button);
                }
                else
                {
                    button.Tag = maVe;
                    button.Click += new EventHandler(btnVe_Click);
                    pnlGhes.Controls.Add(button);
                }
            }
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.nguoiDung.PhanQuyen == "KhachHang")
            {
                FormBapNuoc formBapNuoc = new FormBapNuoc((sender as Button).Tag.ToString());
                this.Visible = false;
                formBapNuoc.ShowDialog();
                this.Close();
            }
            else
            {
                FormBanHang formBanHang = new FormBanHang((sender as Button).Tag.ToString());
                this.Visible = false;
                formBanHang.ShowDialog();
                this.Close();
            }
        }
    }
}
