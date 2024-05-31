namespace RapChieuPhim.UserControls
{
    partial class UCLichSuTT
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
            pnlLichSuTT = new Panel();
            llblChiTiet = new LinkLabel();
            lblTongTien = new Label();
            lblThoiGianThanhToan = new Label();
            lblMaHD = new Label();
            pnlLichSuTT.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLichSuTT
            // 
            pnlLichSuTT.BackColor = Color.FromArgb(29, 53, 87);
            pnlLichSuTT.Controls.Add(llblChiTiet);
            pnlLichSuTT.Controls.Add(lblTongTien);
            pnlLichSuTT.Controls.Add(lblThoiGianThanhToan);
            pnlLichSuTT.Controls.Add(lblMaHD);
            pnlLichSuTT.Location = new Point(11, 7);
            pnlLichSuTT.Name = "pnlLichSuTT";
            pnlLichSuTT.Size = new Size(655, 57);
            pnlLichSuTT.TabIndex = 0;
            // 
            // llblChiTiet
            // 
            llblChiTiet.AutoSize = true;
            llblChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            llblChiTiet.LinkColor = Color.FromArgb(69, 123, 157);
            llblChiTiet.Location = new Point(559, 18);
            llblChiTiet.Name = "llblChiTiet";
            llblChiTiet.Size = new Size(94, 23);
            llblChiTiet.TabIndex = 4;
            llblChiTiet.TabStop = true;
            llblChiTiet.Text = "Chi tiết >>";
            llblChiTiet.LinkClicked += llblChiTiet_LinkClicked;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = Color.FromArgb(29, 53, 87);
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTien.ForeColor = SystemColors.ButtonFace;
            lblTongTien.Location = new Point(420, 18);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(83, 23);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng tiền";
            // 
            // lblThoiGianThanhToan
            // 
            lblThoiGianThanhToan.AutoSize = true;
            lblThoiGianThanhToan.BackColor = Color.FromArgb(29, 53, 87);
            lblThoiGianThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblThoiGianThanhToan.ForeColor = SystemColors.ButtonFace;
            lblThoiGianThanhToan.Location = new Point(150, 18);
            lblThoiGianThanhToan.Name = "lblThoiGianThanhToan";
            lblThoiGianThanhToan.Size = new Size(171, 23);
            lblThoiGianThanhToan.TabIndex = 2;
            lblThoiGianThanhToan.Text = "Thời gian thanh toán";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.BackColor = Color.FromArgb(29, 53, 87);
            lblMaHD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHD.ForeColor = SystemColors.ButtonFace;
            lblMaHD.Location = new Point(0, 18);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(103, 23);
            lblMaHD.TabIndex = 1;
            lblMaHD.Text = "Mã hóa đơn";
            // 
            // UCLichSuTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLichSuTT);
            Name = "UCLichSuTT";
            Size = new Size(683, 124);
            pnlLichSuTT.ResumeLayout(false);
            pnlLichSuTT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLichSuTT;
        private Label lblMaHD;
        private LinkLabel llblChiTiet;
        private Label lblTongTien;
        private Label lblThoiGianThanhToan;
    }
}
