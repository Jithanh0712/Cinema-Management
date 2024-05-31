using RapChieuPhim.DTO;
using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Forms
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }
        bool Them;
        QuanLyKhachHang kh = new QuanLyKhachHang();
        QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
        void LoadData()
        {
            try
            {
                dgvQLKHg.DataSource = kh.LayDanhSachKhachHang();
                dgvQLKHg.AutoGenerateColumns = true;
                dgvQLKHg.AutoResizeColumns();
                this.txtMaKH.ResetText();
                this.txtHoTen.ResetText();
                this.txtDiaChi.ResetText();
                this.rdbNam.Checked = false;
                this.rdbNu.Checked = false;
                this.dtpNgaySinh.ResetText();
                this.txtSDT.ResetText();
                this.txtMaTaiKhoan.ResetText();
                this.txtTaiKhoan.ResetText();
                this.txtMatKhau.ResetText();

                this.txtMaKH.Enabled = false;
                this.txtHoTen.Enabled = false;
                this.txtDiaChi.Enabled = false;
                this.rdbNam.Enabled = false;
                this.rdbNu.Enabled = false;
                this.dtpNgaySinh.Enabled = false;
                this.txtSDT.Enabled = false;
                this.txtTaiKhoan.Enabled = false;
                this.txtMatKhau.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnLuu.Enabled = true;
                this.btnHuy.Enabled = false;
                dgvQLKHg_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }
        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaKH.ReadOnly = true;
            txtMaTaiKhoan.ReadOnly = true;
            txtMaTaiKhoan.Text = tk.TaoMaTaiKhoanTuDong();
            this.txtMaKH.ResetText();
            this.txtHoTen.ResetText();
            this.txtDiaChi.ResetText();
            this.rdbNam.Checked = false;
            this.rdbNu.Checked = false;
            this.dtpNgaySinh.ResetText();
            this.txtSDT.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();

            this.txtMaKH.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.rdbNam.Enabled = true;
            this.rdbNu.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaKH.ReadOnly = true;
            txtMaTaiKhoan.ReadOnly = true;
            txtTaiKhoan.ReadOnly = false;
            txtMatKhau.ReadOnly = false;

            this.txtMaKH.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.rdbNam.Enabled = true;
            this.rdbNu.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLKHg.CurrentCell.RowIndex;
                string MaKH = dgvQLKHg.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    kh.XoaKhachHang(MaKH);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    string GioiTinh;
                    if (rdbNam.Checked)
                    {
                        GioiTinh = rdbNam.Text;
                    }
                    else { GioiTinh = rdbNu.Text; }
                    DateTime NgaySinh = dtpNgaySinh.Value;
                    string SDT = txtSDT.Text;
                    string MaTaiKhoan = txtMaTaiKhoan.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string PhanQuyen = "KhachHang";

                    DTO_TaiKhoan TK = new DTO_TaiKhoan(MaTaiKhoan, TaiKhoan, MatKhau, PhanQuyen);
                    DTO_KhachHang KH = new DTO_KhachHang(HoTen, DiaChi, GioiTinh, NgaySinh, SDT, MaTaiKhoan);
                    if (tk.ThemTaiKhoan(TK))
                    {
                        if (kh.ThemKhachHang(KH))
                        {
                            MessageBox.Show("Thêm Khách Hàng Thành Công!!!");
                            LoadData();
                        }
                        else
                        {
                            tk.XoaTaiKhoan(MaTaiKhoan);
                            MessageBox.Show("Thêm Khách Hàng Không Thành Công!!!");
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm không Thành Công\n Lỗi Dữ Liệu Nhập!!!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi");
                    throw ex;
                }
                txtMaKH.ResetText();
                txtHoTen.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
                txtSDT.ResetText();
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtMaTaiKhoan.ResetText();
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                Them = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                try
                {
                    string MaKH = txtMaKH.Text;
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    string GioiTinh;
                    if (rdbNam.Checked)
                    {
                        GioiTinh = rdbNam.Text;
                    }
                    else { GioiTinh = rdbNu.Text; }
                    DateTime NgaySinh = dtpNgaySinh.Value;
                    string SDT = txtSDT.Text;
                    string MaTaiKhoan = txtMaTaiKhoan.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string PhanQuyen = "KhachHang";

                    DTO_KhachHang KH = new DTO_KhachHang(MaKH, HoTen, DiaChi, GioiTinh, NgaySinh, SDT);
                    if (kh.CapNhatKhachHang(KH))
                    {
                        MessageBox.Show("Cập Nhật Khách Hàng Thành Công!!!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không Thành Công\n Lỗi Dữ Liệu Nhập!!!");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi");
                    throw ex;
                }
                txtTaiKhoan.ReadOnly = false;
                txtMatKhau.ReadOnly = false;
                txtMaKH.ResetText();
                txtHoTen.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
                txtSDT.ResetText();
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtMaTaiKhoan.ResetText();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgvQLKHg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLKHg.CurrentCell != null && dgvQLKHg.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLKHg.CurrentCell.RowIndex;
                this.txtMaKH.Text = dgvQLKHg.Rows[r].Cells[0].Value.ToString();
                this.txtHoTen.Text = dgvQLKHg.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text = dgvQLKHg.Rows[r].Cells[2].Value.ToString();
                string gioiTinh = dgvQLKHg.Rows[r].Cells[3].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = true;
                }
                else
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = false;
                }
                this.dtpNgaySinh.Text = dgvQLKHg.Rows[r].Cells[4].Value.ToString();
                this.txtSDT.Text = dgvQLKHg.Rows[r].Cells[5].Value.ToString();
                this.txtMaTaiKhoan.Text = dgvQLKHg.Rows[r].Cells[8].Value.ToString();
                this.txtTaiKhoan.Text = dgvQLKHg.Rows[r].Cells[9].Value.ToString();
                this.txtMatKhau.Text = dgvQLKHg.Rows[r].Cells[10].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaKH.Enabled = false;
            this.txtHoTen.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.rdbNam.Enabled = false;
            this.rdbNu.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
            this.txtSDT.Enabled = false;
            this.txtTaiKhoan.Enabled = false;
            this.txtMatKhau.Enabled = false;

            LoadData();
        }
    }
}
