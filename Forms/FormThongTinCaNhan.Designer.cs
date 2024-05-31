using System.Windows.Forms;

namespace RapChieuPhim.Forms
{
    partial class FormThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTinCaNhan));
            lblThongTinCaNhan = new Label();
            lblMaNguoiDung = new Label();
            txtMaNguoiDung = new TextBox();
            lblTenNguoiDung = new Label();
            txtTenNguoiDung = new TextBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            lblGioiTinh = new Label();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            lblNgaySinh = new Label();
            dateNgaySinh = new DateTimePicker();
            txtHang = new TextBox();
            lblHang = new Label();
            txtDiemTL = new TextBox();
            lblDiemTL = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            btnSua = new Button();
            btnCapNhat = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblThongTinCaNhan
            // 
            lblThongTinCaNhan.AutoSize = true;
            lblThongTinCaNhan.BackColor = Color.FromArgb(29, 53, 87);
            lblThongTinCaNhan.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblThongTinCaNhan.ForeColor = SystemColors.ButtonHighlight;
            lblThongTinCaNhan.Location = new Point(232, 79);
            lblThongTinCaNhan.Name = "lblThongTinCaNhan";
            lblThongTinCaNhan.Size = new Size(364, 54);
            lblThongTinCaNhan.TabIndex = 0;
            lblThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // lblMaNguoiDung
            // 
            lblMaNguoiDung.AutoSize = true;
            lblMaNguoiDung.BackColor = Color.FromArgb(29, 53, 87);
            lblMaNguoiDung.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNguoiDung.ForeColor = SystemColors.Control;
            lblMaNguoiDung.Location = new Point(71, 227);
            lblMaNguoiDung.Name = "lblMaNguoiDung";
            lblMaNguoiDung.Size = new Size(185, 32);
            lblMaNguoiDung.TabIndex = 1;
            lblMaNguoiDung.Text = "Mã người dùng:";
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Enabled = false;
            txtMaNguoiDung.Location = new Point(308, 233);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.Size = new Size(242, 27);
            txtMaNguoiDung.TabIndex = 2;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.BackColor = Color.FromArgb(29, 53, 87);
            lblTenNguoiDung.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNguoiDung.ForeColor = SystemColors.Control;
            lblTenNguoiDung.Location = new Point(71, 298);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(189, 32);
            lblTenNguoiDung.TabIndex = 3;
            lblTenNguoiDung.Text = "Tên người dùng:";
            // 
            // txtTenNguoiDung
            // 
            txtTenNguoiDung.Enabled = false;
            txtTenNguoiDung.Location = new Point(308, 304);
            txtTenNguoiDung.Name = "txtTenNguoiDung";
            txtTenNguoiDung.Size = new Size(242, 27);
            txtTenNguoiDung.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Location = new Point(308, 374);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(242, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.BackColor = Color.FromArgb(29, 53, 87);
            lblDiaChi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.ForeColor = SystemColors.Control;
            lblDiaChi.Location = new Point(71, 368);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(92, 32);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.BackColor = Color.FromArgb(29, 53, 87);
            lblGioiTinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGioiTinh.ForeColor = SystemColors.Control;
            lblGioiTinh.Location = new Point(71, 440);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(110, 32);
            lblGioiTinh.TabIndex = 7;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.BackColor = Color.FromArgb(29, 53, 87);
            rdbNam.Enabled = false;
            rdbNam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNam.ForeColor = SystemColors.Control;
            rdbNam.Location = new Point(308, 440);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 32);
            rdbNam.TabIndex = 8;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.BackColor = Color.FromArgb(29, 53, 87);
            rdbNu.Enabled = false;
            rdbNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNu.ForeColor = SystemColors.Control;
            rdbNu.Location = new Point(475, 440);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(60, 32);
            rdbNu.TabIndex = 9;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = false;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.BackColor = Color.FromArgb(29, 53, 87);
            lblNgaySinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.ForeColor = SystemColors.Control;
            lblNgaySinh.Location = new Point(71, 509);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(126, 32);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.CustomFormat = "dd - MM - yyyy";
            dateNgaySinh.Enabled = false;
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.Location = new Point(308, 513);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(242, 27);
            dateNgaySinh.TabIndex = 11;
            dateNgaySinh.Value = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            // 
            // txtHang
            // 
            txtHang.Enabled = false;
            txtHang.Location = new Point(308, 729);
            txtHang.Name = "txtHang";
            txtHang.Size = new Size(242, 27);
            txtHang.TabIndex = 17;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.BackColor = Color.FromArgb(29, 53, 87);
            lblHang.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHang.ForeColor = SystemColors.Control;
            lblHang.Location = new Point(71, 723);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(197, 32);
            lblHang.TabIndex = 16;
            lblHang.Text = "Hạng thành viên:";
            // 
            // txtDiemTL
            // 
            txtDiemTL.Enabled = false;
            txtDiemTL.Location = new Point(308, 659);
            txtDiemTL.Name = "txtDiemTL";
            txtDiemTL.Size = new Size(242, 27);
            txtDiemTL.TabIndex = 15;
            // 
            // lblDiemTL
            // 
            lblDiemTL.AutoSize = true;
            lblDiemTL.BackColor = Color.FromArgb(29, 53, 87);
            lblDiemTL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiemTL.ForeColor = SystemColors.Control;
            lblDiemTL.Location = new Point(71, 653);
            lblDiemTL.Name = "lblDiemTL";
            lblDiemTL.Size = new Size(161, 32);
            lblDiemTL.TabIndex = 14;
            lblDiemTL.Text = "Điểm tích lũy:";
            // 
            // txtSDT
            // 
            txtSDT.Enabled = false;
            txtSDT.Location = new Point(308, 588);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(242, 27);
            txtSDT.TabIndex = 13;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.BackColor = Color.FromArgb(29, 53, 87);
            lblSDT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.ForeColor = SystemColors.Control;
            lblSDT.Location = new Point(71, 582);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(161, 32);
            lblSDT.TabIndex = 12;
            lblSDT.Text = "Số điện thoại:";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(69, 123, 157);
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(179, 803);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 37);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(69, 123, 157);
            btnCapNhat.Enabled = false;
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.Location = new Point(365, 803);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 37);
            btnCapNhat.TabIndex = 19;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(69, 123, 157);
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(551, 803);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(137, 37);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_manager;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(861, 875);
            Controls.Add(btnHuy);
            Controls.Add(btnCapNhat);
            Controls.Add(btnSua);
            Controls.Add(txtHang);
            Controls.Add(lblHang);
            Controls.Add(txtDiemTL);
            Controls.Add(lblDiemTL);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(dateNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDiaChi);
            Controls.Add(txtTenNguoiDung);
            Controls.Add(lblTenNguoiDung);
            Controls.Add(txtMaNguoiDung);
            Controls.Add(lblMaNguoiDung);
            Controls.Add(lblThongTinCaNhan);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormThongTinCaNhan";
            Text = "FormThongTinCaNhan";
            Load += FormThongTinCaNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongTinCaNhan;
        private Label lblMaNguoiDung;
        private TextBox txtMaNguoiDung;
        private Label lblTenNguoiDung;
        private TextBox txtTenNguoiDung;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private Label lblGioiTinh;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Label lblNgaySinh;
        private DateTimePicker dateNgaySinh;
        private TextBox txtHang;
        private Label lblHang;
        private TextBox txtDiemTL;
        private Label lblDiemTL;
        private TextBox txtSDT;
        private Label lblSDT;
        private Button btnSua;
        private Button btnCapNhat;
        private Button btnHuy;
    }
}