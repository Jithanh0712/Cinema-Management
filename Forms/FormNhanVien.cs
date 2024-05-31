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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            lblMaNV.Text = FormDangNhap.nguoiDung.Id;
        }

        private void btnXemDSPhim_Click(object sender, EventArgs e)
        {
            FormTimKiemPhim formTimKiem = new FormTimKiemPhim();
            this.Visible = false;
            formTimKiem.ShowDialog();
            this.Visible = true;
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan formTTNV = new FormThongTinCaNhan();
            this.Visible = false;
            formTTNV.ShowDialog();
            this.Visible = true;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang formBH = new FormBanHang();
            this.Visible = false;
            formBH.ShowDialog();
            this.Visible = true;
        }

        private void btnLSTT_Click(object sender, EventArgs e)
        {
            FormLichSuTT formLichSuTT = new FormLichSuTT();
            this.Visible = false;
            formLichSuTT.ShowDialog();
            this.Visible = true;
        }
    }
}
