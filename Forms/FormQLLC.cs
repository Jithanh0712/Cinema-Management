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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RapChieuPhim.Forms
{
    public partial class FormQLLC : Form
    {  
        public FormQLLC()
        {
            InitializeComponent();
        }
        QuanLyLichChieu lc = new QuanLyLichChieu();
        QuanLyPhongChieu pc = new QuanLyPhongChieu();
        QuanLyPhim ph = new QuanLyPhim();
        void LoadData()
        {
            try
            {
                dgvQLLC.DataSource = lc.LayDanhSachLichChieu();
                dgvQLLC.AutoGenerateColumns = true;
                dgvQLLC.AutoResizeColumns();
                this.cbbMaPhong.ResetText();
                this.cbbMaPhim.ResetText();
                this.dtpTGC.ResetText();
                this.dtpTGH.ResetText();
                this.cbbMaPhong.Enabled = false;
                this.cbbMaPhim.Enabled = false;
                this.dtpTGC.Enabled = false;
                this.dtpTGH.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnHuy.Enabled = false;
                dgvQLLC_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table LICHCHIEU. Lỗi rồi!!!");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.cbbMaPhong.ResetText();
            this.cbbMaPhim.ResetText();
            this.dtpTGC.ResetText();
            this.dtpTGH.ResetText();

            this.cbbMaPhong.Enabled = true;
            this.cbbMaPhim.Enabled = true;
            this.dtpTGC.Enabled = true;
            this.dtpTGH.Enabled = true;

            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLLC.CurrentCell.RowIndex;
                string MaLC = dgvQLLC.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    lc.XoaLichChieu(MaLC);
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

        private void dgvQLLC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLLC.CurrentCell != null && dgvQLLC.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLLC.CurrentCell.RowIndex;
                this.dtpTGC.Text = dgvQLLC.Rows[r].Cells[1].Value.ToString();
                this.dtpTGH.Text = dgvQLLC.Rows[r].Cells[2].Value.ToString();
                this.cbbMaPhong.Text = dgvQLLC.Rows[r].Cells[3].Value.ToString();
                this.cbbMaPhim.Text = dgvQLLC.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void FormQLLC_Load(object sender, EventArgs e)
        {
            LoadData();
            List<string> MaPhong = pc.LayTatCaMaPhong();
            List<string> MaPhim = ph.LayTatCaMaPhim();
            foreach (string value in MaPhong)
            {
                cbbMaPhong.Items.Add(value);
            }
            foreach (string value in MaPhim)
            {
                cbbMaPhim.Items.Add(value);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPhong = cbbMaPhong.Text;
                string MaPhim = cbbMaPhim.Text;
                DateTime ThoiGianChieu = dtpTGC.Value;
                DateTime ThoiGianHet = dtpTGH.Value;

                DTO_LichChieu LC = new DTO_LichChieu(ThoiGianChieu, ThoiGianHet, MaPhong, MaPhim);
                if (lc.ThemLichChieu(LC))
                {
                    MessageBox.Show("Thêm Lịch Chiếu Thành Công!!!");
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
            cbbMaPhong.ResetText();
            cbbMaPhim.ResetText();
            dtpTGC.ResetText();
            dtpTGH.ResetText();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;

            this.cbbMaPhong.Enabled = false;
            this.cbbMaPhim.Enabled = false;
            this.dtpTGC.Enabled = false;
            this.dtpTGH.Enabled = false;
            LoadData();
        }
    }
}
