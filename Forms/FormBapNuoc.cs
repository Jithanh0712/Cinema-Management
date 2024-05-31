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

namespace RapChieuPhim.Forms
{
    public partial class FormBapNuoc : Form
    {
        string maVe;
        QuanLyHangHoa qlHH;
        public FormBapNuoc(string MaVe)
        {
            InitializeComponent();
            this.maVe = MaVe;
            qlHH = new QuanLyHangHoa();
            lblHienMaKH.Text = FormDangNhap.nguoiDung.Id;
            this.pnlHH.Visible = false;
            this.pnlHangHoas.Controls.Remove(this.pnlHH);
            HienThiHangHoa();
        }

        private void HienThiHangHoa()
        {
            DataTable dt = qlHH.LayDanhSachHangHoa();
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel();
                panel.Location = new Point(this.pnlHH.Location.X, this.pnlHH.Location.Y + this.pnlHH.Height * i++);
                panel.Size = this.pnlHH.Size;

                Label lblTenHH = new Label();
                lblTenHH.Location = this.lblTenHH_pnl.Location;
                lblTenHH.Size = this.lblTenHH_pnl.Size;
                lblTenHH.Font = this.lblTenHH_pnl.Font;
                lblTenHH.Text = dr["TenHH"].ToString();

                Label lblGia = new Label();
                lblGia.Location = this.lblGiaTien_pnl.Location;
                lblGia.Size = this.lblGiaTien_pnl.Size;
                lblGia.Font = this.lblGiaTien_pnl.Font;
                lblGia.Text = dr["DonGia"].ToString();

                NumericUpDown nudSL = new NumericUpDown();
                nudSL.Location = this.nudSL_pnl.Location;
                nudSL.Size = this.nudSL_pnl.Size;
                nudSL.Font = this.nudSL_pnl.Font;

                panel.Controls.Add(lblGia);
                panel.Controls.Add(lblTenHH);
                panel.Controls.Add(nudSL);

                panel.Tag = dr["MaHH"].ToString();
                pnlHangHoas.Controls.Add(panel);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataTable dtThanhToan = new DataTable();
            dtThanhToan.Columns.Add("MaHH", typeof(string));
            dtThanhToan.Columns.Add("SL", typeof(int));

            foreach (Panel panel in pnlHangHoas.Controls.OfType<Panel>())
            {
                string maHH = panel.Tag.ToString();
                NumericUpDown nudSL = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (nudSL.Value > 0)
                {
                    dtThanhToan.Rows.Add(maHH, (int)nudSL.Value);
                }
            }
            FormBanHang formBanHang = new FormBanHang(dtThanhToan, maVe);
            //FormThanhToan formThanhToan = new FormThanhToan(dtThanhToan, maVe);
            this.Visible = false;
            formBanHang.ShowDialog(); 
            //formThanhToan.ShowDialog();
            this.Close();
        }
    }
}
