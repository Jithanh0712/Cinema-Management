namespace RapChieuPhim.Forms
{
    partial class FormQLP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLP));
            dgvQLP = new DataGridView();
            lblMaPhim = new Label();
            lblQLP = new Label();
            lblTenPhim = new Label();
            lblDaoDien = new Label();
            lblNhaSX = new Label();
            lblNamSX = new Label();
            lblHinhThuc = new Label();
            lblDinhDang = new Label();
            lblXepLoai = new Label();
            lblDoDai = new Label();
            lblMoTa = new Label();
            lblHinhAnh = new Label();
            lblDVChinh = new Label();
            lblTheLoai = new Label();
            btnXoa = new Button();
            txtMaPhim = new TextBox();
            txtTenPhim = new TextBox();
            txtDaoDien = new TextBox();
            txtNhaSX = new TextBox();
            txtNamSX = new TextBox();
            txtDoDai = new TextBox();
            txtMoTa = new TextBox();
            txtTheLoai = new TextBox();
            txtDVChinh = new TextBox();
            HinhAnh = new OpenFileDialog();
            btnOpenFile = new Button();
            picQLP = new PictureBox();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            lblDVPhu = new Label();
            txtDVPhu = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            cbbDinhDang = new ComboBox();
            cbbXepLoai = new ComboBox();
            cbbHinhThuc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvQLP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQLP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvQLP
            // 
            dgvQLP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLP.Location = new Point(15, 472);
            dgvQLP.Name = "dgvQLP";
            dgvQLP.RowHeadersWidth = 51;
            dgvQLP.RowTemplate.Height = 29;
            dgvQLP.Size = new Size(1219, 391);
            dgvQLP.TabIndex = 0;
            dgvQLP.CellClick += dgvQLP_CellClick;
            dgvQLP.SelectionChanged += dgvQLP_SelectionChanged;
            // 
            // lblMaPhim
            // 
            lblMaPhim.AutoSize = true;
            lblMaPhim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPhim.ForeColor = Color.Black;
            lblMaPhim.Location = new Point(45, 123);
            lblMaPhim.Name = "lblMaPhim";
            lblMaPhim.Size = new Size(114, 32);
            lblMaPhim.TabIndex = 1;
            lblMaPhim.Text = "Mã Phim:";
            // 
            // lblQLP
            // 
            lblQLP.AutoSize = true;
            lblQLP.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLP.ForeColor = Color.Black;
            lblQLP.Location = new Point(596, 9);
            lblQLP.Name = "lblQLP";
            lblQLP.Size = new Size(266, 54);
            lblQLP.TabIndex = 2;
            lblQLP.Text = "Quản Lý Phim";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenPhim.ForeColor = Color.Black;
            lblTenPhim.Location = new Point(41, 170);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(118, 32);
            lblTenPhim.TabIndex = 3;
            lblTenPhim.Text = "Tên Phim:";
            // 
            // lblDaoDien
            // 
            lblDaoDien.AutoSize = true;
            lblDaoDien.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaoDien.ForeColor = Color.Black;
            lblDaoDien.Location = new Point(41, 215);
            lblDaoDien.Name = "lblDaoDien";
            lblDaoDien.Size = new Size(119, 32);
            lblDaoDien.TabIndex = 4;
            lblDaoDien.Text = "Đạo Diễn:";
            // 
            // lblNhaSX
            // 
            lblNhaSX.AutoSize = true;
            lblNhaSX.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNhaSX.ForeColor = Color.Black;
            lblNhaSX.Location = new Point(41, 254);
            lblNhaSX.Name = "lblNhaSX";
            lblNhaSX.Size = new Size(97, 32);
            lblNhaSX.TabIndex = 5;
            lblNhaSX.Text = "Nhà SX:";
            // 
            // lblNamSX
            // 
            lblNamSX.AutoSize = true;
            lblNamSX.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNamSX.ForeColor = Color.Black;
            lblNamSX.Location = new Point(41, 299);
            lblNamSX.Name = "lblNamSX";
            lblNamSX.Size = new Size(104, 32);
            lblNamSX.TabIndex = 6;
            lblNamSX.Text = "Năm SX:";
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHinhThuc.ForeColor = Color.Black;
            lblHinhThuc.Location = new Point(41, 342);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(129, 32);
            lblHinhThuc.TabIndex = 7;
            lblHinhThuc.Text = "Hình Thức:";
            // 
            // lblDinhDang
            // 
            lblDinhDang.AutoSize = true;
            lblDinhDang.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDinhDang.ForeColor = Color.Black;
            lblDinhDang.Location = new Point(473, 119);
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(134, 32);
            lblDinhDang.TabIndex = 8;
            lblDinhDang.Text = "Định Dạng:";
            // 
            // lblXepLoai
            // 
            lblXepLoai.AutoSize = true;
            lblXepLoai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblXepLoai.ForeColor = Color.Black;
            lblXepLoai.Location = new Point(497, 166);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(110, 32);
            lblXepLoai.TabIndex = 10;
            lblXepLoai.Text = "Xếp Loại:";
            // 
            // lblDoDai
            // 
            lblDoDai.AutoSize = true;
            lblDoDai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoDai.ForeColor = Color.Black;
            lblDoDai.Location = new Point(510, 211);
            lblDoDai.Name = "lblDoDai";
            lblDoDai.Size = new Size(92, 32);
            lblDoDai.TabIndex = 11;
            lblDoDai.Text = "Độ Dài:";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(510, 254);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(87, 32);
            lblMoTa.TabIndex = 12;
            lblMoTa.Text = "Mô Tả:";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHinhAnh.ForeColor = Color.Black;
            lblHinhAnh.Location = new Point(477, 295);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(120, 32);
            lblHinhAnh.TabIndex = 13;
            lblHinhAnh.Text = "Hình Ảnh:";
            // 
            // lblDVChinh
            // 
            lblDVChinh.AutoSize = true;
            lblDVChinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDVChinh.ForeColor = Color.Black;
            lblDVChinh.Location = new Point(820, 202);
            lblDVChinh.Name = "lblDVChinh";
            lblDVChinh.Size = new Size(194, 32);
            lblDVChinh.TabIndex = 14;
            lblDVChinh.Text = "Diễn Viên Chính:";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTheLoai.ForeColor = Color.Black;
            lblTheLoai.Location = new Point(894, 118);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(109, 32);
            lblTheLoai.TabIndex = 15;
            lblTheLoai.Text = "Thể Loại:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(29, 53, 87);
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.FromArgb(241, 250, 238);
            btnXoa.Location = new Point(166, 402);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 40);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMaPhim
            // 
            txtMaPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPhim.Location = new Point(198, 127);
            txtMaPhim.Name = "txtMaPhim";
            txtMaPhim.Size = new Size(190, 30);
            txtMaPhim.TabIndex = 18;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenPhim.Location = new Point(198, 174);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(190, 30);
            txtTenPhim.TabIndex = 19;
            // 
            // txtDaoDien
            // 
            txtDaoDien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDaoDien.Location = new Point(198, 215);
            txtDaoDien.Name = "txtDaoDien";
            txtDaoDien.Size = new Size(190, 30);
            txtDaoDien.TabIndex = 20;
            // 
            // txtNhaSX
            // 
            txtNhaSX.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhaSX.Location = new Point(198, 258);
            txtNhaSX.Name = "txtNhaSX";
            txtNhaSX.Size = new Size(190, 30);
            txtNhaSX.TabIndex = 21;
            // 
            // txtNamSX
            // 
            txtNamSX.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSX.Location = new Point(198, 301);
            txtNamSX.Name = "txtNamSX";
            txtNamSX.Size = new Size(190, 30);
            txtNamSX.TabIndex = 22;
            // 
            // txtDoDai
            // 
            txtDoDai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoDai.Location = new Point(624, 215);
            txtDoDai.Name = "txtDoDai";
            txtDoDai.Size = new Size(190, 30);
            txtDoDai.TabIndex = 27;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Location = new Point(624, 258);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(190, 30);
            txtMoTa.TabIndex = 28;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheLoai.Location = new Point(1026, 118);
            txtTheLoai.Multiline = true;
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(190, 71);
            txtTheLoai.TabIndex = 29;
            // 
            // txtDVChinh
            // 
            txtDVChinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDVChinh.Location = new Point(1026, 202);
            txtDVChinh.Multiline = true;
            txtDVChinh.Name = "txtDVChinh";
            txtDVChinh.Size = new Size(190, 96);
            txtDVChinh.TabIndex = 30;
            // 
            // HinhAnh
            // 
            HinhAnh.FileName = "HinhAnh";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(29, 53, 87);
            btnOpenFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFile.ForeColor = Color.FromArgb(241, 250, 238);
            btnOpenFile.Location = new Point(926, 414);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(190, 52);
            btnOpenFile.TabIndex = 31;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // picQLP
            // 
            picQLP.Image = (Image)resources.GetObject("picQLP.Image");
            picQLP.Location = new Point(423, -9);
            picQLP.Name = "picQLP";
            picQLP.Size = new Size(167, 120);
            picQLP.SizeMode = PictureBoxSizeMode.StretchImage;
            picQLP.TabIndex = 32;
            picQLP.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(29, 53, 87);
            btnThem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.FromArgb(241, 250, 238);
            btnThem.Location = new Point(32, 402);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 40);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(624, 295);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(190, 176);
            picHinhAnh.TabIndex = 33;
            picHinhAnh.TabStop = false;
            // 
            // lblDVPhu
            // 
            lblDVPhu.AutoSize = true;
            lblDVPhu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDVPhu.ForeColor = Color.Black;
            lblDVPhu.Location = new Point(831, 329);
            lblDVPhu.Name = "lblDVPhu";
            lblDVPhu.Size = new Size(172, 32);
            lblDVPhu.TabIndex = 34;
            lblDVPhu.Text = "Diễn Viên Phụ:";
            // 
            // txtDVPhu
            // 
            txtDVPhu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDVPhu.Location = new Point(1026, 312);
            txtDVPhu.Multiline = true;
            txtDVPhu.Name = "txtDVPhu";
            txtDVPhu.Size = new Size(190, 96);
            txtDVPhu.TabIndex = 35;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(29, 53, 87);
            btnLuu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.FromArgb(241, 250, 238);
            btnLuu.Location = new Point(304, 402);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 40);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(29, 53, 87);
            btnHuy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.FromArgb(241, 250, 238);
            btnHuy.Location = new Point(439, 402);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 40);
            btnHuy.TabIndex = 37;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // cbbDinhDang
            // 
            cbbDinhDang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbDinhDang.FormattingEnabled = true;
            cbbDinhDang.Items.AddRange(new object[] { "2D", "3D" });
            cbbDinhDang.Location = new Point(624, 119);
            cbbDinhDang.Name = "cbbDinhDang";
            cbbDinhDang.Size = new Size(190, 31);
            cbbDinhDang.TabIndex = 38;
            // 
            // cbbXepLoai
            // 
            cbbXepLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbXepLoai.FormattingEnabled = true;
            cbbXepLoai.Items.AddRange(new object[] { "PG", "U", "12A", "12", "15", "18", "R18" });
            cbbXepLoai.Location = new Point(624, 171);
            cbbXepLoai.Name = "cbbXepLoai";
            cbbXepLoai.Size = new Size(190, 31);
            cbbXepLoai.TabIndex = 39;
            // 
            // cbbHinhThuc
            // 
            cbbHinhThuc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbHinhThuc.FormattingEnabled = true;
            cbbHinhThuc.Items.AddRange(new object[] { "Lồng tiếng", "Phụ đề" });
            cbbHinhThuc.Location = new Point(198, 346);
            cbbHinhThuc.Name = "cbbHinhThuc";
            cbbHinhThuc.Size = new Size(190, 31);
            cbbHinhThuc.TabIndex = 40;
            // 
            // FormQLP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 218, 220);
            ClientSize = new Size(1252, 874);
            Controls.Add(cbbHinhThuc);
            Controls.Add(cbbXepLoai);
            Controls.Add(cbbDinhDang);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDVPhu);
            Controls.Add(lblDVPhu);
            Controls.Add(picHinhAnh);
            Controls.Add(picQLP);
            Controls.Add(btnOpenFile);
            Controls.Add(txtDVChinh);
            Controls.Add(txtTheLoai);
            Controls.Add(txtMoTa);
            Controls.Add(txtDoDai);
            Controls.Add(txtNamSX);
            Controls.Add(txtNhaSX);
            Controls.Add(txtDaoDien);
            Controls.Add(txtTenPhim);
            Controls.Add(txtMaPhim);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(lblTheLoai);
            Controls.Add(lblDVChinh);
            Controls.Add(lblHinhAnh);
            Controls.Add(lblMoTa);
            Controls.Add(lblDoDai);
            Controls.Add(lblXepLoai);
            Controls.Add(lblDinhDang);
            Controls.Add(lblHinhThuc);
            Controls.Add(lblNamSX);
            Controls.Add(lblNhaSX);
            Controls.Add(lblDaoDien);
            Controls.Add(lblTenPhim);
            Controls.Add(lblQLP);
            Controls.Add(lblMaPhim);
            Controls.Add(dgvQLP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQLP";
            Text = "Quản Lý Phim";
            Load += FormQLP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQLP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLP;
        private Label lblMaPhim;
        private Label lblQLP;
        private Label lblTenPhim;
        private Label lblDaoDien;
        private Label lblNhaSX;
        private Label lblNamSX;
        private Label lblHinhThuc;
        private Label lblDinhDang;
        private Label lblXepLoai;
        private Label lblDoDai;
        private Label lblMoTa;
        private Label lblHinhAnh;
        private Label lblDVChinh;
        private Label lblTheLoai;
        private Button btnXoa;
        private TextBox txtMaPhim;
        private TextBox txtTenPhim;
        private TextBox txtDaoDien;
        private TextBox txtNhaSX;
        private TextBox txtNamSX;
        private TextBox txtDoDai;
        private TextBox txtMoTa;
        private TextBox txtTheLoai;
        private TextBox txtDVChinh;
        private OpenFileDialog HinhAnh;
        private Button btnOpenFile;
        private PictureBox picQLP;
        private Button btnThem;
        private PictureBox picHinhAnh;
        private Label lblDVPhu;
        private TextBox txtDVPhu;
        private Button btnLuu;
        private Button btnHuy;
        private ComboBox cbbDinhDang;
        private ComboBox cbbXepLoai;
        private ComboBox cbbHinhThuc;
    }
}