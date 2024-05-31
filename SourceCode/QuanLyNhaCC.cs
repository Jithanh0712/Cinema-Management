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
    public class QuanLyNhaCC
    {
        DBMain dbMain = null;
        public QuanLyNhaCC()
        {
            dbMain = new DBMain();
        }
        public List<string> LayTatCaMaNCC()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaMaNCC()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            dbMain = null;
            dbMain = new DBMain();
            List<string> manccList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    manccList.Add(row["MaNCC"].ToString());

            return manccList;
        }
        public DataTable LayDanhSachNhaCC()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemNhaCC", CommandType.Text, null, ref error);
        }

        public bool ThemNhaCC(DTO_NhaCC NCC)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemNhaCungCap";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@TenNCC", SqlDbType.NVarChar, 30) { Value = NCC.TenNCC };
            parameters[1] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = NCC.DiaChi };
            parameters[2] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = NCC.SDT };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaNhaCC(string MaNCC)
        {
            string strSql = "XoaNhaCungCap";
            string error = string.Empty;
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNCC", SqlDbType.Char, 10) { Value = MaNCC };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }
    }
}
