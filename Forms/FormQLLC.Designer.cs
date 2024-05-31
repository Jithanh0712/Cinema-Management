namespace RapChieuPhim.Forms
{
    partial class FormQLLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLC));
            btnXoa = new Button();
            btnThem = new Button();
            dgvQLLC = new DataGridView();
            lblThoiGianChieu = new Label();
            lblMaPhim = new Label();
            lblMaPhong = new Label();
            lblThoiGianHet = new Label();
            lblLC = new Label();
            pictureBox1 = new PictureBox();
            dtpTGC = new DateTimePicker();
            dtpTGH = new DateTimePicker();
            cbbMaPhong = new ComboBox();
            btnHuy = new Button();
            btnLuu = new Button();
            cbbMaPhim = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvQLLC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(806, 531);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 50);
            btnXoa.TabIndex = 47;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(168, 218, 220);
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(630, 531);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 50);
            btnThem.TabIndex = 46;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvQLLC
            // 
            dgvQLLC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLLC.Location = new Point(12, 12);
            dgvQLLC.Name = "dgvQLLC";
            dgvQLLC.RowHeadersWidth = 51;
            dgvQLLC.RowTemplate.Height = 29;
            dgvQLLC.Size = new Size(547, 646);
            dgvQLLC.TabIndex = 25;
            dgvQLLC.CellClick += dgvQLLC_CellClick;
            // 
            // lblThoiGianChieu
            // 
            lblThoiGianChieu.AutoSize = true;
            lblThoiGianChieu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblThoiGianChieu.ForeColor = Color.FromArgb(241, 250, 238);
            lblThoiGianChieu.Location = new Point(954, 356);
            lblThoiGianChieu.Name = "lblThoiGianChieu";
            lblThoiGianChieu.Size = new Size(190, 32);
            lblThoiGianChieu.TabIndex = 59;
            lblThoiGianChieu.Text = "Thời Gian Chiếu:";
            // 
            // lblMaPhim
            // 
            lblMaPhim.AutoSize = true;
            lblMaPhim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPhim.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaPhim.Location = new Point(590, 445);
            lblMaPhim.Name = "lblMaPhim";
            lblMaPhim.Size = new Size(114, 32);
            lblMaPhim.TabIndex = 58;
            lblMaPhim.Text = "Mã Phim:";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPhong.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaPhong.Location = new Point(575, 358);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(129, 32);
            lblMaPhong.TabIndex = 57;
            lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblThoiGianHet
            // 
            lblThoiGianHet.AutoSize = true;
            lblThoiGianHet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblThoiGianHet.ForeColor = Color.FromArgb(241, 250, 238);
            lblThoiGianHet.Location = new Point(966, 443);
            lblThoiGianHet.Name = "lblThoiGianHet";
            lblThoiGianHet.Size = new Size(166, 32);
            lblThoiGianHet.TabIndex = 55;
            lblThoiGianHet.Text = "Thời Gian Hết:";
            // 
            // lblLC
            // 
            lblLC.AutoSize = true;
            lblLC.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblLC.ForeColor = Color.FromArgb(241, 250, 238);
            lblLC.Location = new Point(942, 141);
            lblLC.Name = "lblLC";
            lblLC.Size = new Size(407, 106);
            lblLC.TabIndex = 61;
            lblLC.Text = "Lịch Chiếu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(590, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // dtpTGC
            // 
            dtpTGC.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTGC.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpTGC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTGC.Format = DateTimePickerFormat.Custom;
            dtpTGC.Location = new Point(1155, 355);
            dtpTGC.Name = "dtpTGC";
            dtpTGC.Size = new Size(185, 30);
            dtpTGC.TabIndex = 52;
            dtpTGC.Value = new DateTime(2023, 11, 15, 8, 42, 55, 0);
            // 
            // dtpTGH
            // 
            dtpTGH.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTGH.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpTGH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTGH.Format = DateTimePickerFormat.Custom;
            dtpTGH.Location = new Point(1155, 442);
            dtpTGH.Name = "dtpTGH";
            dtpTGH.Size = new Size(185, 30);
            dtpTGH.TabIndex = 52;
            // 
            // cbbMaPhong
            // 
            cbbMaPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaPhong.FormattingEnabled = true;
            cbbMaPhong.Location = new Point(747, 362);
            cbbMaPhong.Name = "cbbMaPhong";
            cbbMaPhong.Size = new Size(185, 31);
            cbbMaPhong.TabIndex = 63;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(168, 218, 220);
            btnHuy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(1182, 531);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(140, 50);
            btnHuy.TabIndex = 64;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(168, 218, 220);
            btnLuu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(1004, 531);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 50);
            btnLuu.TabIndex = 65;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cbbMaPhim
            // 
            cbbMaPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaPhim.FormattingEnabled = true;
            cbbMaPhim.Location = new Point(747, 443);
            cbbMaPhim.Name = "cbbMaPhim";
            cbbMaPhim.Size = new Size(185, 31);
            cbbMaPhim.TabIndex = 66;
            // 
            // FormQLLC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(1352, 680);
            Controls.Add(cbbMaPhim);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(cbbMaPhong);
            Controls.Add(dtpTGH);
            Controls.Add(dtpTGC);
            Controls.Add(pictureBox1);
            Controls.Add(lblLC);
            Controls.Add(lblThoiGianChieu);
            Controls.Add(lblMaPhim);
            Controls.Add(lblMaPhong);
            Controls.Add(lblThoiGianHet);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvQLLC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQLLC";
            Text = "Quản Lý Lịch Chiếu";
            Load += FormQLLC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLLC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvQLLC;
        private Label lblThoiGianChieu;
        private Label lblMaPhim;
        private Label lblMaPhong;
        private Label lblThoiGianHet;
        private Label lblLC;
        private PictureBox pictureBox1;
        private DateTimePicker dtpTGC;
        private DateTimePicker dtpTGH;
        private ComboBox cbbMaPhong;
        private Button btnHuy;
        private Button btnLuu;
        private ComboBox cbbMaPhim;
    }
}