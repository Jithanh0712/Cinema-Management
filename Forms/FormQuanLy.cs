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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void lblQLNV_Click(object sender, EventArgs e)
        {
            FormQLNV form = new FormQLNV();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblQLLC_Click(object sender, EventArgs e)
        {
            FormQLLC form = new FormQLLC();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblHuyHD_Click(object sender, EventArgs e)
        {
            FormHuyHD form = new FormHuyHD();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblQLKH_Click(object sender, EventArgs e)
        {
            FormQLKH form = new FormQLKH();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblQLP_Click(object sender, EventArgs e)
        {
            FormQLP form = new FormQLP();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan form = new FormThongTinCaNhan();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblQLPC_Click(object sender, EventArgs e)
        {
            FormQLPhongChieu form = new FormQLPhongChieu();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void lblQLKHg_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang form = new FormQuanLyKhachHang();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void pnlQLGG_Click(object sender, EventArgs e)
        {
            FormQLMaGiamGia form = new FormQLMaGiamGia();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
