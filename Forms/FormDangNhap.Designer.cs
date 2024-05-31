namespace RapChieuPhim
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            lblDangNhap = new Label();
            lblTenDN = new Label();
            lblMK = new Label();
            txtTenDN = new TextBox();
            txtMK = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lblLoiTenDN = new Label();
            lblLoiMK = new Label();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangNhap.ForeColor = Color.FromArgb(241, 250, 238);
            lblDangNhap.Location = new Point(222, 42);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(420, 100);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "Đăng Nhập";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenDN.ForeColor = Color.FromArgb(241, 250, 238);
            lblTenDN.Location = new Point(49, 229);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(258, 46);
            lblTenDN.TabIndex = 1;
            lblTenDN.Text = "Tên Đăng Nhập:";
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblMK.ForeColor = Color.FromArgb(241, 250, 238);
            lblMK.Location = new Point(49, 325);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(171, 46);
            lblMK.TabIndex = 2;
            lblMK.Text = "Mật Khẩu:";
            // 
            // txtTenDN
            // 
            txtTenDN.BackColor = Color.FromArgb(168, 218, 220);
            txtTenDN.Cursor = Cursors.IBeam;
            txtTenDN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDN.Location = new Point(313, 239);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(401, 34);
            txtTenDN.TabIndex = 3;
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.FromArgb(168, 218, 220);
            txtMK.Cursor = Cursors.IBeam;
            txtMK.Font = new Font("Wingdings", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.Location = new Point(313, 337);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = 'l';
            txtMK.Size = new Size(401, 33);
            txtMK.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(241, 250, 238);
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.FromArgb(29, 53, 87);
            btnDangNhap.Location = new Point(542, 430);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(172, 57);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(241, 250, 238);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 218, 220);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.FromArgb(29, 53, 87);
            btnThoat.Location = new Point(363, 430);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 57);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblLoiTenDN
            // 
            lblLoiTenDN.AutoSize = true;
            lblLoiTenDN.ForeColor = Color.FromArgb(230, 57, 70);
            lblLoiTenDN.Location = new Point(313, 289);
            lblLoiTenDN.Name = "lblLoiTenDN";
            lblLoiTenDN.Size = new Size(0, 20);
            lblLoiTenDN.TabIndex = 22;
            // 
            // lblLoiMK
            // 
            lblLoiMK.AutoSize = true;
            lblLoiMK.ForeColor = Color.FromArgb(230, 57, 70);
            lblLoiMK.Location = new Point(312, 388);
            lblLoiMK.Name = "lblLoiMK";
            lblLoiMK.Size = new Size(0, 20);
            lblLoiMK.TabIndex = 23;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(818, 507);
            Controls.Add(lblLoiMK);
            Controls.Add(lblLoiTenDN);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMK);
            Controls.Add(txtTenDN);
            Controls.Add(lblMK);
            Controls.Add(lblTenDN);
            Controls.Add(lblDangNhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private Label lblTenDN;
        private Label lblMK;
        private TextBox txtTenDN;
        private TextBox txtMK;
        private Button btnDangNhap;
        private Button btnThoat;
        private Label lblLoiTenDN;
        private Label lblLoiMK;
    }
}