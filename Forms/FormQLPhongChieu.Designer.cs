namespace RapChieuPhim.Forms
{
    partial class FormQLPhongChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhongChieu));
            dgvPhongChieu = new DataGridView();
            lblMaPC = new Label();
            txtMaPC = new TextBox();
            lblSLThuong = new Label();
            txtSLThuong = new TextBox();
            txtSLVIP = new TextBox();
            lblSLVIP = new Label();
            txtSLDoi = new TextBox();
            lblSLDoi = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnTroVe = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhongChieu).BeginInit();
            SuspendLayout();
            // 
            // dgvPhongChieu
            // 
            dgvPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongChieu.Location = new Point(12, 156);
            dgvPhongChieu.Name = "dgvPhongChieu";
            dgvPhongChieu.RowHeadersWidth = 51;
            dgvPhongChieu.RowTemplate.Height = 29;
            dgvPhongChieu.Size = new Size(869, 297);
            dgvPhongChieu.TabIndex = 0;
            dgvPhongChieu.CellClick += dgvPhongChieu_CellClick;
            // 
            // lblMaPC
            // 
            lblMaPC.AutoSize = true;
            lblMaPC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPC.ForeColor = SystemColors.ButtonFace;
            lblMaPC.Location = new Point(12, 9);
            lblMaPC.Name = "lblMaPC";
            lblMaPC.Size = new Size(135, 23);
            lblMaPC.TabIndex = 1;
            lblMaPC.Text = "Mã Phòng chiếu";
            // 
            // txtMaPC
            // 
            txtMaPC.Enabled = false;
            txtMaPC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPC.Location = new Point(153, 6);
            txtMaPC.Name = "txtMaPC";
            txtMaPC.Size = new Size(125, 30);
            txtMaPC.TabIndex = 2;
            // 
            // lblSLThuong
            // 
            lblSLThuong.AutoSize = true;
            lblSLThuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLThuong.ForeColor = SystemColors.ButtonFace;
            lblSLThuong.Location = new Point(313, 66);
            lblSLThuong.Name = "lblSLThuong";
            lblSLThuong.Size = new Size(173, 23);
            lblSLThuong.TabIndex = 3;
            lblSLThuong.Text = "Số lượng ghế thường";
            // 
            // txtSLThuong
            // 
            txtSLThuong.Enabled = false;
            txtSLThuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLThuong.Location = new Point(492, 63);
            txtSLThuong.Name = "txtSLThuong";
            txtSLThuong.Size = new Size(125, 30);
            txtSLThuong.TabIndex = 4;
            // 
            // txtSLVIP
            // 
            txtSLVIP.Enabled = false;
            txtSLVIP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLVIP.Location = new Point(492, 12);
            txtSLVIP.Name = "txtSLVIP";
            txtSLVIP.Size = new Size(125, 30);
            txtSLVIP.TabIndex = 6;
            // 
            // lblSLVIP
            // 
            lblSLVIP.AutoSize = true;
            lblSLVIP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLVIP.ForeColor = SystemColors.ButtonFace;
            lblSLVIP.Location = new Point(313, 15);
            lblSLVIP.Name = "lblSLVIP";
            lblSLVIP.Size = new Size(143, 23);
            lblSLVIP.TabIndex = 5;
            lblSLVIP.Text = "Số lượng ghế VIP";
            // 
            // txtSLDoi
            // 
            txtSLDoi.Enabled = false;
            txtSLDoi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLDoi.Location = new Point(492, 114);
            txtSLDoi.Name = "txtSLDoi";
            txtSLDoi.Size = new Size(125, 30);
            txtSLDoi.TabIndex = 8;
            // 
            // lblSLDoi
            // 
            lblSLDoi.AutoSize = true;
            lblSLDoi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSLDoi.ForeColor = SystemColors.ButtonFace;
            lblSLDoi.Location = new Point(313, 117);
            lblSLDoi.Name = "lblSLDoi";
            lblSLDoi.Size = new Size(141, 23);
            lblSLDoi.TabIndex = 7;
            lblSLDoi.Text = "Số lượng ghế đôi";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(69, 123, 157);
            btnThem.Location = new Point(714, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(69, 123, 157);
            btnSua.Location = new Point(714, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(69, 123, 157);
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(714, 79);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(69, 123, 157);
            btnTroVe.Location = new Point(12, 115);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(94, 29);
            btnTroVe.TabIndex = 12;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(69, 123, 157);
            btnHuy.Enabled = false;
            btnHuy.Location = new Point(714, 114);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormQLPhongChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(893, 465);
            Controls.Add(btnHuy);
            Controls.Add(btnTroVe);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSLDoi);
            Controls.Add(lblSLDoi);
            Controls.Add(txtSLVIP);
            Controls.Add(lblSLVIP);
            Controls.Add(txtSLThuong);
            Controls.Add(lblSLThuong);
            Controls.Add(txtMaPC);
            Controls.Add(lblMaPC);
            Controls.Add(dgvPhongChieu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQLPhongChieu";
            Text = "Quản Lý Phòng Chiếu";
            Load += FormQLPhongChieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhongChieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhongChieu;
        private Label lblMaPC;
        private TextBox txtMaPC;
        private Label lblSLThuong;
        private TextBox txtSLThuong;
        private TextBox txtSLVIP;
        private Label lblSLVIP;
        private TextBox txtSLDoi;
        private Label lblSLDoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnLuu;
        private Button btnTroVe;
        private Button btnHuy;
    }
}