namespace RapChieuPhim.UserControls
{
    partial class NhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCC));
            dgvQLNCC = new DataGridView();
            picNCC = new PictureBox();
            lblNCC = new Label();
            lblMaNCC = new Label();
            btnThem = new Button();
            txtMaNCC = new TextBox();
            lblTenNCC = new Label();
            lblDiaChi = new Label();
            lblSDT = new Label();
            txtTenNCC = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLNCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNCC).BeginInit();
            SuspendLayout();
            // 
            // dgvQLNCC
            // 
            dgvQLNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLNCC.Location = new Point(0, -3);
            dgvQLNCC.Name = "dgvQLNCC";
            dgvQLNCC.RowHeadersWidth = 51;
            dgvQLNCC.RowTemplate.Height = 29;
            dgvQLNCC.Size = new Size(496, 770);
            dgvQLNCC.TabIndex = 0;
            dgvQLNCC.CellClick += dgvQLNCC_CellClick;
            // 
            // picNCC
            // 
            picNCC.Image = (Image)resources.GetObject("picNCC.Image");
            picNCC.Location = new Point(494, 0);
            picNCC.Name = "picNCC";
            picNCC.Size = new Size(541, 461);
            picNCC.SizeMode = PictureBoxSizeMode.StretchImage;
            picNCC.TabIndex = 2;
            picNCC.TabStop = false;
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.BackColor = Color.FromArgb(218, 187, 140);
            lblNCC.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblNCC.ForeColor = Color.FromArgb(116, 69, 37);
            lblNCC.Location = new Point(513, 383);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(501, 60);
            lblNCC.TabIndex = 3;
            lblNCC.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // lblMaNCC
            // 
            lblMaNCC.AutoSize = true;
            lblMaNCC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNCC.ForeColor = Color.FromArgb(116, 69, 37);
            lblMaNCC.Location = new Point(597, 477);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(102, 31);
            lblMaNCC.TabIndex = 4;
            lblMaNCC.Text = "Mã NCC:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 218, 220);
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(513, 684);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 57);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNCC.Location = new Point(700, 477);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(250, 38);
            txtMaNCC.TabIndex = 6;
            // 
            // lblTenNCC
            // 
            lblTenNCC.AutoSize = true;
            lblTenNCC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNCC.ForeColor = Color.FromArgb(116, 69, 37);
            lblTenNCC.Location = new Point(596, 525);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(104, 31);
            lblTenNCC.TabIndex = 7;
            lblTenNCC.Text = "Tên NCC:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = Color.FromArgb(116, 69, 37);
            lblDiaChi.Location = new Point(606, 573);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(92, 31);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = Color.FromArgb(116, 69, 37);
            lblSDT.Location = new Point(634, 624);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(58, 31);
            lblSDT.TabIndex = 9;
            lblSDT.Text = "SDT:";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNCC.Location = new Point(700, 523);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(250, 38);
            txtTenNCC.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(700, 573);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 38);
            txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(700, 622);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 38);
            txtSDT.TabIndex = 12;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(646, 684);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 57);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(773, 684);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 57);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(907, 684);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(116, 57);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // NhaCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 192, 146);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenNCC);
            Controls.Add(lblSDT);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(btnThem);
            Controls.Add(lblMaNCC);
            Controls.Add(lblNCC);
            Controls.Add(picNCC);
            Controls.Add(dgvQLNCC);
            Name = "NhaCC";
            Size = new Size(1035, 767);
            Load += NhaCC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLNCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNCC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLNCC;
        private PictureBox picNCC;
        private Label lblNCC;
        private Label lblMaNCC;
        private Button btnThem;
        private TextBox txtMaNCC;
        private Label lblTenNCC;
        private Label lblDiaChi;
        private Label lblSDT;
        private TextBox txtTenNCC;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
    }
}
