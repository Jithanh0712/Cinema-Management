namespace RapChieuPhim
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnDangNhap = new Button();
            btnDangKy = new Button();
            btnThoat = new Button();
            lblTieuDe = new Label();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(69, 123, 157);
            btnDangNhap.FlatAppearance.BorderColor = Color.White;
            btnDangNhap.FlatAppearance.BorderSize = 3;
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.White;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.FromArgb(241, 250, 238);
            btnDangNhap.Location = new Point(914, 419);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(199, 66);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(69, 123, 157);
            btnDangKy.FlatAppearance.BorderSize = 3;
            btnDangKy.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.FromArgb(241, 250, 238);
            btnDangKy.Location = new Point(914, 513);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(199, 67);
            btnDangKy.TabIndex = 1;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(69, 123, 157);
            btnThoat.FlatAppearance.BorderSize = 3;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.FromArgb(241, 250, 238);
            btnThoat.Location = new Point(914, 602);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(199, 67);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BackColor = Color.Transparent;
            lblTieuDe.Font = new Font("Segoe UI", 64.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.FromArgb(241, 250, 238);
            lblTieuDe.Location = new Point(168, 53);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(823, 146);
            lblTieuDe.TabIndex = 3;
            lblTieuDe.Text = "Rạp Chiếu Phim";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 250, 238);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 694);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rạp Chiếu Phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private Button btnDangKy;
        private Button btnThoat;
        private Label lblTieuDe;
    }
}