namespace RapChieuPhim.Forms
{
    partial class FormChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHD));
            lblMaHD = new Label();
            lblThoiGianThanhToan = new Label();
            lblPhuongThucThanhToan = new Label();
            lblTongTien = new Label();
            lblDiemTruocThanhToan = new Label();
            lblDiemSauThanhToan = new Label();
            txtMaHD = new TextBox();
            txtThoiGianThanhToan = new TextBox();
            txtPhuongThucThanhToan = new TextBox();
            txtDiemTruocThanhToan = new TextBox();
            txtDiemSauThanhToan = new TextBox();
            txtTongTien = new TextBox();
            dgvChiTietHD = new DataGridView();
            btnTroVe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            SuspendLayout();
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHD.ForeColor = SystemColors.ButtonFace;
            lblMaHD.Location = new Point(36, 19);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(112, 23);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hóa đơn: ";
            // 
            // lblThoiGianThanhToan
            // 
            lblThoiGianThanhToan.AutoSize = true;
            lblThoiGianThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblThoiGianThanhToan.ForeColor = SystemColors.ButtonFace;
            lblThoiGianThanhToan.Location = new Point(36, 54);
            lblThoiGianThanhToan.Name = "lblThoiGianThanhToan";
            lblThoiGianThanhToan.Size = new Size(180, 23);
            lblThoiGianThanhToan.TabIndex = 1;
            lblThoiGianThanhToan.Text = "Thời gian thanh toán: ";
            // 
            // lblPhuongThucThanhToan
            // 
            lblPhuongThucThanhToan.AutoSize = true;
            lblPhuongThucThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhuongThucThanhToan.ForeColor = SystemColors.ButtonFace;
            lblPhuongThucThanhToan.Location = new Point(440, 54);
            lblPhuongThucThanhToan.Name = "lblPhuongThucThanhToan";
            lblPhuongThucThanhToan.Size = new Size(208, 23);
            lblPhuongThucThanhToan.TabIndex = 2;
            lblPhuongThucThanhToan.Text = "Phương thức thanh toán: ";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTien.ForeColor = SystemColors.ButtonFace;
            lblTongTien.Location = new Point(567, 383);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(92, 23);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền: ";
            // 
            // lblDiemTruocThanhToan
            // 
            lblDiemTruocThanhToan.AutoSize = true;
            lblDiemTruocThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiemTruocThanhToan.ForeColor = SystemColors.ButtonFace;
            lblDiemTruocThanhToan.Location = new Point(36, 433);
            lblDiemTruocThanhToan.Name = "lblDiemTruocThanhToan";
            lblDiemTruocThanhToan.Size = new Size(243, 23);
            lblDiemTruocThanhToan.TabIndex = 6;
            lblDiemTruocThanhToan.Text = "Số điểm trước khi thanh toán: ";
            // 
            // lblDiemSauThanhToan
            // 
            lblDiemSauThanhToan.AutoSize = true;
            lblDiemSauThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiemSauThanhToan.ForeColor = SystemColors.ButtonFace;
            lblDiemSauThanhToan.Location = new Point(36, 474);
            lblDiemSauThanhToan.Name = "lblDiemSauThanhToan";
            lblDiemSauThanhToan.Size = new Size(229, 23);
            lblDiemSauThanhToan.TabIndex = 7;
            lblDiemSauThanhToan.Text = "Số điểm sau khi thanh toán: ";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(221, 18);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(175, 27);
            txtMaHD.TabIndex = 8;
            // 
            // txtThoiGianThanhToan
            // 
            txtThoiGianThanhToan.Location = new Point(221, 51);
            txtThoiGianThanhToan.Name = "txtThoiGianThanhToan";
            txtThoiGianThanhToan.Size = new Size(175, 27);
            txtThoiGianThanhToan.TabIndex = 9;
            // 
            // txtPhuongThucThanhToan
            // 
            txtPhuongThucThanhToan.Location = new Point(654, 51);
            txtPhuongThucThanhToan.Name = "txtPhuongThucThanhToan";
            txtPhuongThucThanhToan.Size = new Size(121, 27);
            txtPhuongThucThanhToan.TabIndex = 10;
            // 
            // txtDiemTruocThanhToan
            // 
            txtDiemTruocThanhToan.Location = new Point(285, 432);
            txtDiemTruocThanhToan.Name = "txtDiemTruocThanhToan";
            txtDiemTruocThanhToan.Size = new Size(175, 27);
            txtDiemTruocThanhToan.TabIndex = 11;
            // 
            // txtDiemSauThanhToan
            // 
            txtDiemSauThanhToan.Location = new Point(285, 473);
            txtDiemSauThanhToan.Name = "txtDiemSauThanhToan";
            txtDiemSauThanhToan.Size = new Size(175, 27);
            txtDiemSauThanhToan.TabIndex = 12;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(654, 382);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(121, 27);
            txtTongTien.TabIndex = 9;
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Location = new Point(12, 98);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.RowHeadersWidth = 51;
            dgvChiTietHD.RowTemplate.Height = 29;
            dgvChiTietHD.Size = new Size(763, 278);
            dgvChiTietHD.TabIndex = 13;
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(168, 218, 220);
            btnTroVe.Location = new Point(681, 468);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(94, 29);
            btnTroVe.TabIndex = 14;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // FormChiTietHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 534);
            Controls.Add(btnTroVe);
            Controls.Add(dgvChiTietHD);
            Controls.Add(txtTongTien);
            Controls.Add(txtDiemSauThanhToan);
            Controls.Add(txtDiemTruocThanhToan);
            Controls.Add(txtPhuongThucThanhToan);
            Controls.Add(txtThoiGianThanhToan);
            Controls.Add(txtMaHD);
            Controls.Add(lblDiemSauThanhToan);
            Controls.Add(lblDiemTruocThanhToan);
            Controls.Add(lblTongTien);
            Controls.Add(lblPhuongThucThanhToan);
            Controls.Add(lblThoiGianThanhToan);
            Controls.Add(lblMaHD);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChiTietHD";
            Text = "FormChiTietHD";
            Load += FormChiTietHD_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHD;
        private Label lblThoiGianThanhToan;
        private Label lblPhuongThucThanhToan;
        private Label lblTongTien;
        private Label lblDiemTruocThanhToan;
        private Label lblDiemSauThanhToan;
        private TextBox txtMaHD;
        private TextBox txtThoiGianThanhToan;
        private TextBox txtPhuongThucThanhToan;
        private TextBox txtDiemTruocThanhToan;
        private TextBox txtDiemSauThanhToan;
        private TextBox txtTongTien;
        private DataGridView dgvChiTietHD;
        private Button btnTroVe;
    }
}