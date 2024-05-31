using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyHangHoa
    {
        DBMain dbMain = null;
        public QuanLyHangHoa()
        {
            dbMain = new DBMain();
        }

        public DataTable LayDanhSachHangHoa()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemHangHoa", CommandType.Text, null, ref error);
        }

        public bool ThemHangHoa(DTO_HangHoa HH)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemHangHoa";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@TenHH", SqlDbType.NVarChar, 30) { Value = HH.TenHH };
            parameters[1] = new SqlParameter("@DonGia", SqlDbType.Float) { Value = HH.DonGia };
            parameters[2] = new SqlParameter("@SLTon", SqlDbType.Int) { Value = HH.SLTon };
            parameters[3] = new SqlParameter("@NhaCC", SqlDbType.Char, 10) { Value = HH.NhaCC };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaHangHoa(string MaHH)
        {
            string strSql = "XoaHangHoa";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHH", SqlDbType.Char, 10) { Value = MaHH };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }
        public bool CapNhatHangHoa(DTO_HangHoa HH)
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSql = "CapNhatHangHoa";
            bool success = false;
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaHH", SqlDbType.Char, 10) { Value = HH.MaHH };
            parameters[1] = new SqlParameter("@TenHH", SqlDbType.NVarChar, 30) { Value = HH.TenHH };
            parameters[2] = new SqlParameter("@DonGia", SqlDbType.Float) { Value = HH.DonGia };
            parameters[3] = new SqlParameter("@SLTon", SqlDbType.Int) { Value = HH.SLTon };
            parameters[4] = new SqlParameter("@NhaCC", SqlDbType.Char, 10) { Value = HH.NhaCC };

            success = dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return success;
        }
        public List<string> LayTatCaMaHangHoa()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaMaHangHoa()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            dbMain = null;
            dbMain = new DBMain();
            List<string> maphimList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    maphimList.Add(row["MaHH"].ToString());

            return maphimList;
        }
    }
}
