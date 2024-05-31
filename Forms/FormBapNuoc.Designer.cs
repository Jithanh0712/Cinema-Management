namespace RapChieuPhim.Forms
{
    partial class FormBapNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBapNuoc));
            pictureBox1 = new PictureBox();
            lblMaKH = new Label();
            lblHienMaKH = new Label();
            lblTenHH_pnl = new Label();
            lblGiaTien = new Label();
            nudSL_pnl = new NumericUpDown();
            lblTenHangHoa = new Label();
            lblSoLuong = new Label();
            lblGiaTien_pnl = new Label();
            pnlHangHoas = new Panel();
            pnlHH = new Panel();
            btnThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSL_pnl).BeginInit();
            pnlHangHoas.SuspendLayout();
            pnlHH.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaKH.Location = new Point(312, 21);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(144, 25);
            lblMaKH.TabIndex = 1;
            lblMaKH.Text = "Mã khách hàng: ";
            // 
            // lblHienMaKH
            // 
            lblHienMaKH.BorderStyle = BorderStyle.FixedSingle;
            lblHienMaKH.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblHienMaKH.Location = new Point(457, 13);
            lblHienMaKH.Name = "lblHienMaKH";
            lblHienMaKH.Size = new Size(264, 40);
            lblHienMaKH.TabIndex = 2;
            lblHienMaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenHH_pnl
            // 
            lblTenHH_pnl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenHH_pnl.Location = new Point(9, 14);
            lblTenHH_pnl.Name = "lblTenHH_pnl";
            lblTenHH_pnl.Size = new Size(99, 25);
            lblTenHH_pnl.TabIndex = 3;
            lblTenHH_pnl.Text = "Bắp 1";
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGiaTien.Location = new Point(476, 76);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(69, 23);
            lblGiaTien.TabIndex = 4;
            lblGiaTien.Text = "Giá tiền";
            // 
            // nudSL_pnl
            // 
            nudSL_pnl.Location = new Point(335, 12);
            nudSL_pnl.Name = "nudSL_pnl";
            nudSL_pnl.Size = new Size(50, 27);
            nudSL_pnl.TabIndex = 5;
            // 
            // lblTenHangHoa
            // 
            lblTenHangHoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenHangHoa.Location = new Point(312, 74);
            lblTenHangHoa.Name = "lblTenHangHoa";
            lblTenHangHoa.Size = new Size(132, 25);
            lblTenHangHoa.TabIndex = 6;
            lblTenHangHoa.Text = "Tên hàng hóa";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.Location = new Point(626, 74);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(79, 23);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng";
            // 
            // lblGiaTien_pnl
            // 
            lblGiaTien_pnl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGiaTien_pnl.Location = new Point(170, 14);
            lblGiaTien_pnl.Name = "lblGiaTien_pnl";
            lblGiaTien_pnl.Size = new Size(99, 25);
            lblGiaTien_pnl.TabIndex = 8;
            lblGiaTien_pnl.Text = "40000";
            // 
            // pnlHangHoas
            // 
            pnlHangHoas.AutoScroll = true;
            pnlHangHoas.Controls.Add(pnlHH);
            pnlHangHoas.Location = new Point(301, 102);
            pnlHangHoas.Name = "pnlHangHoas";
            pnlHangHoas.Size = new Size(425, 342);
            pnlHangHoas.TabIndex = 9;
            // 
            // pnlHH
            // 
            pnlHH.Controls.Add(lblGiaTien_pnl);
            pnlHH.Controls.Add(nudSL_pnl);
            pnlHH.Controls.Add(lblTenHH_pnl);
            pnlHH.Location = new Point(5, 6);
            pnlHH.Name = "pnlHH";
            pnlHH.Size = new Size(399, 57);
            pnlHH.TabIndex = 9;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(230, 57, 70);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(553, 451);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(162, 52);
            btnThanhToan.TabIndex = 12;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // FormBapNuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 123, 157);
            ClientSize = new Size(733, 509);
            Controls.Add(btnThanhToan);
            Controls.Add(pnlHangHoas);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTenHangHoa);
            Controls.Add(lblGiaTien);
            Controls.Add(lblHienMaKH);
            Controls.Add(lblMaKH);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBapNuoc";
            Text = "FormBapNuoc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSL_pnl).EndInit();
            pnlHangHoas.ResumeLayout(false);
            pnlHH.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMaKH;
        private Label lblHienMaKH;
        private Label lblTenHH_pnl;
        private Label lblGiaTien;
        private NumericUpDown nudSL_pnl;
        private Label lblTenHangHoa;
        private Label lblSoLuong;
        private Label lblGiaTien_pnl;
        private Panel pnlHangHoas;
        private Panel pnlHH;
        private Button btnThanhToan;
    }
}