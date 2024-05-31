using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyGiamGia
    {
        DBMain dbMain = null;
        public QuanLyGiamGia()
        {
            dbMain = new DBMain();
        }

        public DataTable LayGiamGia()
        {
            dbMain = null;
            dbMain = new DBMain();
            DataTable dt = new DataTable();
            string err = string.Empty;
            string sqlString = "SELECT * FROM XemGiamGia";
            dt = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, null, ref err);
            return dt;
        }

        public string TaoMaGiamGiaTuDong()
        {
            dbMain = null;
            dbMain = new DBMain();
            string magg = string.Empty;
            string err = string.Empty;
            string sqlString = "SELECT * FROM XemGiamGia";
            string strSql = "SET @MaGG = dbo.TaoMaGiamGiaTuDong();";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaGG", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref err);
                if (parameters[0].Value != DBNull.Value)
                {
                    magg = parameters[0].Value.ToString();
                }
                else
                {
                    magg = "GG00000001";
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return magg;
        }

        public void ThemGiamGia(string magg, string loaigg, string mahh, int giatri, string ngayhet, int dieukien, string manql)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.ThemGiamGia";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MaGG", SqlDbType.Char, 10);
            parameters[0].Value = magg;
            parameters[1] = new SqlParameter("@LoaiGG", SqlDbType.VarChar, 20);
            parameters[1].Value = loaigg;
            parameters[2] = new SqlParameter("@MaHH", SqlDbType.Char, 10);
            parameters[2].Value = mahh;
            parameters[3] = new SqlParameter("@GiaTri", SqlDbType.Int);
            parameters[3].Value = giatri;
            parameters[4] = new SqlParameter("@NgayHet", SqlDbType.Date, 10);
            parameters[4].Value = ngayhet;
            parameters[5] = new SqlParameter("@DieuKien", SqlDbType.Int);
            parameters[5].Value = dieukien;
            parameters[6] = new SqlParameter("@MaNQL", SqlDbType.Char, 10);
            parameters[6].Value = manql;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (err != string.Empty)
            {
                MessageBox.Show(err);
            }
        }

        public void CapNhatGiamGia(string magg, string loaigg, string mahh, int giatri, string ngayhet, int dieukien)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.CapNhatGiamGia";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaGG", SqlDbType.Char, 10);
            parameters[0].Value = magg;
            parameters[1] = new SqlParameter("@LoaiGG", SqlDbType.VarChar, 20);
            parameters[1].Value = loaigg;
            parameters[2] = new SqlParameter("@MaHH", SqlDbType.Char, 10);
            parameters[2].Value = mahh;
            parameters[3] = new SqlParameter("@GiaTri", SqlDbType.Int);
            parameters[3].Value = giatri;
            parameters[4] = new SqlParameter("@NgayHet", SqlDbType.Date, 10);
            parameters[4].Value = ngayhet;
            parameters[5] = new SqlParameter("@DieuKien", SqlDbType.Int);
            parameters[5].Value = dieukien;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if(err != string.Empty)
            {
                MessageBox.Show(err);
            }
        }

        public void XoaGiamGia(string magg)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.XoaGiamGia";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaGG", SqlDbType.Char, 10);
            parameters[0].Value = magg;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
        }
    }
}
