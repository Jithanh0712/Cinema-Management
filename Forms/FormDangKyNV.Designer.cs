namespace RapChieuPhim.Forms
{
    partial class FormQLNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNV));
            dgvQLNV = new DataGridView();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtLuong = new TextBox();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblChucVu = new Label();
            lblLuong = new Label();
            cbbChucVu = new ComboBox();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            lblSDT = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtSDT = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            btnThemNV = new Button();
            btnXoaNV = new Button();
            btnCapNhatNV = new Button();
            btnLuu = new Button();
            lblQLNV = new Label();
            picQLNV = new PictureBox();
            cbbPhanQuyen = new ComboBox();
            lblPhanQuyen = new Label();
            lblMaTK = new Label();
            txtMaTK = new TextBox();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQLNV).BeginInit();
            SuspendLayout();
            // 
            // dgvQLNV
            // 
            dgvQLNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLNV.Location = new Point(29, 397);
            dgvQLNV.Name = "dgvQLNV";
            dgvQLNV.RowHeadersWidth = 51;
            dgvQLNV.RowTemplate.Height = 29;
            dgvQLNV.Size = new Size(1258, 363);
            dgvQLNV.TabIndex = 0;
            dgvQLNV.CellClick += dgvQLNV_CellClick;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNV.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaNV.Location = new Point(81, 135);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(93, 32);
            lblMaNV.TabIndex = 1;
            lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(208, 139);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(191, 30);
            txtMaNV.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(208, 250);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(191, 30);
            txtDiaChi.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(208, 195);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(191, 30);
            txtHoTen.TabIndex = 4;
            // 
            // txtLuong
            // 
            txtLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLuong.Location = new Point(208, 359);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(191, 30);
            txtLuong.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.FromArgb(241, 250, 238);
            lblHoTen.Location = new Point(81, 191);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(95, 32);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = Color.FromArgb(241, 250, 238);
            lblDiaChi.Location = new Point(81, 246);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(96, 32);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblChucVu.ForeColor = Color.FromArgb(241, 250, 238);
            lblChucVu.Location = new Point(81, 300);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(109, 32);
            lblChucVu.TabIndex = 9;
            lblChucVu.Text = "Chức Vụ:";
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLuong.ForeColor = Color.FromArgb(241, 250, 238);
            lblLuong.Location = new Point(81, 355);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(86, 32);
            lblLuong.TabIndex = 10;
            lblLuong.Text = "Lương:";
            // 
            // cbbChucVu
            // 
            cbbChucVu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Items.AddRange(new object[] { "BanThoiGian", "ToanThoiGian", "QuanLy", "ThoiVu" });
            cbbChucVu.Location = new Point(208, 304);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(191, 31);
            cbbChucVu.TabIndex = 11;
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNam.ForeColor = Color.FromArgb(241, 250, 238);
            rdbNam.Location = new Point(655, 137);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(86, 36);
            rdbNam.TabIndex = 12;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNu.ForeColor = Color.FromArgb(241, 250, 238);
            rdbNu.Location = new Point(779, 140);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(67, 36);
            rdbNu.TabIndex = 13;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nu";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGioiTinh.ForeColor = Color.FromArgb(241, 250, 238);
            lblGioiTinh.Location = new Point(493, 140);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(115, 32);
            lblGioiTinh.TabIndex = 14;
            lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.ForeColor = Color.FromArgb(241, 250, 238);
            lblNgaySinh.Location = new Point(486, 196);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(129, 32);
            lblNgaySinh.TabIndex = 15;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaiKhoan.ForeColor = Color.FromArgb(241, 250, 238);
            lblTaiKhoan.Location = new Point(493, 251);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(122, 32);
            lblTaiKhoan.TabIndex = 16;
            lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.ForeColor = Color.FromArgb(241, 250, 238);
            lblMatKhau.Location = new Point(493, 304);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(122, 32);
            lblMatKhau.TabIndex = 17;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.FromArgb(241, 250, 238);
            lblSDT.Location = new Point(547, 356);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(61, 32);
            lblSDT.TabIndex = 18;
            lblSDT.Text = "SDT:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(655, 255);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(191, 30);
            txtTaiKhoan.TabIndex = 19;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(655, 308);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(191, 30);
            txtMatKhau.TabIndex = 20;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(655, 360);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(191, 30);
            txtSDT.TabIndex = 21;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(655, 201);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(191, 30);
            dtpNgaySinh.TabIndex = 22;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.FromArgb(168, 218, 220);
            btnThemNV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNV.Location = new Point(1113, 234);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(162, 54);
            btnThemNV.TabIndex = 23;
            btnThemNV.Text = "Thêm ";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.FromArgb(168, 218, 220);
            btnXoaNV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNV.ForeColor = Color.Black;
            btnXoaNV.Location = new Point(1035, 308);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(118, 52);
            btnXoaNV.TabIndex = 24;
            btnXoaNV.Text = "Xóa ";
            btnXoaNV.UseVisualStyleBackColor = false;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // btnCapNhatNV
            // 
            btnCapNhatNV.BackColor = Color.FromArgb(168, 218, 220);
            btnCapNhatNV.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhatNV.Location = new Point(916, 234);
            btnCapNhatNV.Name = "btnCapNhatNV";
            btnCapNhatNV.Size = new Size(162, 54);
            btnCapNhatNV.TabIndex = 25;
            btnCapNhatNV.Text = "Cập nhật";
            btnCapNhatNV.UseVisualStyleBackColor = false;
            btnCapNhatNV.Click += btnCapNhatNV_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(884, 308);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 52);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // lblQLNV
            // 
            lblQLNV.AutoSize = true;
            lblQLNV.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLNV.ForeColor = Color.FromArgb(241, 250, 238);
            lblQLNV.Location = new Point(461, 26);
            lblQLNV.Name = "lblQLNV";
            lblQLNV.Size = new Size(542, 81);
            lblQLNV.TabIndex = 27;
            lblQLNV.Text = "Quản Lý Nhân Viên";
            // 
            // picQLNV
            // 
            picQLNV.Image = (Image)resources.GetObject("picQLNV.Image");
            picQLNV.Location = new Point(173, 11);
            picQLNV.Name = "picQLNV";
            picQLNV.Size = new Size(296, 121);
            picQLNV.SizeMode = PictureBoxSizeMode.Zoom;
            picQLNV.TabIndex = 28;
            picQLNV.TabStop = false;
            // 
            // cbbPhanQuyen
            // 
            cbbPhanQuyen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbPhanQuyen.FormattingEnabled = true;
            cbbPhanQuyen.Items.AddRange(new object[] { "NhanVien", "QuanLy" });
            cbbPhanQuyen.Location = new Point(1084, 122);
            cbbPhanQuyen.Name = "cbbPhanQuyen";
            cbbPhanQuyen.Size = new Size(191, 31);
            cbbPhanQuyen.TabIndex = 29;
            // 
            // lblPhanQuyen
            // 
            lblPhanQuyen.AutoSize = true;
            lblPhanQuyen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhanQuyen.ForeColor = Color.FromArgb(241, 250, 238);
            lblPhanQuyen.Location = new Point(928, 118);
            lblPhanQuyen.Name = "lblPhanQuyen";
            lblPhanQuyen.Size = new Size(150, 32);
            lblPhanQuyen.TabIndex = 30;
            lblPhanQuyen.Text = "Phân Quyền:";
            // 
            // lblMaTK
            // 
            lblMaTK.AutoSize = true;
            lblMaTK.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaTK.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaTK.Location = new Point(915, 176);
            lblMaTK.Name = "lblMaTK";
            lblMaTK.Size = new Size(163, 32);
            lblMaTK.TabIndex = 32;
            lblMaTK.Text = "Mã Tài Khoản:";
            // 
            // txtMaTK
            // 
            txtMaTK.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTK.Location = new Point(1084, 176);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(191, 30);
            txtMaTK.TabIndex = 33;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(1180, 308);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(118, 52);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormQLNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(1310, 784);
            Controls.Add(btnHuy);
            Controls.Add(txtMaTK);
            Controls.Add(lblMaTK);
            Controls.Add(lblPhanQuyen);
            Controls.Add(cbbPhanQuyen);
            Controls.Add(picQLNV);
            Controls.Add(lblQLNV);
            Controls.Add(btnLuu);
            Controls.Add(btnCapNhatNV);
            Controls.Add(btnXoaNV);
            Controls.Add(btnThemNV);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtSDT);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblSDT);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(cbbChucVu);
            Controls.Add(lblLuong);
            Controls.Add(lblChucVu);
            Controls.Add(lblDiaChi);
            Controls.Add(lblHoTen);
            Controls.Add(txtLuong);
            Controls.Add(txtHoTen);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMaNV);
            Controls.Add(lblMaNV);
            Controls.Add(dgvQLNV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormQLNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += FormQLNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQLNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLNV;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtLuong;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblChucVu;
        private Label lblLuong;
        private ComboBox cbbChucVu;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private Label lblSDT;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtSDT;
        private DateTimePicker dtpNgaySinh;
        private Button btnThemNV;
        private Button btnXoaNV;
        private Button btnCapNhatNV;
        private Button btnLuu;
        private Label lblQLNV;
        private PictureBox picQLNV;
        private ComboBox cbbPhanQuyen;
        private Label lblPhanQuyen;
        private Label lblMaTK;
        private TextBox txtMaTK;
        private Button btnHuy;
    }
}