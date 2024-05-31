namespace RapChieuPhim.Forms
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTextMNV = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTextTamTinh = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.dgvDSHH = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbbMaGG = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbbDSHH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaNV
            // 
            this.lblMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaNV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMaNV.Location = new System.Drawing.Point(1073, 38);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(156, 37);
            this.lblMaNV.TabIndex = 1;
            // 
            // lblTextMNV
            // 
            this.lblTextMNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextMNV.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTextMNV.Location = new System.Drawing.Point(928, 42);
            this.lblTextMNV.Name = "lblTextMNV";
            this.lblTextMNV.Size = new System.Drawing.Size(139, 33);
            this.lblTextMNV.TabIndex = 0;
            this.lblTextMNV.Text = "Mã nhân viên: ";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaKH.Location = new System.Drawing.Point(25, 43);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(151, 33);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "Mã khách hàng: ";
            // 
            // lblMaHH
            // 
            this.lblMaHH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaHH.Location = new System.Drawing.Point(25, 109);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(139, 33);
            this.lblMaHH.TabIndex = 3;
            this.lblMaHH.Text = "Mã hàng hóa: ";
            // 
            // lblSL
            // 
            this.lblSL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSL.Location = new System.Drawing.Point(481, 107);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(101, 33);
            this.lblSL.TabIndex = 4;
            this.lblSL.Text = "Số lượng: ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(192, 43);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(205, 33);
            this.txtMaKH.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.Location = new System.Drawing.Point(1073, 687);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(157, 56);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTextTamTinh
            // 
            this.lblTextTamTinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextTamTinh.Location = new System.Drawing.Point(66, 698);
            this.lblTextTamTinh.Name = "lblTextTamTinh";
            this.lblTextTamTinh.Size = new System.Drawing.Size(120, 36);
            this.lblTextTamTinh.TabIndex = 12;
            this.lblTextTamTinh.Text = "Tạm tính:";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTamTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTamTinh.Location = new System.Drawing.Point(192, 687);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(290, 50);
            this.lblTamTinh.TabIndex = 13;
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemSP.Location = new System.Drawing.Point(736, 95);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(156, 53);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(588, 109);
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(83, 27);
            this.nudSL.TabIndex = 15;
            // 
            // dgvDSHH
            // 
            this.dgvDSHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHangHoa,
            this.SL,
            this.TongTien});
            this.dgvDSHH.Location = new System.Drawing.Point(25, 191);
            this.dgvDSHH.Name = "dgvDSHH";
            this.dgvDSHH.RowHeadersWidth = 51;
            this.dgvDSHH.RowTemplate.Height = 29;
            this.dgvDSHH.Size = new System.Drawing.Size(1205, 477);
            this.dgvDSHH.TabIndex = 16;
            this.dgvDSHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHH_CellClick);
            // 
            // MaHH
            // 
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.HeaderText = "Tên hàng hóa";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnCapnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapnhat.Location = new System.Drawing.Point(736, 31);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(156, 53);
            this.btnCapnhat.TabIndex = 17;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(911, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 53);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(1074, 97);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 53);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbMaGG
            // 
            this.cbbMaGG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMaGG.FormattingEnabled = true;
            this.cbbMaGG.Location = new System.Drawing.Point(481, 47);
            this.cbbMaGG.Name = "cbbMaGG";
            this.cbbMaGG.Size = new System.Drawing.Size(190, 28);
            this.cbbMaGG.TabIndex = 20;
            this.cbbMaGG.Text = "Mã giảm giá";
            this.cbbMaGG.SelectedIndexChanged += new System.EventHandler(this.cbbMaGG_SelectedIndexChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Red;
            this.btnXacNhan.Location = new System.Drawing.Point(403, 43);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(38, 33);
            this.btnXacNhan.TabIndex = 21;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbbDSHH
            // 
            this.cbbDSHH.FormattingEnabled = true;
            this.cbbDSHH.Location = new System.Drawing.Point(192, 111);
            this.cbbDSHH.Name = "cbbDSHH";
            this.cbbDSHH.Size = new System.Drawing.Size(205, 28);
            this.cbbDSHH.TabIndex = 22;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1271, 775);
            this.Controls.Add(this.cbbDSHH);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbbMaGG);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.dgvDSHH);
            this.Controls.Add(this.nudSL);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.lblTamTinh);
            this.Controls.Add(this.lblTextTamTinh);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblMaHH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTextMNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMaNV;
        private Label lblTextMNV;
        private Label lblMaKH;
        private Label lblMaHH;
        private Label lblSL;
        private TextBox txtMaKH;
        private Button btnThanhToan;
        private Label lblTextTamTinh;
        private Label lblTamTinh;
        private Button btnThemSP;
        private NumericUpDown nudSL;
        private DataGridView dgvDSHH;
        private DataGridViewTextBoxColumn MaHH;
        private DataGridViewTextBoxColumn TenHangHoa;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn TongTien;
        private Button btnCapnhat;
        private Button btnXoa;
        private Button btnLuu;
        private ComboBox cbbMaGG;
        private Button btnXacNhan;
        private ComboBox cbbDSHH;
    }
}