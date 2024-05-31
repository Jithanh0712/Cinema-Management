namespace RapChieuPhim.Forms
{
    partial class FormQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKhachHang));
            lblQLKH = new Label();
            dgvQLKHg = new DataGridView();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            txtMaTaiKhoan = new TextBox();
            txtSDT = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblSDT = new Label();
            lblMaTaiKhoan = new Label();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            lblGioiTinh = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            pictureBox1 = new PictureBox();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLKHg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblQLKH
            // 
            lblQLKH.AutoSize = true;
            lblQLKH.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLKH.ForeColor = Color.FromArgb(241, 250, 238);
            lblQLKH.Location = new Point(510, 20);
            lblQLKH.Name = "lblQLKH";
            lblQLKH.Size = new Size(461, 62);
            lblQLKH.TabIndex = 28;
            lblQLKH.Text = "Quản Lý Khách Hàng";
            // 
            // dgvQLKHg
            // 
            dgvQLKHg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKHg.Location = new Point(22, 333);
            dgvQLKHg.Name = "dgvQLKHg";
            dgvQLKHg.RowHeadersWidth = 51;
            dgvQLKHg.RowTemplate.Height = 29;
            dgvQLKHg.Size = new Size(1032, 341);
            dgvQLKHg.TabIndex = 29;
            dgvQLKHg.CellClick += dgvQLKHg_CellClick;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKH.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaKH.Location = new Point(36, 103);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(75, 28);
            lblMaKH.TabIndex = 30;
            lblMaKH.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(134, 101);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(169, 30);
            txtMaKH.TabIndex = 31;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(134, 159);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(169, 30);
            txtHoTen.TabIndex = 32;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(134, 218);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(169, 30);
            txtDiaChi.TabIndex = 33;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTaiKhoan.Location = new Point(484, 214);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(169, 30);
            txtMaTaiKhoan.TabIndex = 34;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(484, 156);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(169, 30);
            txtSDT.TabIndex = 35;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(134, 280);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(169, 30);
            dtpNgaySinh.TabIndex = 36;
            dtpNgaySinh.Value = new DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNam.ForeColor = Color.FromArgb(241, 250, 238);
            rdbNam.Location = new Point(484, 280);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 32);
            rdbNam.TabIndex = 37;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNu.ForeColor = Color.FromArgb(241, 250, 238);
            rdbNu.Location = new Point(594, 280);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(59, 32);
            rdbNu.TabIndex = 38;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nu";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(813, 159);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(169, 30);
            txtMatKhau.TabIndex = 39;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(813, 101);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(169, 30);
            txtTaiKhoan.TabIndex = 40;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.FromArgb(241, 250, 238);
            lblHoTen.Location = new Point(33, 161);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 28);
            lblHoTen.TabIndex = 41;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = Color.FromArgb(241, 250, 238);
            lblDiaChi.Location = new Point(33, 220);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 42;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.ForeColor = Color.FromArgb(241, 250, 238);
            lblNgaySinh.Location = new Point(22, 280);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(106, 28);
            lblNgaySinh.TabIndex = 43;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.FromArgb(241, 250, 238);
            lblSDT.Location = new Point(397, 158);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(50, 28);
            lblSDT.TabIndex = 44;
            lblSDT.Text = "SDT:";
            // 
            // lblMaTaiKhoan
            // 
            lblMaTaiKhoan.AutoSize = true;
            lblMaTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaTaiKhoan.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaTaiKhoan.Location = new Point(325, 216);
            lblMaTaiKhoan.Name = "lblMaTaiKhoan";
            lblMaTaiKhoan.Size = new Size(133, 28);
            lblMaTaiKhoan.TabIndex = 45;
            lblMaTaiKhoan.Text = "Mã Tài Khoản:";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaiKhoan.ForeColor = Color.FromArgb(241, 250, 238);
            lblTaiKhoan.Location = new Point(694, 103);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(100, 28);
            lblTaiKhoan.TabIndex = 46;
            lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.ForeColor = Color.FromArgb(241, 250, 238);
            lblMatKhau.Location = new Point(694, 157);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(100, 28);
            lblMatKhau.TabIndex = 47;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGioiTinh.ForeColor = Color.FromArgb(241, 250, 238);
            lblGioiTinh.Location = new Point(353, 280);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(94, 28);
            lblGioiTinh.TabIndex = 48;
            lblGioiTinh.Text = "Giới Tính:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 218, 220);
            btnThem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ControlText;
            btnThem.Location = new Point(703, 214);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 48);
            btnThem.TabIndex = 49;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ControlText;
            btnLuu.Location = new Point(843, 279);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 48);
            btnLuu.TabIndex = 50;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ControlText;
            btnXoa.Location = new Point(703, 279);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 48);
            btnXoa.TabIndex = 51;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(168, 218, 220);
            btnSua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ControlText;
            btnSua.Location = new Point(843, 214);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 48);
            btnSua.TabIndex = 52;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = SystemColors.ControlText;
            btnHuy.Location = new Point(965, 240);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(102, 53);
            btnHuy.TabIndex = 54;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(1079, 695);
            Controls.Add(btnHuy);
            Controls.Add(pictureBox1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblMaTaiKhoan);
            Controls.Add(lblSDT);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblDiaChi);
            Controls.Add(lblHoTen);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtSDT);
            Controls.Add(txtMaTaiKhoan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaKH);
            Controls.Add(lblMaKH);
            Controls.Add(dgvQLKHg);
            Controls.Add(lblQLKH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQuanLyKhachHang";
            Text = "Quản Lý Khách Hàng";
            Load += FormQuanLyKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLKHg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQLKH;
        private DataGridView dgvQLKHg;
        private Label lblMaKH;
        private TextBox txtMaKH;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtMaTaiKhoan;
        private TextBox txtSDT;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblSDT;
        private Label lblMaTaiKhoan;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private Label lblGioiTinh;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private PictureBox pictureBox1;
        private Button btnHuy;
    }
}