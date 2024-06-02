using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RapChieuPhim.SourceCode
{
    public class DBMain
    {
        string ConnStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RAPCHIEUPHIM;User ID=thanhvienDBMS;Password=123;";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {      
            if (FormDangNhap.nguoiDung != null)
            { 
                ConnStr = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RAPCHIEUPHIM;User ID={FormDangNhap.nguoiDung.TaiKhoanLogin}" +
                    $";Password={FormDangNhap.nguoiDung.MatKhau};";
            }
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataTable ExecuteQueryDataSet(string strSQL, CommandType ct, SqlParameter[] parameters, ref string error)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, SqlParameter[] parameters, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();//Test copmmit
            }
            return f;
        }
    }
}
