namespace RapChieuPhim.Forms
{
    partial class FormPhongChieu
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
            pnlGhes = new Panel();
            panel2 = new Panel();
            lblManHinh = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGhes
            // 
            pnlGhes.BackColor = Color.FromArgb(168, 218, 220);
            pnlGhes.ForeColor = Color.FromArgb(241, 250, 238);
            pnlGhes.Location = new Point(11, 65);
            pnlGhes.Name = "pnlGhes";
            pnlGhes.Size = new Size(1200, 728);
            pnlGhes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 53, 87);
            panel2.Controls.Add(lblManHinh);
            panel2.Location = new Point(12, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 55);
            panel2.TabIndex = 1;
            // 
            // lblManHinh
            // 
            lblManHinh.AutoSize = true;
            lblManHinh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblManHinh.Location = new Point(529, 5);
            lblManHinh.Name = "lblManHinh";
            lblManHinh.Size = new Size(180, 41);
            lblManHinh.TabIndex = 0;
            lblManHinh.Text = "MÀN HÌNH";
            // 
            // FormPhongChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 250, 238);
            ClientSize = new Size(1219, 795);
            Controls.Add(panel2);
            Controls.Add(pnlGhes);
            ForeColor = Color.FromArgb(241, 250, 238);
            Name = "FormPhongChieu";
            Text = "Phòng Chiếu";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGhes;
        private Panel panel2;
        private Label lblManHinh;
    }
}