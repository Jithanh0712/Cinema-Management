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
    public partial class FormQLMaGiamGia : Form
    {
        public FormQLMaGiamGia()
        {
            InitializeComponent();
        }
        bool Them;
        QuanLyGiamGia gg = new QuanLyGiamGia();
        QuanLyHangHoa hh = new QuanLyHangHoa();
        void LoadData()
        {
            try
            {
                dgvQLMGG.DataSource = gg.LayGiamGia();
                dgvQLMGG.AutoGenerateColumns = true;
                dgvQLMGG.AutoResizeColumns();
                dgvQLMGG.Columns["MaNQL"].Visible = false;
                this.txtMaGG.ResetText();
                this.cbbLoaiGG.ResetText();
                this.cbbMaHH.ResetText();
                this.txtDieuKien.ResetText();
                this.txtGiaTri.ResetText();
                this.dtpNgayHet.ResetText();

                this.txtMaGG.Enabled = false;
                this.cbbLoaiGG.Enabled = false;
                this.cbbMaHH.Enabled = false;
                this.txtDieuKien.Enabled = false;
                this.txtGiaTri.Enabled = false;
                this.dtpNgayHet.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnHuy.Enabled = false;

                dgvQLMGG_CellClick(null, null);
            }
            catch { }
        }
        private void dgvQLMGG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLMGG.Rows.Count > 0 && dgvQLMGG.CurrentCell != null)
            {
                r = dgvQLMGG.CurrentCell.RowIndex;
                txtMaGG.Text = dgvQLMGG.Rows[r].Cells[0].Value.ToString();
                cbbLoaiGG.Text = dgvQLMGG.Rows[r].Cells[1].Value.ToString();
                cbbMaHH.Text = dgvQLMGG.Rows[r].Cells[2].Value.ToString();
                txtGiaTri.Text = dgvQLMGG.Rows[r].Cells[3].Value.ToString();
                dtpNgayHet.Value = Convert.ToDateTime(dgvQLMGG.Rows[r].Cells[4].Value);
                txtDieuKien.Text = dgvQLMGG.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void FormQLMaGiamGia_Load(object sender, EventArgs e)
        {
            LoadData();
            List<string> MaHH = hh.LayTatCaMaHangHoa();
            foreach (string value in MaHH)
            {
                cbbMaHH.Items.Add(value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaGG.ReadOnly = true;

            this.txtMaGG.Enabled = true;
            this.cbbLoaiGG.Enabled = true;
            this.cbbMaHH.Enabled = true;
            this.txtDieuKien.Enabled = true;
            this.txtGiaTri.Enabled = true;
            this.dtpNgayHet.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaGG.ReadOnly = true;

            this.txtMaGG.Text = gg.TaoMaGiamGiaTuDong(); ;
            this.cbbLoaiGG.ResetText();
            this.cbbMaHH.ResetText();
            this.txtDieuKien.ResetText();
            this.txtGiaTri.ResetText();
            this.dtpNgayHet.ResetText();

            this.txtMaGG.Enabled = true;
            this.cbbLoaiGG.Enabled = true;
            this.cbbMaHH.Enabled = true;
            this.txtDieuKien.Enabled = true;
            this.txtGiaTri.Enabled = true;
            this.dtpNgayHet.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaGG.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaGG.Enabled = false;
            this.cbbLoaiGG.Enabled = false;
            this.cbbMaHH.Enabled = false;
            this.txtDieuKien.Enabled = false;
            this.txtGiaTri.Enabled = false;
            this.dtpNgayHet.Enabled = false;

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gg.XoaGiamGia(txtMaGG.Text);
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string magg = txtMaGG.Text;
            string loaigg = cbbLoaiGG.SelectedItem.ToString();
            string mahh = cbbMaHH.SelectedItem.ToString();
            int giatri = Convert.ToInt32(txtGiaTri.Text);
            string ngayhet = dtpNgayHet.Value.ToShortDateString();
            int dieukien = Convert.ToInt32(txtDieuKien.Text);
            try
            {
                if (Them)
                {
                    string manql = FormDangNhap.nguoiDung.Id;
                    gg.ThemGiamGia(magg, loaigg, mahh, giatri, ngayhet, dieukien, manql);
                }
                else
                {
                    gg.CapNhatGiamGia(magg, loaigg, mahh, giatri, ngayhet, dieukien);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi");
                throw ex;
            }
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaGG.Enabled = false;
            this.cbbLoaiGG.Enabled = false;
            this.cbbMaHH.Enabled = false;
            this.txtDieuKien.Enabled = false;
            this.txtGiaTri.Enabled = false;
            this.dtpNgayHet.Enabled = false;
            LoadData();
        }
    }
}
