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
    public partial class FormLichSuTT : Form
    {
        QLLichSuTT lstt;
        string id;
        string tempmahd;
        public FormLichSuTT()
        {
            InitializeComponent();
            lstt = new QLLichSuTT();
            this.id = FormDangNhap.nguoiDung.Id;
        }

        public void LoadData()
        {
            try
            {
                dgvLichSuTT.DataSource = lstt.getLichSuTT(id);
                dgvLichSuTT.AutoGenerateColumns = true;
                dgvLichSuTT.AutoResizeColumns();
                dgvLichSuTT_CellClick(null, null);
            }
            catch
            {
            }

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLichSuTT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string mahd = Convert.ToString(this.dgvLichSuTT.CurrentRow.Cells[0].Value);
            FormChiTietHD formChiTietHD = new FormChiTietHD(mahd);
            this.Visible = false;
            formChiTietHD.ShowDialog();
            this.Visible = true;
        }

        private void FormLichSuTT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLichSuTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvLichSuTT.CurrentCell != null && dgvLichSuTT.CurrentCell.RowIndex >= 0)
            {
                r = dgvLichSuTT.CurrentCell.RowIndex;
                dgvLichSuTT.Rows[r].Selected = true;
                tempmahd = Convert.ToString(dgvLichSuTT.Rows[r].Cells[0].Value);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietHD formChiTietHD = new FormChiTietHD(tempmahd);
            this.Visible = false;
            formChiTietHD.ShowDialog();
            this.Visible = true;
        }
    }
}
