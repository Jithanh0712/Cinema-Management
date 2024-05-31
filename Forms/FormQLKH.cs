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

namespace RapChieuPhim.Forms
{
    public partial class FormQLKH : Form
    {
        public FormQLKH()
        {
            InitializeComponent();
        }

        private void tbcQLKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tbcQLKH.SelectedTab;

            if (selectedTabPage.Name == "tpQLHH")
            {
                QLHH hh = new QLHH();

                hh.Dock = DockStyle.Fill;

                selectedTabPage.Controls.Add(hh);
            }
            else if (selectedTabPage.Name == "tpQLNCC")
            {
                NhaCC ncc = new NhaCC();

                ncc.Dock = DockStyle.Fill;

                selectedTabPage.Controls.Add(ncc);
            }
        }
    }
}
