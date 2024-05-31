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
    public partial class FormDangKy : Form
    {
        DangKy dangKy;
        public FormDangKy()
        {
            InitializeComponent();
            dangKy = new DangKy();
            XoaThongBaoLoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            XoaThongBaoLoi();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraDienDayDu())
                return;
            if (dangKy.DangKyKH(this.txtHoTen.Text, this.dtpNgaySinh.Value, this.rdbNu.Checked,
                this.txtDiaChi.Text, this.txtSDT.Text, this.txtTaiKhoan.Text, this.txtMK.Text))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
        }

        private void XoaThongBaoLoi()
        {
            this.lblLoiHoTen.Text = "";
            this.lblLoiNgaySinh.Text = "";
            this.lblLoiGioiTinh.Text = "";
            this.lblLoiDiaChi.Text = "";
            this.lblLoiSDT.Text = "";
            this.lblLoiMK.Text = "";
            this.lblLoiNhapLaiMK.Text = "";
            this.lblLoiTaiKhoan.Text = "";
        }

        private bool KiemTraDienDayDu()
        {
            XoaThongBaoLoi();
            bool result = true;
            if (this.txtHoTen.Text == "")
            {
                result = false;
                this.lblLoiHoTen.Text = "Họ tên không được bỏ trống";
            }
            if (this.txtSDT.Text == "")
            {
                result = false;
                this.lblLoiSDT.Text = "Số điện thoại không được bỏ trống";
            }
            if(this.txtMK.Text != this.txtNhapLaiMK.Text)
            {
                result = false;
                this.lblLoiNhapLaiMK.Text = "Mật khẩu nhập lại không đúng";
            }
            return result;
        }
    }
}
