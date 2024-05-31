namespace RapChieuPhim.Forms
{
    partial class FormTimKiemPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiemPhim));
            btnSearch = new Button();
            txtSearch = new TextBox();
            pnlChiTietPhim = new Panel();
            pnlTheLoai = new Panel();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(949, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 63);
            btnSearch.TabIndex = 0;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(113, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(814, 63);
            txtSearch.TabIndex = 1;
            // 
            // pnlChiTietPhim
            // 
            pnlChiTietPhim.BackColor = Color.FromArgb(241, 250, 238);
            pnlChiTietPhim.Location = new Point(26, 180);
            pnlChiTietPhim.Name = "pnlChiTietPhim";
            pnlChiTietPhim.Size = new Size(1209, 561);
            pnlChiTietPhim.TabIndex = 4;
            // 
            // pnlTheLoai
            // 
            pnlTheLoai.BackColor = Color.White;
            pnlTheLoai.Location = new Point(113, 86);
            pnlTheLoai.Name = "pnlTheLoai";
            pnlTheLoai.Size = new Size(814, 81);
            pnlTheLoai.TabIndex = 5;
            // 
            // FormTimKiemPhim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 218, 220);
            ClientSize = new Size(1262, 753);
            Controls.Add(pnlTheLoai);
            Controls.Add(pnlChiTietPhim);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTimKiemPhim";
            Text = "Tìm Kiếm Phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlChiTietPhim;
        private Panel pnlTheLoai;
    }
}