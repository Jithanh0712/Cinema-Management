using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapChieuPhim.Forms;
using RapChieuPhim.SourceCode;

namespace RapChieuPhim
{
    public partial class FormDangNhap : Form
    {
        public static TaiKhoan nguoiDung;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.lblLoiTenDN.Text = "";
            this.lblLoiMK.Text = "";
            bool emty = false;
            if (this.txtTenDN.Text == "")
            {
                this.lblLoiTenDN.Text = "Tên đăng nhập không được bỏ trống";
                emty = true;
            }
            if (this.txtMK.Text == "")
            {
                this.lblLoiMK.Text = "Mật khẩu không được bỏ trống";
                emty = true;
            }
            if (emty)
                return;
            DangNhap dangNhap = new DangNhap();
            FormDangNhap.nguoiDung = dangNhap.TryLogin(txtTenDN.Text, txtMK.Text);
            if (FormDangNhap.nguoiDung != null)
            {
                MessageBox.Show("Đăng nhập thành công. Xin chào: " + FormDangNhap.nguoiDung.MaTaiKhoan);
                dangNhap.KiemTraMaGG();
                this.Close();
            }
            else
            {
                this.lblLoiTenDN.Text = "Tên đăng nhập hoặc mật khẩu đã sai";
                this.lblLoiMK.Text = "Tên đăng nhập hoặc mật khẩu đã sai";
            }
        }
    }
}
