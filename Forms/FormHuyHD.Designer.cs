namespace RapChieuPhim.Forms
{
    partial class FormHuyHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHuyHD));
            pictureBox1 = new PictureBox();
            lblHuyHD = new Label();
            pictureBox2 = new PictureBox();
            btnXoa = new Button();
            txtMaHD = new TextBox();
            lblMaHD = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHuyHD
            // 
            lblHuyHD.AutoSize = true;
            lblHuyHD.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblHuyHD.ForeColor = Color.FromArgb(241, 250, 238);
            lblHuyHD.Location = new Point(484, 239);
            lblHuyHD.Name = "lblHuyHD";
            lblHuyHD.Size = new Size(287, 60);
            lblHuyHD.TabIndex = 1;
            lblHuyHD.Text = "Hủy Hóa Đơn";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(532, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(168, 218, 220);
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(563, 489);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 49);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHD.Location = new Point(545, 412);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(186, 34);
            txtMaHD.TabIndex = 4;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaHD.ForeColor = Color.FromArgb(241, 250, 238);
            lblMaHD.Location = new Point(545, 338);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(186, 41);
            lblMaHD.TabIndex = 5;
            lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // FormHuyHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 3, 3);
            ClientSize = new Size(783, 574);
            Controls.Add(lblMaHD);
            Controls.Add(txtMaHD);
            Controls.Add(btnXoa);
            Controls.Add(pictureBox2);
            Controls.Add(lblHuyHD);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHuyHD";
            Text = "Hủy Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHuyHD;
        private PictureBox pictureBox2;
        private Button btnXoa;
        private TextBox txtMaHD;
        private Label lblMaHD;
    }
}