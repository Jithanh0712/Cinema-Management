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
    public partial class FormChiTietHD : Form
    {
        QLLichSuTT lstt;
        string mahd;
        DataTable dtchitiet;
        DataTable dt;
        public FormChiTietHD(string mahd)
        {
            InitializeComponent();
            lstt = new QLLichSuTT();
            dtchitiet = new DataTable();
            dt = new DataTable();
            this.mahd = mahd;
        }

        public void LoadData()
        {
            try
            {
                dtchitiet = lstt.getChiTietHD(mahd);
                txtMaHD.Text = mahd;
                txtThoiGianThanhToan.Text = Convert.ToString(dtchitiet.Rows[0][0]);
                txtPhuongThucThanhToan.Text = Convert.ToString(dtchitiet.Rows[0][2]);
                txtTongTien.Text = Convert.ToString(dtchitiet.Rows[0][1]);

                string id = FormDangNhap.nguoiDung.Id;
                if (id.Contains("KH"))
                {
                    dt = lstt.getDiemTL(id);
                    txtDiemSauThanhToan.Text = Convert.ToString(dt.Rows[0][0]);
                    int diemcong = Convert.ToInt32(txtTongTien.Text) / 1000;
                    int diemtruocthanhtoan = Convert.ToInt32(txtDiemSauThanhToan.Text) - diemcong;
                    txtDiemTruocThanhToan.Text = Convert.ToString(diemtruocthanhtoan);
                }
                else
                {
                    lblDiemTruocThanhToan.Visible = false;
                    lblDiemSauThanhToan.Visible = false;
                    txtDiemTruocThanhToan.Visible = false;
                    txtDiemSauThanhToan.Visible = false;
                }

                dgvChiTietHD.DataSource = lstt.getChiTiet(mahd);
                dgvChiTietHD.AutoGenerateColumns = true;
                dgvChiTietHD.AutoResizeColumns();
            }
            catch
            {
            }

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
