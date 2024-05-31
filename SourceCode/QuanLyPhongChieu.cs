using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyPhongChieu
    {
        DBMain dbMain;

        public QuanLyPhongChieu()
        {
            this.dbMain = new DBMain();
        }

        public List<string> LayTatCaMaPhong()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaMaPhong()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            dbMain = null;
            dbMain = new DBMain();
            List<string> maphongList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    maphongList.Add(row["MaPhong"].ToString());

            return maphongList;
        }

        public DataTable LayTatCaPhongChieu()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayPhongChieu()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            dbMain = null;
            dbMain = new DBMain();
            return dataTable;
        }

        public string TaoMaPhongChieuTuDong()
        {
            dbMain = null;
            dbMain = new DBMain();
            string maPhong = String.Empty;
            string error = string.Empty;
            string strSql = "SET @MaPhong = dbo.TaoMaPhongChieuTuDong();";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaPhong", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);
                if (parameters[0].Value != DBNull.Value)
                {
                    maPhong = parameters[0].Value.ToString();
                }
                else
                {
                    maPhong = "PC00000001";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return maPhong;
        }

        public void ThemPhongChieu(string maphong, int slvip, int slthuong, int sldoi)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.ThemPhongChieu";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaPhong", SqlDbType.Char, 10);
            parameters[0].Value = maphong;
            parameters[1] = new SqlParameter("@SLGheVIP", SqlDbType.Int);
            parameters[1].Value = slvip;
            parameters[2] = new SqlParameter("@SLGheThuong", SqlDbType.Int);
            parameters[2].Value = slthuong;
            parameters[3] = new SqlParameter("@SLGheDoi", SqlDbType.Int);
            parameters[3].Value = sldoi;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (err != string.Empty)
            {
                MessageBox.Show(err);
            }
        }

        public void CapNhatPhongChieu(string maphong, int slvip, int slthuong, int sldoi)
        {
            string err = string.Empty;
            string sqlString = "dbo.CapNhatPhongChieu";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaPhong", SqlDbType.Char, 10);
            parameters[0].Value = maphong;
            parameters[1] = new SqlParameter("@SLGheVIP", SqlDbType.Int);
            parameters[1].Value = slvip;
            parameters[2] = new SqlParameter("@SLGheThuong", SqlDbType.Int);
            parameters[2].Value = slthuong;
            parameters[3] = new SqlParameter("@SLGheDoi", SqlDbType.Int);
            parameters[3].Value = sldoi;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            if (err != string.Empty)
            {
                MessageBox.Show(err);
            }
        }
    }
}
