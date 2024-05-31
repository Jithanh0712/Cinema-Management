namespace RapChieuPhim.Forms
{
    partial class FormLichChieu
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
            tctLichChieu = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tctLichChieu.SuspendLayout();
            SuspendLayout();
            // 
            // tctLichChieu
            // 
            tctLichChieu.Controls.Add(tabPage1);
            tctLichChieu.Controls.Add(tabPage2);
            tctLichChieu.Location = new Point(12, 12);
            tctLichChieu.Name = "tctLichChieu";
            tctLichChieu.SelectedIndex = 0;
            tctLichChieu.Size = new Size(1072, 515);
            tctLichChieu.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1064, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1031, 482);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormLichChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 218, 220);
            ClientSize = new Size(1092, 536);
            Controls.Add(tctLichChieu);
            Name = "FormLichChieu";
            Text = "FormLichChieu";
            tctLichChieu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tctLichChieu;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}