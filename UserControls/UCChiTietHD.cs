using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim.UserControls
{
    public partial class UCChiTietHD : UserControl
    {
        private List<Panel> panelList;

        public UCChiTietHD(String[] tenSP, int[] soLuong, float[] donGia)
        {
            InitializeComponent();
            panelList = new List<Panel>();
            this.pnlChiTietHD.Visible = false;
            for (int i = 0; i < tenSP.Length; i++)
            {
                Point point = new Point(this.pnlChiTietHD.Location.X, this.pnlChiTietHD.Location.Y + this.pnlChiTietHD.Height * i);
                panelList.Add(TaoPanel(point, i + 1, tenSP[i], soLuong[i], donGia[i] * (float)soLuong[i]));
                this.Controls.Add(panelList[i]);
            }
        }

        public Panel TaoPanel(Point p, int stt, String tenSP, int soLuong, float thanhTien)
        {
            Panel newPanel = new Panel();
            newPanel.AutoScroll = true;
            newPanel.Location = p;
            newPanel.Size = this.pnlChiTietHD.Size;

            Label Stt = new Label();
            Stt.AutoSize = true;
            Stt.Location = this.lblSTT.Location;
            Stt.Font = this.lblSTT.Font;
            Stt.Text = Convert.ToString(Stt);

            Label ten = new Label();
            ten.AutoSize = true;
            ten.Text = tenSP;
            ten.Location = this.lblTenSP.Location;
            ten.Font = this.lblTenSP.Font;

            Label sl = new Label();
            sl.AutoSize = true;
            sl.Text = Convert.ToString(soLuong);
            sl.Location = this.lblSL.Location;
            sl.Font = this.lblSL.Font;

            Label gia = new Label();
            gia.AutoSize = true;
            gia.Text = Convert.ToString(thanhTien);
            gia.Location = this.lblGia.Location;
            gia.Font = this.lblGia.Font;

            newPanel.Controls.Add(Stt);
            newPanel.Controls.Add(ten);
            newPanel.Controls.Add(sl);
            newPanel.Controls.Add(gia);
            return newPanel;
        }
    }
}
