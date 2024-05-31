namespace RapChieuPhim.UserControls
{
    partial class UCLichChieu
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
            pnlLichChieu = new Panel();
            btnGioChieu = new Button();
            lblTenPhim = new Label();
            picPhim = new PictureBox();
            pnlLichChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPhim).BeginInit();
            SuspendLayout();
            // 
            // pnlLichChieu
            // 
            pnlLichChieu.Controls.Add(btnGioChieu);
            pnlLichChieu.Controls.Add(lblTenPhim);
            pnlLichChieu.Controls.Add(picPhim);
            pnlLichChieu.Location = new Point(6, 6);
            pnlLichChieu.Name = "pnlLichChieu";
            pnlLichChieu.Size = new Size(1028, 162);
            pnlLichChieu.TabIndex = 0;
            // 
            // btnGioChieu
            // 
            btnGioChieu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGioChieu.Location = new Point(133, 89);
            btnGioChieu.Name = "btnGioChieu";
            btnGioChieu.Size = new Size(96, 58);
            btnGioChieu.TabIndex = 2;
            btnGioChieu.Text = "17:00";
            btnGioChieu.UseVisualStyleBackColor = true;
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenPhim.Location = new Point(133, 17);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(254, 46);
            lblTenPhim.TabIndex = 1;
            lblTenPhim.Text = "Day la ten phim";
            // 
            // picPhim
            // 
            picPhim.Location = new Point(13, 17);
            picPhim.Name = "picPhim";
            picPhim.Size = new Size(100, 130);
            picPhim.TabIndex = 0;
            picPhim.TabStop = false;
            // 
            // UCLichChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(241, 250, 238);
            Controls.Add(pnlLichChieu);
            Name = "UCLichChieu";
            Size = new Size(1064, 482);
            pnlLichChieu.ResumeLayout(false);
            pnlLichChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLichChieu;
        private PictureBox picPhim;
        private Label lblTenPhim;
        private Button btnGioChieu;
    }
}
