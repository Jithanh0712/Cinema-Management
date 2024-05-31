namespace RapChieuPhim.UserControls
{
    partial class UCChiTietHD
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
            pnlChiTietHD = new Panel();
            lblGia = new Label();
            lblSL = new Label();
            lblTenSP = new Label();
            lblSTT = new Label();
            pnlChiTietHD.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChiTietHD
            // 
            pnlChiTietHD.BackColor = Color.FromArgb(29, 53, 87);
            pnlChiTietHD.Controls.Add(lblGia);
            pnlChiTietHD.Controls.Add(lblSL);
            pnlChiTietHD.Controls.Add(lblTenSP);
            pnlChiTietHD.Controls.Add(lblSTT);
            pnlChiTietHD.Location = new Point(19, 22);
            pnlChiTietHD.Name = "pnlChiTietHD";
            pnlChiTietHD.Size = new Size(739, 54);
            pnlChiTietHD.TabIndex = 0;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGia.ForeColor = SystemColors.ButtonFace;
            lblGia.Location = new Point(677, 18);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(35, 23);
            lblGia.TabIndex = 4;
            lblGia.Text = "Giá";
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSL.ForeColor = SystemColors.ButtonFace;
            lblSL.Location = new Point(565, 18);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(78, 23);
            lblSL.TabIndex = 3;
            lblSL.Text = "Số lượng";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenSP.ForeColor = SystemColors.ButtonFace;
            lblTenSP.Location = new Point(113, 18);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(116, 23);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSTT.ForeColor = SystemColors.ButtonFace;
            lblSTT.Location = new Point(21, 18);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(30, 23);
            lblSTT.TabIndex = 1;
            lblSTT.Text = "Stt";
            // 
            // UCChiTietHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlChiTietHD);
            Name = "UCChiTietHD";
            Size = new Size(781, 96);
            pnlChiTietHD.ResumeLayout(false);
            pnlChiTietHD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChiTietHD;
        private Label lblGia;
        private Label lblSL;
        private Label lblTenSP;
        private Label lblSTT;
    }
}
