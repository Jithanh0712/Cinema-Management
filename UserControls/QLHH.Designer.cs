namespace RapChieuPhim.UserControls
{
    partial class QLHH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHH));
            dgvQLHH = new DataGridView();
            lblQLHH = new Label();
            lblMaHH = new Label();
            txtMaHH = new TextBox();
            txtTenHH = new TextBox();
            txtDonGia = new TextBox();
            txtSLTon = new TextBox();
            lblTenHH = new Label();
            lblDonGia = new Label();
            lblSLTon = new Label();
            lblNhaCC = new Label();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            cbbNhaCC = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvQLHH).BeginInit();
            SuspendLayout();
            // 
            // dgvQLHH
            // 
            dgvQLHH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLHH.Location = new Point(571, 0);
            dgvQLHH.Name = "dgvQLHH";
            dgvQLHH.RowHeadersWidth = 51;
            dgvQLHH.RowTemplate.Height = 29;
            dgvQLHH.Size = new Size(456, 767);
            dgvQLHH.TabIndex = 0;
            dgvQLHH.CellClick += dgvQLHH_CellClick;
            // 
            // lblQLHH
            // 
            lblQLHH.AutoSize = true;
            lblQLHH.BackColor = Color.Transparent;
            lblQLHH.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLHH.ForeColor = Color.Black;
            lblQLHH.Location = new Point(42, 159);
            lblQLHH.Name = "lblQLHH";
            lblQLHH.Size = new Size(329, 50);
            lblQLHH.TabIndex = 1;
            lblQLHH.Text = "Quản Lý Hàng Hóa";
            // 
            // lblMaHH
            // 
            lblMaHH.AutoSize = true;
            lblMaHH.BackColor = Color.Transparent;
            lblMaHH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHH.ForeColor = Color.Black;
            lblMaHH.Image = (Image)resources.GetObject("lblMaHH.Image");
            lblMaHH.ImageAlign = ContentAlignment.MiddleRight;
            lblMaHH.Location = new Point(39, 261);
            lblMaHH.Name = "lblMaHH";
            lblMaHH.Size = new Size(77, 28);
            lblMaHH.TabIndex = 2;
            lblMaHH.Text = "Mã HH:";
            // 
            // txtMaHH
            // 
            txtMaHH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHH.Location = new Point(136, 259);
            txtMaHH.Name = "txtMaHH";
            txtMaHH.Size = new Size(203, 30);
            txtMaHH.TabIndex = 3;
            // 
            // txtTenHH
            // 
            txtTenHH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenHH.Location = new Point(136, 322);
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(203, 30);
            txtTenHH.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(136, 380);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(203, 30);
            txtDonGia.TabIndex = 5;
            // 
            // txtSLTon
            // 
            txtSLTon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLTon.Location = new Point(136, 438);
            txtSLTon.Name = "txtSLTon";
            txtSLTon.Size = new Size(203, 30);
            txtSLTon.TabIndex = 6;
            // 
            // lblTenHH
            // 
            lblTenHH.AutoSize = true;
            lblTenHH.BackColor = Color.Transparent;
            lblTenHH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenHH.ForeColor = Color.Black;
            lblTenHH.Image = (Image)resources.GetObject("lblTenHH.Image");
            lblTenHH.ImageAlign = ContentAlignment.MiddleRight;
            lblTenHH.Location = new Point(38, 324);
            lblTenHH.Name = "lblTenHH";
            lblTenHH.Size = new Size(78, 28);
            lblTenHH.TabIndex = 8;
            lblTenHH.Text = "Tên HH:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.BackColor = Color.Transparent;
            lblDonGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.Black;
            lblDonGia.Image = (Image)resources.GetObject("lblDonGia.Image");
            lblDonGia.ImageAlign = ContentAlignment.MiddleRight;
            lblDonGia.Location = new Point(38, 382);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(87, 28);
            lblDonGia.TabIndex = 9;
            lblDonGia.Text = "Đơn Giá:";
            // 
            // lblSLTon
            // 
            lblSLTon.AutoSize = true;
            lblSLTon.BackColor = Color.Transparent;
            lblSLTon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLTon.ForeColor = Color.Black;
            lblSLTon.Image = (Image)resources.GetObject("lblSLTon.Image");
            lblSLTon.ImageAlign = ContentAlignment.MiddleRight;
            lblSLTon.Location = new Point(42, 436);
            lblSLTon.Name = "lblSLTon";
            lblSLTon.Size = new Size(74, 28);
            lblSLTon.TabIndex = 10;
            lblSLTon.Text = "SL Tồn:";
            // 
            // lblNhaCC
            // 
            lblNhaCC.AutoSize = true;
            lblNhaCC.BackColor = Color.Transparent;
            lblNhaCC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNhaCC.ForeColor = Color.Black;
            lblNhaCC.Image = (Image)resources.GetObject("lblNhaCC.Image");
            lblNhaCC.ImageAlign = ContentAlignment.MiddleRight;
            lblNhaCC.Location = new Point(42, 491);
            lblNhaCC.Name = "lblNhaCC";
            lblNhaCC.Size = new Size(80, 28);
            lblNhaCC.TabIndex = 11;
            lblNhaCC.Text = "Nhà CC:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 218, 220);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(60, 565);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 46);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(168, 218, 220);
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhat.ForeColor = SystemColors.ActiveCaptionText;
            btnCapNhat.Location = new Point(350, 565);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(136, 46);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(204, 565);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(136, 649);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 46);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = SystemColors.ActiveCaptionText;
            btnHuy.Location = new Point(269, 649);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(113, 46);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // cbbNhaCC
            // 
            cbbNhaCC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNhaCC.FormattingEnabled = true;
            cbbNhaCC.Location = new Point(136, 488);
            cbbNhaCC.Name = "cbbNhaCC";
            cbbNhaCC.Size = new Size(203, 31);
            cbbNhaCC.TabIndex = 17;
            // 
            // QLHH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(cbbNhaCC);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(lblNhaCC);
            Controls.Add(lblSLTon);
            Controls.Add(lblDonGia);
            Controls.Add(lblTenHH);
            Controls.Add(txtSLTon);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenHH);
            Controls.Add(txtMaHH);
            Controls.Add(lblMaHH);
            Controls.Add(lblQLHH);
            Controls.Add(dgvQLHH);
            Name = "QLHH";
            Size = new Size(1024, 767);
            Load += QLHH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLHH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLHH;
        private Label lblQLHH;
        private Label lblMaHH;
        private TextBox txtMaHH;
        private TextBox txtTenHH;
        private TextBox txtDonGia;
        private TextBox txtSLTon;
        private Label lblTenHH;
        private Label lblDonGia;
        private Label lblSLTon;
        private Label lblNhaCC;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private ComboBox cbbNhaCC;
    }
}
