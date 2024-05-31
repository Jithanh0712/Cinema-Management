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
using System.Windows.Forms.VisualStyles;

namespace RapChieuPhim.Forms
{
    public partial class FormTimKiemPhim : Form
    {
        QuanLyPhim qlPhim;
        List<string> dsTheLoai;
        public FormTimKiemPhim()
        {
            InitializeComponent();
            qlPhim = new QuanLyPhim();
            dsTheLoai = new List<string>();
            KhoiTaoCheckBoxTheLoai();
        }

        private void KhoiTaoCheckBoxTheLoai()
        {
            // Khởi tạo CheckListBox
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;

            dsTheLoai = qlPhim.LayTatCaTheLoaiPhim();
            pnlTheLoai.Controls.Clear();
            foreach (string theLoai in dsTheLoai)
            {
                CheckBox checkBox = new CheckBox() { Text = theLoai, AutoSize = true };
                checkBox.MinimumSize = new Size(100, 20);
                checkBox.MaximumSize = new Size(150, 30);
                checkBox.Font = new Font("Segoe UI", 10);
                flowLayoutPanel.Controls.Add(checkBox);
            }
            pnlTheLoai.Controls.Add(flowLayoutPanel);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            this.pnlChiTietPhim.Controls.Clear();
            DataTable dtPhim = new DataTable();
            DataTable dtLoai = new DataTable();
            List<string> dsTheLoai = this.TheLoaiDuocChon();
            dtPhim = qlPhim.LayDanhSachPhim();
            if (txtSearch.Text.Trim() != "") 
            {
                dtPhim = qlPhim.DSPhimTheoTen(txtSearch.Text.Trim());
            }
            if(dsTheLoai.Count() != 0)
            {
                dtLoai = qlPhim.DSPhimTheoTheLoai(dsTheLoai);
                if (txtSearch.Text.Trim() == "")
                    dtPhim = dtLoai;
            }
            if(txtSearch.Text.Trim() != "" && dsTheLoai.Count() != 0)
            {
                dtPhim.PrimaryKey = new DataColumn[] { dtPhim.Columns["MaPhim"] };
                dtLoai.PrimaryKey = new DataColumn[] { dtLoai.Columns["MaPhim"] };
                dtPhim.Merge(dtLoai, true, MissingSchemaAction.Add);
            }
            Dictionary<string, DataRow> uniqueValues = new Dictionary<string, DataRow>();

            foreach (DataRow row in dtPhim.Rows)
            {
                string maPhim = row["MaPhim"].ToString();

                if (!uniqueValues.ContainsKey(maPhim))
                {
                    uniqueValues.Add(maPhim, row);
                }
            }
            DataTable distinctDtPhim = dtPhim.Clone();
            foreach (var kvp in uniqueValues)
            {
                distinctDtPhim.ImportRow(kvp.Value);
            }
            dtPhim = qlPhim.DSNgayKhoiChieu(distinctDtPhim);
            this.pnlChiTietPhim.Controls.Add(new UCChiTietPhim(dtPhim));
        }

        private List<string> TheLoaiDuocChon()
        {
            List<string> theLoai = new List<string>();
            foreach (Control containerControl in pnlTheLoai.Controls)
                if (containerControl is FlowLayoutPanel flowLayoutPanel)
                    foreach (Control control in flowLayoutPanel.Controls)
                        if (control is CheckBox checkBox && checkBox.Checked)
                            theLoai.Add(checkBox.Text);
            return theLoai;
        }
    }
}
