using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapChieuPhim.DTO;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyLichChieu
    {
        DBMain dbMain = null;
        public QuanLyLichChieu()
        {
            dbMain = new DBMain();
        }

        public DataTable LayDanhSachLichChieu()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemLichChieu", CommandType.Text, null, ref error);
        }

        public bool ThemLichChieu(DTO_LichChieu LC)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemLichChieu";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ThoiGianChieu", SqlDbType.DateTime) { Value = LC.ThoiGianChieu };
            parameters[1] = new SqlParameter("@ThoiGianHet", SqlDbType.DateTime) { Value = LC.ThoiGianHet };
            parameters[2] = new SqlParameter("@MaPhong", SqlDbType.Char, 10) { Value = LC.MaPhong };
            parameters[3] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = LC.MaPhim };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaLichChieu(string MaLC)
        {
            string strSql = "XoaLichChieu";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaLC", SqlDbType.Char, 30) { Value = MaLC };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }

        public DataTable LayDSVe(string MaLC)
        {
            string strSQL = "Select* from dbo.LayDSVeTrongLichChieu(@MaLC)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaLC", SqlDbType.VarChar, 50) { Value = MaLC };
            string error = String.Empty;
            return dbMain.ExecuteQueryDataSet(strSQL,CommandType.Text,parameters, ref error);       
        }
    }
}
