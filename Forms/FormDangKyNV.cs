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
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
        }
        bool Them;
        QuanLyNhanVien nv = new QuanLyNhanVien();
        QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
        void LoadData()
        {
            try
            {
                dgvQLNV.DataSource = nv.LayDanhSachNhanVien();
                dgvQLNV.AutoGenerateColumns = true;
                dgvQLNV.AutoResizeColumns();
                this.txtMaNV.ResetText();
                this.txtHoTen.ResetText();
                this.txtDiaChi.ResetText();
                this.dtpNgaySinh.ResetText();
                this.txtSDT.ResetText();
                this.rdbNam.Checked = false;
                this.rdbNu.Checked = false;
                this.cbbChucVu.ResetText();
                this.txtTaiKhoan.ResetText();
                this.txtMatKhau.ResetText();
                this.txtLuong.ResetText();
                this.cbbPhanQuyen.ResetText();
                this.txtMaTK.ResetText();

                this.txtMaNV.Enabled = false;
                this.txtHoTen.Enabled = false;
                this.txtDiaChi.Enabled = false;
                this.dtpNgaySinh.Enabled = false;
                this.txtSDT.Enabled = false;
                this.rdbNam.Enabled = false;
                this.rdbNu.Enabled = false;
                this.cbbChucVu.Enabled = false;
                this.txtTaiKhoan.Enabled = false;
                this.txtMatKhau.Enabled = false;
                this.txtLuong.Enabled = false;
                this.cbbPhanQuyen.Enabled = false;
                this.txtMaTK.Enabled = false;

                this.btnThemNV.Enabled = true;
                this.btnXoaNV.Enabled = true;
                this.btnCapNhatNV.Enabled = true;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                dgvQLNV_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }
        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLNV.CurrentCell != null && dgvQLNV.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLNV.CurrentCell.RowIndex;
                this.txtMaNV.Text = dgvQLNV.Rows[r].Cells[0].Value.ToString();
                this.txtHoTen.Text = dgvQLNV.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text = dgvQLNV.Rows[r].Cells[2].Value.ToString();
                this.dtpNgaySinh.Text = dgvQLNV.Rows[r].Cells[3].Value.ToString();
                this.txtSDT.Text = dgvQLNV.Rows[r].Cells[4].Value.ToString();
                string gioiTinh = dgvQLNV.Rows[r].Cells[5].Value.ToString();
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
                this.cbbChucVu.Text = dgvQLNV.Rows[r].Cells[6].Value.ToString();
                this.txtTaiKhoan.Text = dgvQLNV.Rows[r].Cells[7].Value.ToString();
                this.txtMatKhau.Text = dgvQLNV.Rows[r].Cells[8].Value.ToString();
                this.txtLuong.Text = dgvQLNV.Rows[r].Cells[9].Value.ToString();
                this.cbbPhanQuyen.Text = dgvQLNV.Rows[r].Cells[10].Value.ToString();
                this.txtMaTK.Text = dgvQLNV.Rows[r].Cells[11].Value.ToString();
            }
        }
        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChucVu = cbbChucVu.SelectedItem.ToString();

            cbbPhanQuyen.Items.Clear();

            if (selectedChucVu == "ToanThoiGian" || selectedChucVu == "ThoiVu" || selectedChucVu == "BanThoiGian")
            {
                cbbPhanQuyen.Items.Add("NhanVien");
                cbbPhanQuyen.SelectedItem = "NhanVien";
            }
            else
            {
                cbbPhanQuyen.Items.Add("QuanLy");
                cbbPhanQuyen.SelectedItem = "QuanLy";
            }

        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaNV.ReadOnly = true;
            this.txtMaTK.ReadOnly = true;
            this.txtMaTK.Text = tk.TaoMaTaiKhoanTuDong();
            this.txtMaNV.ResetText();
            this.txtHoTen.ResetText();
            this.txtDiaChi.ResetText();
            this.dtpNgaySinh.ResetText();
            this.txtSDT.ResetText();
            this.rdbNam.Checked = false;
            this.rdbNu.Checked = false;
            this.cbbChucVu.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.txtLuong.ResetText();
            this.cbbPhanQuyen.ResetText();

            this.txtMaNV.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.rdbNam.Enabled = true;
            this.rdbNu.Enabled = true;
            this.cbbChucVu.Enabled = true;
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = true;
            this.txtLuong.Enabled = true;
            this.cbbPhanQuyen.Enabled = true;
            this.txtMaTK.Enabled = true;

            btnCapNhatNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaNV.Focus();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLNV.CurrentCell.RowIndex;
                string MaNV = dgvQLNV.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    nv.XoaNhanVien(MaNV);
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

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaNV.ReadOnly = true;
            txtMaTK.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = true;

            this.txtMaNV.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.rdbNam.Enabled = true;
            this.rdbNu.Enabled = true;
            this.cbbChucVu.Enabled = true;
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = true;
            this.txtLuong.Enabled = true;
            this.cbbPhanQuyen.Enabled = true;
            this.txtMaTK.Enabled = true;

            btnThemNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    DateTime NgaySinh = dtpNgaySinh.Value;
                    string SDT = txtSDT.Text;
                    string GioiTinh;
                    if (rdbNam.Checked)
                    {
                        GioiTinh = rdbNam.Text;
                    }
                    else { GioiTinh = rdbNu.Text; }
                    string ChucVu = cbbChucVu.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string Luong = txtLuong.Text;
                    string PhanQuyen = cbbPhanQuyen.Text;
                    string MaTaiKhoan = txtMaTK.Text;

                    DTO_TaiKhoan TK = new DTO_TaiKhoan(MaTaiKhoan, TaiKhoan, MatKhau, PhanQuyen);
                    DTO_NhanVien NV = new DTO_NhanVien(HoTen, DiaChi, NgaySinh, SDT, GioiTinh, ChucVu, MaTaiKhoan, float.Parse(Luong));
                    if (tk.ThemTaiKhoan(TK))
                    {
                        if (nv.ThemNhanVien(NV))
                        {
                            MessageBox.Show("Thêm Nhân Viên Thành Công!!!");
                            LoadData();
                        }
                        else
                        {
                            tk.XoaTaiKhoan(MaTaiKhoan);
                            MessageBox.Show("Thêm Nhân Viên Không Thành Công!!!");
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
                txtMaNV.ResetText();
                txtHoTen.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
                txtSDT.ResetText();
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                cbbChucVu.ResetText();
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtLuong.ResetText();
                cbbPhanQuyen.ResetText();
                txtMaTK.ResetText();
                Them = false;
                btnCapNhatNV.Enabled = true;
                btnXoaNV.Enabled = true;
            }
            else
            {
                try
                {
                    string MaNV = txtMaNV.Text;
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    DateTime NgaySinh = dtpNgaySinh.Value;
                    string SDT = txtSDT.Text;
                    string GioiTinh;
                    if (rdbNam.Checked)
                    {
                        GioiTinh = rdbNam.Text;
                    }
                    else { GioiTinh = rdbNu.Text; }
                    string ChucVu = cbbChucVu.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string Luong = txtLuong.Text;
                    string PhanQuyen = cbbPhanQuyen.Text;
                    string MaTaiKhoan = txtMaTK.Text;
                    DTO_NhanVien NV = new DTO_NhanVien(MaNV, HoTen, DiaChi, NgaySinh, SDT, GioiTinh, ChucVu, float.Parse(Luong));
                    if (nv.CapNhatNhanVien(NV))
                    {
                        MessageBox.Show("Cập Nhật Nhân Viên Thành Công!!!");
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
                txtMaNV.ResetText();
                txtHoTen.ResetText();
                txtDiaChi.ResetText();
                dtpNgaySinh.ResetText();
                txtSDT.ResetText();
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                cbbChucVu.ResetText();
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtLuong.ResetText();
                cbbPhanQuyen.ResetText();
                txtMaTK.ResetText();
                btnThemNV.Enabled = true;
                btnXoaNV.Enabled = true;
            }
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThemNV.Enabled = true;
            this.btnCapNhatNV.Enabled = true;
            this.btnXoaNV.Enabled = true;

            this.txtMaNV.Enabled = false;
            this.txtHoTen.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
            this.txtSDT.Enabled = false;
            this.rdbNam.Enabled = false;
            this.rdbNu.Enabled = false;
            this.cbbChucVu.Enabled = false;
            this.txtTaiKhoan.Enabled = false;
            this.txtMatKhau.Enabled = false;
            this.txtLuong.Enabled = false;
            this.cbbPhanQuyen.Enabled = false;
            this.txtMaTK.Enabled = false;
            LoadData();
        }
    }
}
