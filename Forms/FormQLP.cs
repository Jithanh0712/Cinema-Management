using RapChieuPhim.DTO;
using RapChieuPhim.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.Forms
{
    public partial class FormQLP : Form
    {
        public FormQLP()
        {
            InitializeComponent();
            txtMaPhim.ReadOnly = true;
            txtMaPhim.ResetText();
        }
        QuanLyPhim ph = new QuanLyPhim();
        QuanLyTheLoaiPhim TL = new QuanLyTheLoaiPhim();
        ThamGia TG = new ThamGia();
        void LoadData()
        {
            try
            {
                dgvQLP.DataSource = ph.LayDanhSachPhim();
                dgvQLP.AutoGenerateColumns = true;
                dgvQLP.AutoResizeColumns();
                this.txtMaPhim.ResetText();
                this.txtTenPhim.ResetText();
                this.txtDaoDien.ResetText();
                this.txtNhaSX.ResetText();
                this.txtNamSX.ResetText();
                this.cbbHinhThuc.ResetText();
                this.cbbDinhDang.ResetText();
                this.cbbXepLoai.ResetText();
                this.txtDoDai.ResetText();
                this.txtMoTa.ResetText();
                this.picHinhAnh.Image = null;
                this.txtTheLoai.ResetText();
                this.txtDVChinh.ResetText();

                this.txtMaPhim.Enabled = false;
                this.txtTenPhim.Enabled = false;
                this.txtDaoDien.Enabled = false;
                this.txtNhaSX.Enabled = false;
                this.txtNamSX.Enabled = false;
                this.cbbHinhThuc.Enabled = false;
                this.cbbDinhDang.Enabled = false;
                this.cbbXepLoai.Enabled = false;
                this.txtDoDai.Enabled = false;
                this.txtMoTa.Enabled = false;
                this.btnOpenFile.Enabled = false;
                this.txtTheLoai.Enabled = false;
                this.txtDVChinh.Enabled = false;
                this.txtDVPhu.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnHuy.Enabled = false;
                dgvQLP_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PHIM. Lỗi rồi!!!");
            }
        }

        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtMaPhim.Text = ph.TaoMaPhimTuDong();
            txtMaPhim.ReadOnly = true;

            this.txtTenPhim.ResetText();
            this.txtDaoDien.ResetText();
            this.txtNhaSX.ResetText();
            this.txtNamSX.ResetText();
            this.cbbHinhThuc.ResetText();
            this.cbbDinhDang.ResetText();
            this.cbbXepLoai.ResetText();
            this.txtDoDai.ResetText();
            this.txtMoTa.ResetText();
            this.picHinhAnh.Image = null;
            this.txtTheLoai.ResetText();
            this.txtDVChinh.ResetText();
            this.txtDVPhu.ResetText();

            this.txtMaPhim.Enabled = true;
            this.txtTenPhim.Enabled = true;
            this.txtDaoDien.Enabled = true;
            this.txtNhaSX.Enabled = true;
            this.txtNamSX.Enabled = true;
            this.cbbHinhThuc.Enabled = true;
            this.cbbDinhDang.Enabled = true;
            this.cbbXepLoai.Enabled = true;
            this.txtDoDai.Enabled = true;
            this.txtMoTa.Enabled = true;
            this.btnOpenFile.Enabled = true;
            this.txtTheLoai.Enabled = true;
            this.txtDVChinh.Enabled = true;
            this.txtDVPhu.Enabled = true;

            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            byte[] imageData;
            dlg.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            dlg.InitialDirectory = @"D:\";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        imageData = reader.ReadBytes((int)stream.Length);
                    }
                }
                picHinhAnh.Image = Image.FromFile(fileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvQLP.CurrentCell.RowIndex;
                string MaPhim = dgvQLP.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    ph.XoaPhim(MaPhim);
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

        private void FormQLP_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private Image ByteArrayToImage(byte[] HinhAnh)
        {
            if (HinhAnh == null)
            {
                return null;
            }
            MemoryStream stream = new MemoryStream(HinhAnh);
            return Image.FromStream(stream);
        }

        private void dgvQLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            if (dgvQLP.CurrentCell != null && dgvQLP.CurrentCell.RowIndex >= 0)
            {
                r = dgvQLP.CurrentCell.RowIndex;
                this.txtMaPhim.Text = dgvQLP.Rows[r].Cells[0].Value.ToString();
                this.txtTenPhim.Text = dgvQLP.Rows[r].Cells[1].Value.ToString();
                this.txtDaoDien.Text = dgvQLP.Rows[r].Cells[2].Value.ToString();
                this.txtNhaSX.Text = dgvQLP.Rows[r].Cells[3].Value.ToString();
                this.txtNamSX.Text = dgvQLP.Rows[r].Cells[4].Value.ToString();
                this.cbbHinhThuc.Text = dgvQLP.Rows[r].Cells[5].Value.ToString();
                this.cbbDinhDang.Text = dgvQLP.Rows[r].Cells[6].Value.ToString();
                this.cbbXepLoai.Text = dgvQLP.Rows[r].Cells[8].Value.ToString();
                this.txtDoDai.Text = dgvQLP.Rows[r].Cells[9].Value.ToString();
                this.txtMoTa.Text = dgvQLP.Rows[r].Cells[10].Value.ToString();
                this.picHinhAnh.Image = ByteArrayToImage(ph.GetImageByMaPhim(txtMaPhim.Text));
                picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dgvQLP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLP.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dgvQLP.SelectedRows[0];

                // Lấy giá trị từ các ô trong dòng được chọn
                string maphim = selectedRow.Cells["MaPhim"].Value.ToString(); // Thay "TenDVColumn" bằng tên thực sự của cột

                // Hiển thị giá trị lên các TextBox và PictureBox
                txtMaPhim.Text = maphim;
                string tenphim = selectedRow.Cells["TenPhim"].Value.ToString();
                txtTenPhim.Text = tenphim;
                string daodien = selectedRow.Cells["DaoDien"].Value.ToString();
                txtDaoDien.Text = daodien;
                string nhasx = selectedRow.Cells["NhaSX"].Value.ToString();
                txtNhaSX.Text = nhasx;
                string namsx = selectedRow.Cells["NamSX"].Value.ToString();
                txtNamSX.Text = namsx;
                string hinhthuc = selectedRow.Cells["HinhThuc"].Value.ToString();
                cbbHinhThuc.Text = hinhthuc;
                string dinhdang = selectedRow.Cells["DinhDang"].Value.ToString();
                cbbDinhDang.Text = dinhdang;
                string xeploai = selectedRow.Cells["XepLoai"].Value.ToString();
                cbbXepLoai.Text = xeploai;
                string dodai = selectedRow.Cells["DoDai"].Value.ToString();
                txtDoDai.Text = dodai;
                string mota = selectedRow.Cells["MoTa"].Value.ToString();
                txtMoTa.Text = mota;

                // Tương tự, nếu bạn có một cột hình ảnh, bạn có thể thay đổi PictureBox như sau:
                // pictureBox1.Image = (Image)selectedRow.Cells["AnhDVColumn"].Value; // Thay "AnhDVColumn" bằng tên thực sự của cột
                byte[] imageData = ph.GetImageByMaPhim(txtMaPhim.Text);
                if (imageData != null)
                {
                    picHinhAnh.Image = ByteArrayToImage(imageData);
                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    picHinhAnh.Image = null; // hoặc hiển thị một hình ảnh mặc định khác
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPhim = txtMaPhim.Text;
                string TenPhim = txtTenPhim.Text;
                string DaoDien = txtDaoDien.Text;
                string NhaSX = txtNhaSX.Text;
                string NamSX = txtNamSX.Text;
                string HinhThuc = cbbHinhThuc.Text;
                string DinhDang = cbbDinhDang.Text;
                string XepLoai = cbbXepLoai.Text;
                string DoDai = txtDoDai.Text;
                string MoTa = txtMoTa.Text;
                byte[] HinhAnh = ImageToByteArray(picHinhAnh.Image);
                string chuoitheloai = txtTheLoai.Text;
                List<string> TheLoai = chuoitheloai.Split(',').Select(x => x.Trim()).ToList();
                string chuoidvchinh = txtDVChinh.Text;
                List<string> DienVienChinh = chuoidvchinh.Split(',').Select(x => x.Trim()).ToList();
                string VaiTro = "Diễn Viên Chính";
                List<string> DienVienPhu = txtDVPhu.Text.Split(',').Select(x => x.Trim()).ToList();
                string dvphu = "Diễn Viên Phụ";
                if (picHinhAnh.Image == null)
                {
                    MessageBox.Show("Thiếu hình ảnh!");
                    return;
                }
                if(TheLoai.Count == 0)
                {
                    MessageBox.Show("Thiếu thể loại phim!");
                    return;
                }
                if (DienVienChinh.Count == 0)
                {
                    MessageBox.Show("Thiếu diễn viên chính!");
                    return;
                }
                if (DienVienPhu.Count == 0)
                {
                    MessageBox.Show("Thiếu diễn viên phụ!");
                    return;
                }

                DTO_Phim PH = new DTO_Phim(MaPhim, TenPhim, DaoDien, NhaSX, int.Parse(NamSX), HinhThuc, DinhDang, XepLoai, int.Parse(DoDai), MoTa, HinhAnh);
                if (ph.ThemPhim(PH))
                {
                    string MaDVC = "";
                    string MaDVP = "";
                    foreach (string theloai in TheLoai)
                    {
                        DTO_TheLoaiPhim tlp = new DTO_TheLoaiPhim(MaPhim, theloai);
                        TL.ThemTheLoai(tlp);
                    }
                    foreach (string tendvchinh in DienVienChinh)
                    {
                        QuanLyDienVien DV = new QuanLyDienVien();
                        string madvc = DV.LayMaDV(tendvchinh);
                        if (!string.IsNullOrEmpty(madvc.Trim()))
                        {
                            MaDVC = madvc;
                            DTO_ThamGia tg = new DTO_ThamGia(MaDVC, MaPhim, VaiTro);
                            TG.ThemThamGia(tg);
                        }
                        else
                        {
                            /// ngược lại là tạo mã dv tự động và cũng add vào tham gia sau đó
                            MaDVC = DV.TaoMaDVTuDong();
                            DTO_DienVien dv = new DTO_DienVien(MaDVC, tendvchinh);
                            DV.ThemDienVien(dv);
                            DTO_ThamGia tg = new DTO_ThamGia(MaDVC, MaPhim, VaiTro);
                            TG.ThemThamGia(tg);
                        }
                    }

                    foreach (string tendvphu in DienVienPhu)
                    {
                        QuanLyDienVien DV = new QuanLyDienVien();
                        string madvp = DV.LayMaDV(tendvphu);
                        if (!string.IsNullOrEmpty(madvp.Trim()))
                        {
                            MaDVP = madvp;
                            DTO_ThamGia tg = new DTO_ThamGia(MaDVP, MaPhim, dvphu);
                            TG.ThemThamGia(tg);
                        }
                        else
                        {
                            /// ngược lại là tạo mã dv tự động và cũng add vào tham gia sau đó
                            MaDVP = DV.TaoMaDVTuDong();
                            DTO_DienVien dv = new DTO_DienVien(MaDVP, tendvphu);
                            DV.ThemDienVien(dv);
                            DTO_ThamGia tg = new DTO_ThamGia(MaDVP, MaPhim, dvphu);
                            TG.ThemThamGia(tg);
                        }
                    }
                    MessageBox.Show("Thêm Phim Thành Công!!!");
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
            this.txtMaPhim.ResetText();
            this.txtTenPhim.ResetText();
            this.txtDaoDien.ResetText();
            this.txtNhaSX.ResetText();
            this.txtNamSX.ResetText();
            this.cbbHinhThuc.ResetText();
            this.cbbDinhDang.ResetText();
            this.cbbXepLoai.ResetText();
            this.txtDoDai.ResetText();
            this.txtMoTa.ResetText();
            this.picHinhAnh.Image = null;
            this.txtTheLoai.ResetText();
            this.txtDVChinh.ResetText();
            this.txtDVPhu.ResetText();
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;

            this.txtMaPhim.Enabled = false;
            this.txtTenPhim.Enabled = false;
            this.txtDaoDien.Enabled = false;
            this.txtNhaSX.Enabled = false;
            this.txtNamSX.Enabled = false;
            this.cbbHinhThuc.Enabled = false;
            this.cbbDinhDang.Enabled = false;
            this.cbbXepLoai.Enabled = false;
            this.txtDoDai.Enabled = false;
            this.txtMoTa.Enabled = false;
            this.btnOpenFile.Enabled = false;
            this.txtTheLoai.Enabled = false;
            this.txtDVChinh.Enabled = false;
            this.txtDVPhu.Enabled = false;
            LoadData();
        }
    }
}
