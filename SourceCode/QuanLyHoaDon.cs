using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyHoaDon
    {
        DBMain dbMain = null;
        public QuanLyHoaDon()
        {
            dbMain = new DBMain();
        }
        public bool XoaHoaDon(string MaHD)
        {
            string strSql = "XoaHoaDon";
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10) { Value = MaHD };

            dbMain.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref error);
            return true;
        }
    }
}
