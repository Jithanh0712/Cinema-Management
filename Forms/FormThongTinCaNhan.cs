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
using System.Data.SqlClient;

namespace RapChieuPhim.Forms
{
    public partial class FormThongTinCaNhan : Form
    {
        ThongTinCaNhan thongTinCaNhan;
        ThongTin nguoidung;
        bool isKH = false;
        string id;
        public FormThongTinCaNhan()
        {
            InitializeComponent();
            id = FormDangNhap.nguoiDung.Id;
            string role = FormDangNhap.nguoiDung.PhanQuyen;
            thongTinCaNhan = new ThongTinCaNhan();
            nguoidung = new ThongTin();
            if (role.Contains("KhachHang"))
            {
                nguoidung = thongTinCaNhan.getThongTinKhachHang(id);
                isKH = true;
            }
            else
            {
                nguoidung = thongTinCaNhan.getThongTinNhanVien(id);
            }
        }

        public FormThongTinCaNhan(string id)
        {
            InitializeComponent();
            this.id = id;
            thongTinCaNhan = new ThongTinCaNhan();
            nguoidung = new ThongTin();
            if (id.Contains("KH"))
            {
                nguoidung = thongTinCaNhan.getThongTinKhachHang(id);
                isKH = true;
            }
            else
            {
                nguoidung = thongTinCaNhan.getThongTinNhanVien(id);
            }
        }

        public void LoadData()
        {
            try
            {
                if (isKH)
                {
                    this.txtMaNguoiDung.Text = nguoidung.MaNguoiDung;
                    this.txtTenNguoiDung.Text = nguoidung.Hoten;
                    this.txtDiaChi.Text = nguoidung.Diachi;
                    if (nguoidung.Gioitinh == "Nam")
                    {
                        this.rdbNam.Checked = true;
                    }
                    else
                    {
                        this.rdbNu.Checked = true;
                    }
                    this.dateNgaySinh.Value = nguoidung.NgaySinh;
                    this.txtSDT.Text = nguoidung.Sdt;
                    this.txtDiemTL.Text = Convert.ToString(nguoidung.DiemTL);
                    this.txtHang.Text = nguoidung.LoaiKH;
                }
                else
                {
                    this.lblDiemTL.Visible = false; ;
                    this.lblHang.Visible = false;
                    this.txtDiemTL.Visible = false;
                    this.txtHang.Visible = false;
                    this.txtMaNguoiDung.Text = nguoidung.MaNguoiDung;
                    this.txtTenNguoiDung.Text = nguoidung.Hoten;
                    this.txtDiaChi.Text = nguoidung.Diachi;
                    if (nguoidung.Gioitinh == "Nam")
                    {
                        this.rdbNam.Checked = true;
                    }
                    else
                    {
                        this.rdbNu.Checked = true;
                    }
                    this.dateNgaySinh.Value = nguoidung.NgaySinh;
                    this.txtSDT.Text = nguoidung.Sdt;
                }
            }
            catch { }
        }
        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.txtTenNguoiDung.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.rdbNam.Enabled = true;
            this.rdbNu.Enabled = true;
            this.dateNgaySinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;

            this.txtTenNguoiDung.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.rdbNam.Enabled = false;
            this.rdbNu.Enabled = false;
            this.dateNgaySinh.Enabled = false;
            this.txtSDT.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnHuy.Enabled = false;

            string gioitinh;
            if (rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }

            try
            {
                if (isKH)
                {
                    thongTinCaNhan.updateThongTinKhachHang(txtMaNguoiDung.Text, txtTenNguoiDung.Text, txtDiaChi.Text, gioitinh, dateNgaySinh.Value.ToShortDateString(), txtSDT.Text, nguoidung);
                }
                else
                {
                    thongTinCaNhan.updateThongTinNhanVien(txtMaNguoiDung.Text, txtTenNguoiDung.Text, txtDiaChi.Text, gioitinh, dateNgaySinh.Text, txtSDT.Text, nguoidung);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi");
                throw ex;
            }
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;

            this.txtTenNguoiDung.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.rdbNam.Enabled = false;
            this.rdbNu.Enabled = false;
            this.dateNgaySinh.Enabled = false;
            this.txtSDT.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnHuy.Enabled = false;
            LoadData();
        }

    }
}
