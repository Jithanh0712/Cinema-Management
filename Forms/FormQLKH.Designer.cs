namespace RapChieuPhim.Forms
{
    partial class FormQLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKH));
            tbcQLKH = new TabControl();
            tpQLHH = new TabPage();
            tpQLNCC = new TabPage();
            tbcQLKH.SuspendLayout();
            SuspendLayout();
            // 
            // tbcQLKH
            // 
            tbcQLKH.Controls.Add(tpQLHH);
            tbcQLKH.Controls.Add(tpQLNCC);
            tbcQLKH.Location = new Point(-1, -1);
            tbcQLKH.Name = "tbcQLKH";
            tbcQLKH.SelectedIndex = 0;
            tbcQLKH.Size = new Size(1032, 800);
            tbcQLKH.TabIndex = 0;
            tbcQLKH.SelectedIndexChanged += tbcQLKH_SelectedIndexChanged;
            // 
            // tpQLHH
            // 
            tpQLHH.BackColor = Color.FromArgb(222, 192, 146);
            tpQLHH.Location = new Point(4, 29);
            tpQLHH.Name = "tpQLHH";
            tpQLHH.Padding = new Padding(3);
            tpQLHH.Size = new Size(1024, 767);
            tpQLHH.TabIndex = 0;
            tpQLHH.Text = "Quản Lý Hàng Hóa";
            // 
            // tpQLNCC
            // 
            tpQLNCC.BackColor = Color.FromArgb(222, 192, 146);
            tpQLNCC.Location = new Point(4, 29);
            tpQLNCC.Name = "tpQLNCC";
            tpQLNCC.Padding = new Padding(3);
            tpQLNCC.Size = new Size(1008, 767);
            tpQLNCC.TabIndex = 1;
            tpQLNCC.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // FormQLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 192, 146);
            ClientSize = new Size(1031, 799);
            Controls.Add(tbcQLKH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQLKH";
            Text = "Quản Lý Kho Hàng";
            tbcQLKH.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcQLKH;
        private TabPage tpQLHH;
        private TabPage tpQLNCC;

    }
}