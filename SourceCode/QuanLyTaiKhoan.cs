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
    public class QuanLyTaiKhoan
    {
        DBMain dbMain;
        public QuanLyTaiKhoan()
        {
            this.dbMain = new DBMain();
        }
        public bool ThemTaiKhoan(DTO_TaiKhoan TK)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemTaiKhoan";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10) { Value = TK.MaTaiKhoan };
            parameters[1] = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 255) { Value = TK.TaiKhoan };
            parameters[2] = new SqlParameter("@MatKhau", SqlDbType.VarChar, 255) { Value = TK.MatKhau };
            parameters[3] = new SqlParameter("@PhanQuyen", SqlDbType.VarChar, 50) { Value = TK.PhanQuyen };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
                return false;
            }

            return result;
        }
        public string TaoMaTaiKhoanTuDong()
        {
            dbMain = null;
            dbMain = new DBMain();
            string maTaiKhoan = "";
            string error = string.Empty;
            CommandType ct = CommandType.Text;
            string strSql = "SET @MaTaiKhoan = dbo.TaoMaTaiKhoanTuDong()";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);

                if (parameters[0].Value != DBNull.Value)
                {
                    maTaiKhoan = parameters[0].Value.ToString();
                }
                else
                {
                    maTaiKhoan = "TK00000001";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return maTaiKhoan;
        }
        public bool XoaTaiKhoan(string MaTaiKhoan)
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSql = "XoaTaiKhoan";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10) { Value = MaTaiKhoan };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }
    }
}
