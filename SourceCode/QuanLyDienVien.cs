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
    public class QuanLyDienVien
    {
        DBMain dbMain;
        public QuanLyDienVien()
        {
            this.dbMain = new DBMain();
        }
        public bool ThemDienVien(DTO_DienVien DV)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemDienVien";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaDV", SqlDbType.Char, 10) { Value = DV.MaDV };
            parameters[1] = new SqlParameter("@TenDV", SqlDbType.NVarChar, 30) { Value = DV.TenDV };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public string TaoMaDVTuDong()
        {
            string maDV = "";
            string error = string.Empty;
            string strSql = "SET @MaDV = dbo.TaoMaDVTuDong();";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaDV", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);
                if (parameters[0].Value != DBNull.Value)
                {
                    maDV = parameters[0].Value.ToString();
                }
                else
                {
                    maDV = "DV00000001";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return maDV;
        }
        public string LayMaDV(string tenDV)
        {
            string MaDV = "";
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDV", SqlDbType.NVarChar, 30)
                {
                    Value = tenDV
                },
                new SqlParameter("@Result", SqlDbType.Char, 10)
                {
                    Direction = ParameterDirection.Output
                }
            };
            string strSql = "EXEC @Result = dbo.LayMaDV @TenDV = @TenDV; " +
                                      "SELECT @Result AS MaDV;"; 
            dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
                return null;
            }

            MaDV = parameters[1].Value.ToString();

            return MaDV;
        }
    }
}
