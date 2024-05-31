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
    public partial class FormBanHang : Form
    {
        List<float> tempTotalPrice;
        bool Them;
        string maVe;
        string maHH = "";
        float tamTinh = 0;
        bool flag = false;
        bool isChange = false;
        BanHang banhang = new BanHang();
        QuanLyHangHoa qlHH;
        DataTable dtCTHH = new DataTable();
        DataTable dtThanhToan = new DataTable();
        public FormBanHang()
        {
            InitializeComponent();
            this.maVe = "";
            tempTotalPrice = new List<float>();
            qlHH = new QuanLyHangHoa();
            txtMaKH.Enabled = true;
            cbbDSHH.Enabled = false;
            nudSL.Enabled = false;
            btnLuu.Enabled = false;
            this.lblMaNV.Text = FormDangNhap.nguoiDung.Id;
            hienThiDSHangHoa();
        }

        public FormBanHang(string maVe)
        {
            InitializeComponent();
            this.maVe = maVe;
            tempTotalPrice = new List<float>();
            qlHH = new QuanLyHangHoa();
            txtMaKH.Enabled = true;
            cbbDSHH.Enabled = false;
            nudSL.Enabled = false;
            btnLuu.Enabled = false;
            this.lblMaNV.Text = FormDangNhap.nguoiDung.Id;
            hienThiDSHangHoa();
        }

        public FormBanHang(DataTable dtThanhToan, string maVe)
        {
            InitializeComponent();
            this.maVe = maVe;
            tempTotalPrice = new List<float>();
            qlHH = new QuanLyHangHoa();
            txtMaKH.Text = FormDangNhap.nguoiDung.Id;
            cbbDSHH.Visible = false;
            nudSL.Visible = false;
            btnLuu.Enabled = false;
            DataTable dtHH = new DataTable();
            dtHH = banhang.LayTTHHBapNuoc(dtThanhToan);
            this.dtThanhToan = dtHH;
            this.lblMaNV.Visible = false;
            lblMaHH.Visible = false;
            lblSL.Visible = false;
            btnCapnhat.Visible = false;
            btnThemSP.Visible = false;
            btnXoa.Visible=false;
            btnLuu.Visible = false;
            foreach (DataRow dr in dtHH.Rows)
            {
                maHH = dr["MaHH"].ToString();
                string tenHH = dr["TenHH"].ToString();
                int SL = Convert.ToInt32(dr["SL"]);
                float tongTien = Convert.ToSingle(dr["TongTien"]);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDSHH);
                row.Cells[0].Value = maHH;
                row.Cells[1].Value = tenHH;
                row.Cells[2].Value = SL;
                row.Cells[3].Value = tongTien;
                dgvDSHH.Rows.Add(row);
                tempTotalPrice.Add(tongTien);
            }
            
            lblTamTinh.Text = tamTinh.ToString();
            //hienThiDSHangHoa();
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataTable dtThanhToan = new DataTable();

            dtThanhToan.Columns.Add("Loai", typeof(string));
            dtThanhToan.Columns.Add("MaHH", typeof(string));
            dtThanhToan.Columns.Add("TenHH", typeof(string));
            dtThanhToan.Columns.Add("SL", typeof(int));
            dtThanhToan.Columns.Add("TongTien", typeof(float));
            string maGG;
            if (isChange)
            {
                maGG = cbbMaGG.SelectedItem.ToString();
            }
            else
                maGG = "0";
            string maKH = txtMaKH.Text;
            if(txtMaKH.Text == "")
                maKH = "0";
            if (dgvDSHH.RowCount > 0)

            {
                for (int i = 0; i < dgvDSHH.RowCount-1; i++)
                {
                    string maHH = Convert.ToString(dgvDSHH.Rows[i].Cells[0].Value);
                    string tenHH = Convert.ToString(dgvDSHH.Rows[i].Cells[1].Value);
                    int soLuong = Convert.ToInt32(dgvDSHH.Rows[i].Cells[2].Value);
                    float tongTien = Convert.ToSingle(dgvDSHH.Rows[i].Cells[3].Value);
                    dtThanhToan.Rows.Add("Hàng hóa", maHH, tenHH,soLuong, tongTien);
                }
            }
            FormThanhToan formThanhToan = new FormThanhToan(dtThanhToan, maKH, maVe, maGG);
            this.Visible = false;
            formThanhToan.ShowDialog();
            this.Visible = true;
        }
        private void hienThiDSHangHoa()
        {
            dtCTHH = qlHH.LayDanhSachHangHoa();
            cbbDSHH.DataSource = dtCTHH;
            cbbDSHH.ValueMember = "TenHH";
        }
        private void dgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSHH != null && dgvDSHH.RowCount > 0)
            {
                int r = dgvDSHH.CurrentCell.RowIndex;

                if (dgvDSHH.Rows[r] != null && dgvDSHH.Rows[r].Cells[2].Value != null)
                {
                    this.nudSL.Text = dgvDSHH.Rows[r].Cells[2].Value.ToString();
                }
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            Them = true;
            nudSL.Enabled = true;
            nudSL.Value = 0;
            cbbDSHH.Enabled = true;
            btnThemSP.Enabled = false;
            btnXoa.Enabled = false;
            btnCapnhat.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            Them = false;
            btnThemSP.Enabled = false;
            cbbDSHH.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaKH.ReadOnly = true;
            nudSL.Enabled = true;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (cbbDSHH.SelectedItem != null)
                    {
                        maHH = dtCTHH.Rows[cbbDSHH.SelectedIndex][0].ToString();
                    }
                    maHH = maHH.Trim();
                    tamTinh = 0;
                    string tenHH;
                    float donGia;
                    banhang.LayThongTinHangHoa(maHH, out tenHH, out donGia);
                    int SL = Convert.ToInt32(nudSL.Value);

                    float tongTien = donGia * SL;
                    if (SL==0)
                    {
                        MessageBox.Show("So luong khong duoc bang 0");
                    }
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvDSHH);
                        row.Cells[0].Value = maHH;
                        row.Cells[1].Value = tenHH;
                        row.Cells[2].Value = SL;
                        row.Cells[3].Value = tongTien;
                        dgvDSHH.Rows.Add(row);
                        tempTotalPrice.Add(tongTien);

                        for (int i = 0; i < dgvDSHH.RowCount - 1; i++)
                        {
                            tamTinh += Convert.ToSingle(dgvDSHH.Rows[i].Cells[3].Value);
                        }
                        lblTamTinh.Text = tamTinh.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi");
                    throw ex;
                }
                btnCapnhat.Enabled = true;
                btnXoa.Enabled = true;
                btnThemSP.Enabled = true;
                btnLuu.Enabled = false;
                txtMaKH.Enabled = false;
                nudSL.Enabled = false;
                cbbDSHH.Enabled = false;
            }
            else
            {
                try
                {
                    maHH.Trim();
                    string tenHH;
                    float donGia;
                    tamTinh = 0;
                    banhang.LayThongTinHangHoa(maHH, out tenHH, out donGia);

                    int SL = Convert.ToInt32(nudSL.Value);

                    float tongTien = donGia * SL;


                    int r;
                    if (dgvDSHH.CurrentCell != null && dgvDSHH.CurrentCell.RowIndex >= 0)
                    {
                        r = dgvDSHH.CurrentCell.RowIndex;
                        dgvDSHH.Rows[r].Cells[1].Value = tenHH;
                        dgvDSHH.Rows[r].Cells[2].Value = SL;
                        dgvDSHH.Rows[r].Cells[3].Value = tongTien;
                    }
                    for (int i = 0; i < dgvDSHH.RowCount - 1; i++)
                    {
                        tamTinh += Convert.ToSingle(dgvDSHH.Rows[i].Cells[3].Value);
                    }
                    lblTamTinh.Text = tamTinh.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi");
                    throw ex;
                }

                btnCapnhat.Enabled = true;
                btnXoa.Enabled = true;
                btnThemSP.Enabled = true;
                btnLuu.Enabled = false;
                txtMaKH.Enabled = false;
                nudSL.Enabled = false;
                cbbDSHH.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvDSHH.CurrentCell.RowIndex;
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    tamTinh = 0;
                    dgvDSHH.Rows.RemoveAt(r);
                    CalculateTotalPrice();
                    lblTamTinh.Text = tamTinh.ToString();
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

        private void cbbMaGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!flag)
            {
                flag = true;
            }
            else
            {
                if (cbbMaGG.SelectedItem != null)
                {
                    isChange = true;
                    ReCountTotalPrice();
                    string maGG = cbbMaGG.SelectedItem.ToString();
                    string maHH;
                    int giaTri;
                    string loaiGG;
                    banhang.LayMaHHTheoGG(maGG, out maHH, out giaTri, out loaiGG);
                    bool maGGPhuHop = false;
                    int i;
                    for (i = 0; i < dgvDSHH.RowCount-1; i++)
                    {
                        if (dgvDSHH.Rows[i].Cells[0].Value != null && dgvDSHH.Rows[i].Cells[0].Value.ToString() == maHH.Trim())
                        {
                            maGGPhuHop = true;
                            break;
                        }
                    }
                    
                    if (maGGPhuHop)
                    {
                        float tong = Convert.ToSingle(dgvDSHH.Rows[i].Cells[3].Value);
                        float tongTien = tong * (1 - giaTri / 100f);
                        if (loaiGG == "V1") // Mua 1 tặng 1
                        {
                            int sl = Int32.Parse(dgvDSHH.Rows[i].Cells[2].Value.ToString());
                            string tenHH;
                            float donGia;
                            tamTinh = 0;
                            banhang.LayThongTinHangHoa(maHH, out tenHH, out donGia);
                            tongTien = (sl - 1) * donGia;
                            MessageBox.Show("Áp dụng mã giảm giá " + maGG.Trim() + " được tặng 1 hàng hóa " + maHH + "");
                        }
                        else
                        {
                            MessageBox.Show("Áp dụng mã giảm giá  " + maGG.Trim() + " giảm " + giaTri + "% cho hàng hóa " + maHH + "");
                        }
                        dgvDSHH.Rows[i].Cells[3].Value = tongTien;

                        tamTinh = CalculateTotalPrice();
                        lblTamTinh.Text = tamTinh.ToString();
                    }
                    if (maGGPhuHop == false)
                    {
                        isChange = false;
                        MessageBox.Show("Mã giảm giá không phù hợp");
                    }
                }
            }
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            flag = false;
            if(txtMaKH.Enabled == true)
            {
                txtMaKH.Focus();
                btnXacNhan.BackColor = Color.Green;
                txtMaKH.Enabled = false;
                string maKH = txtMaKH.Text;
                List<string> list = new List<string>();
                if(maKH != null)
                {
                    list.AddRange(banhang.LayMaGG(maKH));
                    list.AddRange(banhang.LayMaGGDK0());
                }
                else
                {
                    list.AddRange(banhang.LayMaGGDK0());
                }
                cbbMaGG.DataSource = list;
            }
            else
            {
                cbbMaGG.Text = "Mã giảm giá";
                btnXacNhan.BackColor = Color.Red;
                txtMaKH.Enabled = true;
            }
        }
        private float CalculateTotalPrice()
        {
            float total = 0;
            for (int i = 0; i < dgvDSHH.RowCount - 1; i++)
            {
                float tongTien = Convert.ToSingle(dgvDSHH.Rows[i].Cells[3].Value);
                total += tongTien;
            }
            return total;
        }
        private void ReCountTotalPrice()
        {
            for(int i = 0; i < dgvDSHH.RowCount - 1; i++)
            {
                dgvDSHH.Rows[i].Cells[3].Value = tempTotalPrice[i];
            }
            tamTinh = CalculateTotalPrice();
            lblTamTinh.Text = tamTinh.ToString();
        }
    }
}
