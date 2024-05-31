using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Reflection.Metadata;

namespace RapChieuPhim.SourceCode
{
    public class KhachHang
    {
        DBMain dbMain;
        public KhachHang()
        {
            this.dbMain = new DBMain();
        }
        public void LayThongTinPhim(out string maPhim_1, out string maPhim_2, out string maPhim_3, out string tenPhim_1, out string tenPhim_2, out string tenPhim_3)
        {
            string query = "SELECT * FROM dbo.LayTop3PhimDanhGiaCaoNhat()";
            string error = string.Empty;
            DataTable result = dbMain.ExecuteQueryDataSet(query, CommandType.Text, null, ref error);

            if (result.Rows.Count > 0)
            {
                maPhim_1 = result.Rows[0]["MaPhim"].ToString();
                maPhim_2 = result.Rows[1]["MaPhim"].ToString();
                maPhim_3 = result.Rows[2]["MaPhim"].ToString();
                tenPhim_1 = result.Rows[0]["TenPhim"].ToString();
                tenPhim_2 = result.Rows[1]["TenPhim"].ToString();
                tenPhim_3 = result.Rows[2]["TenPhim"].ToString();
            }
            else
            {
                maPhim_1 = string.Empty;
                maPhim_2 = string.Empty;
                maPhim_3 = string.Empty;
                tenPhim_1 = string.Empty;
                tenPhim_2 = string.Empty;
                tenPhim_3 = string.Empty;
            }
        }
    }
}
