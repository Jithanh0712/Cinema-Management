using RapChieuPhim.DTO;
using RapChieuPhim.Forms;
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

namespace RapChieuPhim.UserControls
{
    public partial class NhaCC : UserControl
    {
        public NhaCC()
        {
            InitializeComponent();
            txtMaNCC.ReadOnly = true;
        }
        QuanLyNhaCC ncc = new QuanLyNhaCC();
        void LoadData()
        {
            try
            {
                dgvQLNCC.DataSource = ncc.LayDanhSachNhaCC();
                dgvQLNCC.AutoGenerateColumns = true;
                dgvQLNCC.AutoResizeColumns();
                this.txtMaNCC.ResetText();
                this.txtTenNCC.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                this.txtMaNCC.Enabled = false;
                this.txtTenNCC.Enabled = false;
                this.txtDiaChi.Enabled = false;
                this.txtSDT.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnHuy.Enabled = false;
                dgvQLNCC_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHACUNGCAP. Lỗi rồi!!!");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtMaNCC.ResetText();
            this.txtTenNCC.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();


            this.txtMaNCC.Enabled = true;
            this.txtTenNCC.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;


            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLNCC.CurrentCell.RowIndex;
                string MaNCC = dgvQLNCC.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    ncc.XoaNhaCC(MaNCC);

                    MessageBox.Show("Đã xóa xong!");
                    LoadData();
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

        private void NhaCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQLNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLNCC.CurrentCell != null && dgvQLNCC.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLNCC.CurrentCell.RowIndex;
                this.txtMaNCC.Text = dgvQLNCC.Rows[r].Cells[0].Value.ToString();
                this.txtTenNCC.Text = dgvQLNCC.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text = dgvQLNCC.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text = dgvQLNCC.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string TenNCC = txtTenNCC.Text;
                string DiaChi = txtDiaChi.Text;
                string SDT = txtSDT.Text;

                DTO_NhaCC NCC = new DTO_NhaCC(TenNCC, DiaChi, SDT);
                if (ncc.ThemNhaCC(NCC))
                {
                    MessageBox.Show("Thêm Nhà CC Thành Công!!!");
                    LoadData();
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
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaNCC.Enabled = false;
            this.txtTenNCC.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtSDT.Enabled = false;
            LoadData();
        }
    }
}
