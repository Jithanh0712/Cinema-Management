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

namespace RapChieuPhim.UserControls
{
    public partial class QLHH : UserControl
    {
        public QLHH()
        {
            InitializeComponent();
            txtMaHH.ReadOnly = true;
        }
        bool Them = false;
        QuanLyHangHoa hh = new QuanLyHangHoa();
        QuanLyNhaCC ncc = new QuanLyNhaCC();
        void LoadData()
        {
            try
            {
                dgvQLHH.DataSource = hh.LayDanhSachHangHoa();
                dgvQLHH.AutoGenerateColumns = true;
                dgvQLHH.AutoResizeColumns();
                this.txtMaHH.ResetText();
                this.txtTenHH.ResetText();
                this.txtDonGia.ResetText();
                this.txtSLTon.ResetText();
                this.cbbNhaCC.ResetText();

                this.txtMaHH.Enabled = false;
                this.txtTenHH.Enabled = false;
                this.txtDonGia.Enabled = false;
                this.txtSLTon.Enabled = false;
                this.cbbNhaCC.Enabled = false;


                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnHuy.Enabled = false;
                dgvQLHH_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HANGHOA. Lỗi rồi!!!");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaHH.ReadOnly = true;

            this.txtMaHH.ResetText();
            this.txtTenHH.ResetText();
            this.txtDonGia.ResetText();
            this.txtSLTon.ResetText();
            this.cbbNhaCC.ResetText();

            this.txtMaHH.Enabled = true;
            this.txtTenHH.Enabled = true;
            this.txtDonGia.Enabled = true;
            this.txtSLTon.Enabled = true;
            this.cbbNhaCC.Enabled = true;

            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaHH.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaHH.ReadOnly = true;

            this.txtMaHH.Enabled = true;
            this.txtTenHH.Enabled = true;
            this.txtDonGia.Enabled = true;
            this.txtSLTon.Enabled = true;
            this.cbbNhaCC.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLHH.CurrentCell.RowIndex;
                string MaHH = dgvQLHH.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    hh.XoaHangHoa(MaHH);
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

        private void dgvQLHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLHH.CurrentCell != null && dgvQLHH.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLHH.CurrentCell.RowIndex;
                this.txtMaHH.Text = dgvQLHH.Rows[r].Cells[0].Value.ToString();
                this.txtTenHH.Text = dgvQLHH.Rows[r].Cells[1].Value.ToString();
                this.txtDonGia.Text = dgvQLHH.Rows[r].Cells[2].Value.ToString();
                this.txtSLTon.Text = dgvQLHH.Rows[r].Cells[3].Value.ToString();
                this.cbbNhaCC.Text = dgvQLHH.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void QLHH_Load(object sender, EventArgs e)
        {
            LoadData();
            List<string> MaNhaCC = ncc.LayTatCaMaNCC();
            foreach (string value in MaNhaCC)
            {
                cbbNhaCC.Items.Add(value);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    string TenHH = txtTenHH.Text;
                    string DonGia = txtDonGia.Text;
                    string SLTon = txtSLTon.Text;
                    string NhaCC = cbbNhaCC.Text;

                    DTO_HangHoa HH = new DTO_HangHoa(TenHH, float.Parse(DonGia), int.Parse(SLTon), NhaCC);
                    if (hh.ThemHangHoa(HH))
                    {
                        MessageBox.Show("Thêm Hàng Hóa Thành Công!!!");
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
                txtTenHH.ResetText();
                txtDonGia.ResetText();
                txtSLTon.ResetText();
                cbbNhaCC.ResetText();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                try
                {
                    string MaHH = txtMaHH.Text;
                    string TenHH = txtTenHH.Text;
                    string DonGia = txtDonGia.Text;
                    string SLTon = txtSLTon.Text;
                    string NhaCC = cbbNhaCC.Text;

                    DTO_HangHoa HH = new DTO_HangHoa(MaHH, TenHH, float.Parse(DonGia), int.Parse(SLTon), NhaCC);
                    if (hh.CapNhatHangHoa(HH))
                    {
                        MessageBox.Show("Cập Nhật Hàng Hóa Thành Công!!!");
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
                txtMaHH.ResetText();
                txtTenHH.ResetText();
                txtDonGia.ResetText();
                txtSLTon.ResetText();
                cbbNhaCC.ResetText();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaHH.Enabled = false;
            this.txtTenHH.Enabled = false;
            this.txtDonGia.Enabled = false;
            this.txtSLTon.Enabled = false;
            this.cbbNhaCC.Enabled = false;

            LoadData();
        }
    }
}
