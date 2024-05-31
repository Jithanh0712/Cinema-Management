namespace RapChieuPhim.Forms
{
    partial class FormQLMaGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLMaGiamGia));
            dgvQLMGG = new DataGridView();
            btnThem = new Button();
            lblMaGG = new Label();
            txtMaGG = new TextBox();
            lblDieuKien = new Label();
            lblMaHH = new Label();
            lblLoaiGG = new Label();
            lblQLMGG = new Label();
            lblGiaTri = new Label();
            txtGiaTri = new TextBox();
            cbbLoaiGG = new ComboBox();
            cbbMaHH = new ComboBox();
            lblNgayHet = new Label();
            dtpNgayHet = new DateTimePicker();
            txtDieuKien = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLMGG).BeginInit();
            SuspendLayout();
            // 
            // dgvQLMGG
            // 
            dgvQLMGG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLMGG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLMGG.Location = new Point(18, 410);
            dgvQLMGG.Name = "dgvQLMGG";
            dgvQLMGG.RowHeadersWidth = 51;
            dgvQLMGG.RowTemplate.Height = 29;
            dgvQLMGG.Size = new Size(820, 268);
            dgvQLMGG.TabIndex = 0;
            dgvQLMGG.CellClick += dgvQLMGG_CellClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 218, 220);
            btnThem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(604, 274);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 42);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblMaGG
            // 
            lblMaGG.AutoSize = true;
            lblMaGG.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaGG.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaGG.Location = new Point(63, 143);
            lblMaGG.Name = "lblMaGG";
            lblMaGG.Size = new Size(90, 31);
            lblMaGG.TabIndex = 2;
            lblMaGG.Text = "Mã GG:";
            // 
            // txtMaGG
            // 
            txtMaGG.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaGG.Location = new Point(190, 143);
            txtMaGG.Name = "txtMaGG";
            txtMaGG.Size = new Size(190, 30);
            txtMaGG.TabIndex = 3;
            // 
            // lblDieuKien
            // 
            lblDieuKien.AutoSize = true;
            lblDieuKien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieuKien.ForeColor = Color.FromArgb(241, 250, 238);
            lblDieuKien.Location = new Point(37, 309);
            lblDieuKien.Name = "lblDieuKien";
            lblDieuKien.Size = new Size(116, 31);
            lblDieuKien.TabIndex = 4;
            lblDieuKien.Text = "Điều Kiện:";
            // 
            // lblMaHH
            // 
            lblMaHH.AutoSize = true;
            lblMaHH.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHH.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaHH.Location = new Point(63, 250);
            lblMaHH.Name = "lblMaHH";
            lblMaHH.Size = new Size(90, 31);
            lblMaHH.TabIndex = 5;
            lblMaHH.Text = "Mã HH:";
            // 
            // lblLoaiGG
            // 
            lblLoaiGG.AutoSize = true;
            lblLoaiGG.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiGG.ForeColor = Color.FromArgb(241, 250, 238);
            lblLoaiGG.Location = new Point(54, 195);
            lblLoaiGG.Name = "lblLoaiGG";
            lblLoaiGG.Size = new Size(99, 31);
            lblLoaiGG.TabIndex = 6;
            lblLoaiGG.Text = "Loại GG:";
            // 
            // lblQLMGG
            // 
            lblQLMGG.AutoSize = true;
            lblQLMGG.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLMGG.ForeColor = Color.FromArgb(241, 250, 238);
            lblQLMGG.Location = new Point(202, 34);
            lblQLMGG.Name = "lblQLMGG";
            lblQLMGG.Size = new Size(475, 62);
            lblQLMGG.TabIndex = 7;
            lblQLMGG.Text = "Quản Lý Mã Giảm Giá";
            // 
            // lblGiaTri
            // 
            lblGiaTri.AutoSize = true;
            lblGiaTri.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiaTri.ForeColor = Color.FromArgb(241, 250, 238);
            lblGiaTri.Location = new Point(70, 363);
            lblGiaTri.Name = "lblGiaTri";
            lblGiaTri.Size = new Size(83, 31);
            lblGiaTri.TabIndex = 8;
            lblGiaTri.Text = "Giá Trị:";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaTri.Location = new Point(190, 363);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(190, 30);
            txtGiaTri.TabIndex = 9;
            // 
            // cbbLoaiGG
            // 
            cbbLoaiGG.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbLoaiGG.FormattingEnabled = true;
            cbbLoaiGG.Items.AddRange(new object[] { "V1", "V2" });
            cbbLoaiGG.Location = new Point(190, 195);
            cbbLoaiGG.Name = "cbbLoaiGG";
            cbbLoaiGG.Size = new Size(190, 31);
            cbbLoaiGG.TabIndex = 10;
            // 
            // cbbMaHH
            // 
            cbbMaHH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaHH.FormattingEnabled = true;
            cbbMaHH.Location = new Point(190, 250);
            cbbMaHH.Name = "cbbMaHH";
            cbbMaHH.Size = new Size(190, 31);
            cbbMaHH.TabIndex = 11;
            // 
            // lblNgayHet
            // 
            lblNgayHet.AutoSize = true;
            lblNgayHet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayHet.ForeColor = Color.FromArgb(241, 250, 238);
            lblNgayHet.Location = new Point(430, 143);
            lblNgayHet.Name = "lblNgayHet";
            lblNgayHet.Size = new Size(115, 31);
            lblNgayHet.TabIndex = 12;
            lblNgayHet.Text = "Ngày Hết:";
            // 
            // dtpNgayHet
            // 
            dtpNgayHet.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayHet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayHet.Format = DateTimePickerFormat.Short;
            dtpNgayHet.Location = new Point(586, 144);
            dtpNgayHet.Name = "dtpNgayHet";
            dtpNgayHet.Size = new Size(190, 30);
            dtpNgayHet.TabIndex = 13;
            dtpNgayHet.Value = new DateTime(2023, 11, 21, 0, 0, 0, 0);
            // 
            // txtDieuKien
            // 
            txtDieuKien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDieuKien.Location = new Point(190, 307);
            txtDieuKien.Name = "txtDieuKien";
            txtDieuKien.Size = new Size(190, 30);
            txtDieuKien.TabIndex = 14;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(447, 363);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 42);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(168, 218, 220);
            btnSua.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(447, 274);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 42);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(604, 362);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(99, 42);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(727, 318);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 42);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormQLMaGiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(854, 694);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(txtDieuKien);
            Controls.Add(dtpNgayHet);
            Controls.Add(lblNgayHet);
            Controls.Add(cbbMaHH);
            Controls.Add(cbbLoaiGG);
            Controls.Add(txtGiaTri);
            Controls.Add(lblGiaTri);
            Controls.Add(lblQLMGG);
            Controls.Add(lblLoaiGG);
            Controls.Add(lblMaHH);
            Controls.Add(lblDieuKien);
            Controls.Add(txtMaGG);
            Controls.Add(lblMaGG);
            Controls.Add(btnThem);
            Controls.Add(dgvQLMGG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQLMaGiamGia";
            Text = "FormQLMaGiamGia";
            Load += FormQLMaGiamGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLMGG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLMGG;
        private Button btnThem;
        private Label lblMaGG;
        private TextBox txtMaGG;
        private Label lblDieuKien;
        private Label lblMaHH;
        private Label lblLoaiGG;
        private Label lblQLMGG;
        private Label lblGiaTri;
        private TextBox txtGiaTri;
        private ComboBox cbbLoaiGG;
        private ComboBox cbbMaHH;
        private Label lblNgayHet;
        private DateTimePicker dtpNgayHet;
        private TextBox txtDieuKien;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
    }
}