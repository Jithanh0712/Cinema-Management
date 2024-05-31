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
    public class BanHang
    {
        DBMain dbMain;

        public BanHang()
        {
            this.dbMain = new DBMain();
        }

        public void LayThongTinHangHoa(string MaHH, out string tenhh, out float dongia)
        {
            dbMain = null;
            dbMain = new DBMain();
            string query = "SELECT * FROM dbo.ThongTinHangHoa(@MaHH)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHH", SqlDbType.Char, 10);
            parameters[0].Value = MaHH;
            string error = string.Empty;
            DataTable result = dbMain.ExecuteQueryDataSet(query, CommandType.Text, parameters, ref error);

            if (result.Rows.Count > 0)
            {
                tenhh = result.Rows[0]["TenHH"].ToString();
                dongia = Convert.ToSingle(result.Rows[0]["DonGia"]);
            }
            else
            {
                tenhh = string.Empty;
                dongia = 0;
            }
        }
        public List<string> LayMaGG(string MaKH)
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSQL = "Select * from dbo.LayMaGGKhachHang(@MaKH)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.VarChar, 50) { Value = MaKH };
            string error = String.Empty;
            DataTable dt = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);
            List<string> magg = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                magg.Add(dr[0].ToString());
            }
            return magg;
        }

        public List<string> LayMaGGDK0()
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSQL = "Select * from dbo.LayMaGGChoTatCa()";
            string error = String.Empty;
            DataTable dt = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            List<string> magg = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                magg.Add(dr[0].ToString());
            }
            return magg;
        }

        public void LayMaHHTheoGG(string MaGG, out string maHH, out int giaTri, out string loaiGG)
        {
            dbMain = null;
            dbMain = new DBMain();
            string query = "SELECT * FROM dbo.LayMaHangHoaVaGiaTri(@MaGG)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaGG", SqlDbType.Char, 10);
            parameters[0].Value = MaGG;
            string error = string.Empty;
            DataTable result = dbMain.ExecuteQueryDataSet(query, CommandType.Text, parameters, ref error);

            if (result.Rows.Count > 0)
            {
                maHH = result.Rows[0]["MaHH"].ToString();
                giaTri = Convert.ToInt32(result.Rows[0]["GiaTri"]);
                loaiGG = result.Rows[0]["LoaiGG"].ToString();
            }
            else
            {
                maHH = string.Empty;
                giaTri = 0;
                loaiGG = "";
            }
        }

        public DataTable LayTTHHBapNuoc(DataTable dt)
        {
            DataTable dtHH = new DataTable();
            dtHH.Columns.Add("Loai", typeof(string));
            dtHH.Columns.Add("MaHH", typeof(string));
            dtHH.Columns.Add("TenHH", typeof(string));
            dtHH.Columns.Add("SL", typeof(int));
            dtHH.Columns.Add("TongTien", typeof(float));

            string error = string.Empty;
            string tenHH;
            float donGia;

            string query = "SELECT * FROM dbo.ThongTinHangHoa(@MaHH)";
            foreach (DataRow row in dt.Rows)
            {
                dbMain = null;
                dbMain = new DBMain();

                string maHH = row["MaHH"].ToString();
                int sl = Convert.ToInt32(row["SL"]);
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@MaHH", SqlDbType.Char, 10) { Value = maHH };
                DataTable result = dbMain.ExecuteQueryDataSet(query, CommandType.Text, parameters, ref error);
                if (result.Rows.Count > 0)
                {
                    tenHH = result.Rows[0]["TenHH"].ToString();
                    donGia = Convert.ToSingle(result.Rows[0]["DonGia"]);

                    float tongtien = donGia * sl;
                    dtHH.Rows.Add("Hàng hóa", maHH, tenHH, sl, tongtien);
                }
                else
                {
                    tenHH = String.Empty;
                    donGia = 0;
                }

            }
            return dtHH;
        }

    }
}
