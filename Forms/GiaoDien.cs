using RapChieuPhim.Forms;

namespace RapChieuPhim
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap form = new FormDangNhap();
            this.Visible = false;
            form.ShowDialog();
            if (FormDangNhap.nguoiDung != null && FormDangNhap.nguoiDung.PhanQuyen == "QuanLy")
            {
                FormQuanLy formQL = new FormQuanLy();
                formQL.ShowDialog();
                FormDangNhap.nguoiDung = null;
            }
            else if (FormDangNhap.nguoiDung != null && FormDangNhap.nguoiDung.PhanQuyen == "KhachHang")
            {
                FormKhachHang formKhachHang = new FormKhachHang();
                formKhachHang.ShowDialog();
                FormDangNhap.nguoiDung = null;
            }
            else if (FormDangNhap.nguoiDung != null && FormDangNhap.nguoiDung.PhanQuyen == "NhanVien")
            {
                FormNhanVien formnv = new FormNhanVien();
                formnv.ShowDialog();
                FormDangNhap.nguoiDung = null;
            }
            this.Visible = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy form = new FormDangKy();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}