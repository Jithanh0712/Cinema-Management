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
    //private List<Panel> panelList;
    public partial class UCLichSuTT : UserControl
    {
        private List<Panel> panelList;
        public UCLichSuTT(String[] mahd, DateTime[] thoigiantt, float[] tongtien)
        {
            InitializeComponent();
            panelList = new List<Panel>();
            this.pnlLichSuTT.Visible = false;
            for (int i = 0; i < mahd.Length; i++)
            {
                Point point = new Point(this.pnlLichSuTT.Location.X, this.pnlLichSuTT.Location.Y + this.pnlLichSuTT.Height * i);
                panelList.Add(TaoPanel(point, mahd[i], thoigiantt[i], tongtien[i]));
                this.Controls.Add(panelList[i]);
            }
        }

        public Panel TaoPanel(Point p, String mahd, DateTime thoigiantt, float tongtien)
        {
            Panel newPanel = new Panel();
            newPanel.AutoScroll = true;
            newPanel.Location = p;
            newPanel.Size = this.pnlLichSuTT.Size;

            Label Ma = new Label();
            Ma.AutoSize = true;
            Ma.Location = this.lblMaHD.Location;
            Ma.Font = this.lblMaHD.Font;
            Ma.Text = Convert.ToString(mahd);

            Label Time = new Label();
            Time.AutoSize = true;
            Time.Location = this.lblThoiGianThanhToan.Location;
            Time.Font = this.lblThoiGianThanhToan.Font;
            Time.Text = Convert.ToString(thoigiantt);

            Label tien = new Label();
            tien.AutoSize = true;
            tien.Text = Convert.ToString(tongtien);
            tien.Location = this.lblTongTien.Location;
            tien.Font = this.lblTongTien.Font;

            LinkLabel chitiet = new LinkLabel();
            chitiet.AutoSize = true;
            chitiet.Font = this.llblChiTiet.Font;
            chitiet.Location = this.llblChiTiet.Location;
            chitiet.Text = this.llblChiTiet.Text;
            chitiet.LinkClicked += llblChiTiet_LinkClicked;

            newPanel.Controls.Add(Ma);
            newPanel.Controls.Add(Time);
            newPanel.Controls.Add(tien);
            newPanel.Controls.Add(chitiet);
            return newPanel;
        }

        private void llblChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
