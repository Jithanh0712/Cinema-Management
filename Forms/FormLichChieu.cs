using RapChieuPhim.SourceCode;
using RapChieuPhim.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RapChieuPhim.Forms
{
    public partial class FormLichChieu : Form
    {
        QuanLyPhim qlPhim;
        public FormLichChieu(String[] MaPhim)
        {
            InitializeComponent();
            tctLichChieu.TabPages.Clear();
            DateTime currentDate = DateTime.Today;
            for (int i = 0; i < 4; i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = currentDate.ToString("dd/MM/yyyy");
                tctLichChieu.TabPages.Add(tabPage);
                tabPage.Controls.Add(new UCLichChieu(MaPhim, currentDate));
                currentDate = currentDate.AddDays(1);
            }
        }
        public FormLichChieu()
        {
            InitializeComponent();
            qlPhim = new QuanLyPhim();
            DataTable dt = qlPhim.LayDanhSachPhim();
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hoặc không load được dữ liệu","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            string[] MaPhim = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                MaPhim[i] = dt.Rows[i]["MaPhim"].ToString();
            tctLichChieu.TabPages.Clear();
            DateTime currentDate = DateTime.Now;
            for (int i = 0; i < 4; i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = currentDate.ToString("dd/MM/yyyy");
                tctLichChieu.TabPages.Add(tabPage);
                tabPage.Controls.Add(new UCLichChieu(MaPhim, currentDate));
                currentDate = currentDate.AddDays(1);
            }
        }
    }
}
