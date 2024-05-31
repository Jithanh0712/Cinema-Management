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
    public partial class FormQLPhongChieu : Form
    {
        QuanLyPhongChieu qlpc;
        DataTable dt;
        bool isThem;
        public FormQLPhongChieu()
        {
            InitializeComponent();
            qlpc = new QuanLyPhongChieu();
            dt = new DataTable();
            isThem = false;
        }

        private void LoadData()
        {
            try
            {
                dt = qlpc.LayTatCaPhongChieu();
                dgvPhongChieu.DataSource = dt;
                dgvPhongChieu.AutoGenerateColumns = true;
                dgvPhongChieu.AutoResizeColumns();

                this.txtMaPC.ResetText();
                this.txtSLDoi.ResetText();
                this.txtSLThuong.ResetText();
                this.txtSLVIP.ResetText();

                this.txtMaPC.Enabled = false;
                this.txtSLDoi.Enabled = false;
                this.txtSLThuong.Enabled = false;
                this.txtSLVIP.Enabled = false;

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                dgvPhongChieu_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PHONGCHIEU. Lỗi rồi!!!");
            }
        }

        private void FormQLPhongChieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;

            this.txtMaPC.Text = qlpc.TaoMaPhongChieuTuDong();
            this.txtSLDoi.ResetText();
            this.txtSLThuong.ResetText();
            this.txtSLVIP.ResetText();

            this.txtSLDoi.Enabled = true;
            this.txtSLThuong.Enabled = true;
            this.txtSLVIP.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isThem = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;

            this.txtSLDoi.Enabled = true;
            this.txtSLThuong.Enabled = true;
            this.txtSLVIP.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckConstraints())
            {
                int slvip = Convert.ToInt32(txtSLVIP.Text);
                int slthuong = Convert.ToInt32(txtSLThuong.Text);
                int sldoi = Convert.ToInt32(txtSLDoi.Text);
                try
                {
                    if (isThem)
                    {
                        qlpc.ThemPhongChieu(txtMaPC.Text, slvip, slthuong, sldoi);
                    }
                    else
                    {
                        qlpc.CapNhatPhongChieu(txtMaPC.Text, slvip, slthuong, sldoi);
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

                this.txtSLDoi.Enabled = false;
                this.txtSLThuong.Enabled = false;
                this.txtSLVIP.Enabled = false;

                LoadData();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvPhongChieu.CurrentCell != null && dgvPhongChieu.CurrentCell.RowIndex >= 0)
            {
                r = dgvPhongChieu.CurrentCell.RowIndex;
                this.txtMaPC.Text = dgvPhongChieu.Rows[r].Cells[0].Value.ToString();
                this.txtSLVIP.Text = dgvPhongChieu.Rows[r].Cells[1].Value.ToString();
                this.txtSLThuong.Text = dgvPhongChieu.Rows[r].Cells[2].Value.ToString();
                this.txtSLDoi.Text = dgvPhongChieu.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;

            this.txtSLDoi.Enabled = false;
            this.txtSLThuong.Enabled = false;
            this.txtSLVIP.Enabled = false;
            LoadData();
        }

        private bool CheckConstraints()
        {
            int slvip = Convert.ToInt32(txtSLVIP.Text);
            int slthuong = Convert.ToInt32(txtSLThuong.Text);
            int sldoi = Convert.ToInt32(txtSLDoi.Text);
            if (slvip <= 0 || slvip % 6 != 0)
            {
                MessageBox.Show("So luong ghe VIP sai quy dinh(so luong ghe > 0 va chia het cho 6)");
                txtSLVIP.ResetText();
                return false;
            }
            if (slthuong <= 0 || slthuong % 5 != 0)
            {
                MessageBox.Show("So luong ghe thuong sai quy dinh(so luong ghe > 0 va chia het cho 5)");
                txtSLThuong.ResetText();
                return false;
            }
            if (sldoi <= 0)
            {
                MessageBox.Show("So luong ghe doi sai quy dinh(so luong ghe > 0)");
                txtSLDoi.ResetText();
                return false;
            }
            if (slvip * 5 / 6 != slthuong)
            {
                MessageBox.Show("So luong ghe VIP va ghe thuong sai quy dinh(so luong ghe thuong = so luong ghe VIP * 5/6)");
                txtSLVIP.ResetText();
                txtSLThuong.ResetText();
                return false;
            }
            if (sldoi > slvip / 12)
            {
                MessageBox.Show("So luong ghe VIP va ghe doi sai quy dinh(so luong ghe doi <= so luong ghe VIP / 12)");
                txtSLVIP.ResetText();
                txtSLDoi.ResetText();
                return false;
            }
            return true;
        }
    }
}
