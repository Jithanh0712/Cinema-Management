namespace RapChieuPhim.Forms
{
    partial class FormThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.lblHienMaNV = new System.Windows.Forms.Label();
            this.txtTongHD = new System.Windows.Forms.TextBox();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.cbbPTTT = new System.Windows.Forms.ComboBox();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaNV.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMaNV.Location = new System.Drawing.Point(738, 112);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(138, 30);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên: ";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaKH.Location = new System.Drawing.Point(44, 111);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(151, 30);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng: ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(282, 109);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(243, 37);
            this.txtMaKH.TabIndex = 7;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(44, 244);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.Size = new System.Drawing.Size(1002, 378);
            this.dgvCTHD.TabIndex = 13;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // lblTongHD
            // 
            this.lblTongHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongHD.Location = new System.Drawing.Point(44, 650);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(172, 30);
            this.lblTongHD.TabIndex = 14;
            this.lblTongHD.Text = "Tổng hóa đơn: ";
            // 
            // lblHienMaNV
            // 
            this.lblHienMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienMaNV.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHienMaNV.Location = new System.Drawing.Point(882, 111);
            this.lblHienMaNV.Name = "lblHienMaNV";
            this.lblHienMaNV.Size = new System.Drawing.Size(164, 39);
            this.lblHienMaNV.TabIndex = 15;
            // 
            // txtTongHD
            // 
            this.txtTongHD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongHD.Location = new System.Drawing.Point(185, 643);
            this.txtTongHD.Multiline = true;
            this.txtTongHD.Name = "txtTongHD";
            this.txtTongHD.Size = new System.Drawing.Size(192, 37);
            this.txtTongHD.TabIndex = 16;
            this.txtTongHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPTTT
            // 
            this.lblPTTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPTTT.Location = new System.Drawing.Point(44, 178);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(232, 30);
            this.lblPTTT.TabIndex = 17;
            this.lblPTTT.Text = "Phương thức thanh toán:";
            // 
            // cbbPTTT
            // 
            this.cbbPTTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbPTTT.FormattingEnabled = true;
            this.cbbPTTT.Items.AddRange(new object[] {
            "MoMo",
            "VNPay",
            "TheNganHang",
            "TienMat",
            "ZaloPay"});
            this.cbbPTTT.Location = new System.Drawing.Point(282, 178);
            this.cbbPTTT.Name = "cbbPTTT";
            this.cbbPTTT.Size = new System.Drawing.Size(243, 36);
            this.cbbPTTT.TabIndex = 18;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(893, 642);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(153, 56);
            this.btnXuatHoaDon.TabIndex = 19;
            this.btnXuatHoaDon.Text = "Xác nhận";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1103, 74);
            this.label1.TabIndex = 20;
            this.label1.Text = "THANH TOÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1091, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.cbbPTTT);
            this.Controls.Add(this.lblPTTT);
            this.Controls.Add(this.txtTongHD);
            this.Controls.Add(this.lblHienMaNV);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblMaNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMaNV;
        private Label lblMaKH;
        private TextBox txtMaKH;
        private DataGridView dgvCTHD;
        private Label lblTongHD;
        private Label lblHienMaNV;
        private TextBox txtTongHD;
        private Label lblPTTT;
        private ComboBox cbbPTTT;
        private Button btnXuatHoaDon;
        private Label label1;
    }
}