namespace RapChieuPhim.Forms
{
    partial class FormLichSuTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichSuTT));
            dgvLichSuTT = new DataGridView();
            btnTroVe = new Button();
            btnChiTiet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuTT).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSuTT
            // 
            dgvLichSuTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuTT.Location = new Point(12, 94);
            dgvLichSuTT.Name = "dgvLichSuTT";
            dgvLichSuTT.RowHeadersWidth = 51;
            dgvLichSuTT.RowTemplate.Height = 29;
            dgvLichSuTT.Size = new Size(656, 373);
            dgvLichSuTT.TabIndex = 0;
            dgvLichSuTT.CellClick += dgvLichSuTT_CellClick;
            dgvLichSuTT.CellContentDoubleClick += dgvLichSuTT_CellContentDoubleClick;
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(168, 218, 220);
            btnTroVe.Location = new Point(12, 12);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(94, 29);
            btnTroVe.TabIndex = 1;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnChiTiet
            // 
            btnChiTiet.AutoSize = true;
            btnChiTiet.BackColor = Color.FromArgb(168, 218, 220);
            btnChiTiet.Location = new Point(570, 58);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(98, 30);
            btnChiTiet.TabIndex = 2;
            btnChiTiet.Text = "Xem chi tiết";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // FormLichSuTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 53, 87);
            ClientSize = new Size(680, 479);
            Controls.Add(btnChiTiet);
            Controls.Add(btnTroVe);
            Controls.Add(dgvLichSuTT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLichSuTT";
            Text = "FormLichSuTT";
            Load += FormLichSuTT_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSuTT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLichSuTT;
        private Button btnTroVe;
        private Button btnChiTiet;
    }
}