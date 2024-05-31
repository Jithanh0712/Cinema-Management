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
    public partial class FormThanhToan : Form
    {
        ThanhToan thanhtoan = new ThanhToan();
        string maNV = "0";
        string maKH = "0";
        DataTable dt;
        string maHD = "";
        string maVe;
        string maGG = "0";
        public FormThanhToan(DataTable dt, string maKH, string maVe, string maGG)
        {
            InitializeComponent();
            string role = FormDangNhap.nguoiDung.PhanQuyen;
            if(role.Contains("KhachHang"))
            {
                lblHienMaNV.Text = maNV;
                this.dt = dt;
                this.maKH = maKH;
                txtMaKH.Text = maKH;
                txtMaKH.Enabled = false;
                this.maVe = maVe;
                this.maGG = maGG;
            }
            else
            {
                lblHienMaNV.Text = FormDangNhap.nguoiDung.Id;
                this.dt = dt;
                this.maNV = FormDangNhap.nguoiDung.Id;
                this.maKH = maKH;
                txtMaKH.Text = maKH;
                txtMaKH.Enabled = false;
                this.maVe = maVe;
                this.maGG = maGG;
            }
            
        }
        
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            maHD = thanhtoan.TaoMaHoaDonTuDong();
            DateTime thoiGian = DateTime.Now;
            float tongTien = Convert.ToSingle(txtTongHD.Text);
            string phuongThucTT;
            bool isSucc= false;
            bool check = false;
            if (cbbPTTT.SelectedItem == null)
            {
                phuongThucTT = "";
            }
            else
                phuongThucTT = cbbPTTT.SelectedItem.ToString();

            check = thanhtoan.ThemHoaDon(maHD, thoiGian, tongTien, phuongThucTT, maKH, maNV, maGG);
            if (check)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Loai"].ToString().Contains("Hàng hóa"))
                    {
                        isSucc = thanhtoan.ThemChiTietHD(maHD, dr["MaHH"].ToString(), Convert.ToInt32(dr["SL"]), Convert.ToSingle(dr["TongTien"]));
                    }
                    else if (dr["Loai"].ToString().Contains("Vé"))
                    {
                        thanhtoan.CapNhatMaHD(maVe, maHD);
                        isSucc = true;
                    }
                }
                if (isSucc)
                {
                    DialogResult d = MessageBox.Show("Thanh toan thanh cong!\nCó muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            float gia;
            string loaiVe;
            thanhtoan.LayThongTinVe(maVe, out loaiVe, out gia);
            if(maVe != "")
                dt.Rows.Add("Vé", maVe, loaiVe, 1, gia);

            dgvCTHD.DataSource = dt;

            float tong = CalculateTotalPrice();
            txtTongHD.Text = tong.ToString();
        }
        private float CalculateTotalPrice()
        {
            float total = 0;
            for (int i = 0; i < dgvCTHD.RowCount - 1; i++)
            {
                float tongTien = Convert.ToSingle(dgvCTHD.Rows[i].Cells[4].Value);
                total += tongTien;
            }
            return total;
        }

    }
}
