using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class QLLichSuTT
    {
        DBMain dbMain;
        public QLLichSuTT()
        {
            dbMain = new DBMain();
        }

        public DataTable getLichSuTT(string id)
        {
            DataTable lichsu = new DataTable();
            string err = string.Empty;
            string sqlString;
            SqlParameter[] parameters = new SqlParameter[1];
            if (id.Contains("KH"))
            {
                sqlString = "SELECT * FROM dbo.LayLichSuTTKH(@MaKH)";
                parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10);
                parameters[0].Value = id;
            }
            else
            {
                sqlString = "SELECT * FROM dbo.LayLichSuTTNV(@MaNV)";
                parameters[0] = new SqlParameter("@MaNV", SqlDbType.Char, 10);
                parameters[0].Value = id;
            }
            lichsu = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            return lichsu;
        }

        public DataTable getChiTietHH(string mahd)
        {
            DataTable chitiet = new DataTable();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayChiTietHDHH(@MaHD)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[0].Value = mahd;
            chitiet = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            return chitiet;
        }

        public DataTable getChiTietVe(string mahd)
        {
            DataTable chitiet = new DataTable();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayChiTietHDVe(@MaHD)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[0].Value = mahd;
            chitiet = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            foreach (DataRow dr in chitiet.Rows)
            {
                string temp = Convert.ToString(dr[0]);
                dr[0] = "Ve " + temp;
            }
            return chitiet;
        }
        public DataTable getChiTiet(string mahd)
        {
            DataTable chitiethh = new DataTable();
            DataTable chitietve = new DataTable();
            DataTable chitiet = new DataTable();
            chitiethh = getChiTietHH(mahd);
            chitietve = getChiTietVe(mahd);
            DataColumn TenColumn = new DataColumn("Tên", typeof(string));
            DataColumn SLColumn = new DataColumn("Số lượng", typeof(int));
            DataColumn TongColumn = new DataColumn("Tổng tiền", typeof(float));
            chitiet.Columns.Add(TenColumn);
            chitiet.Columns.Add(SLColumn);
            chitiet.Columns.Add(TongColumn);
            foreach (DataRow dr in chitiethh.Rows)
            {
                chitiet.Rows.Add(dr[0], dr[1], dr[2]);
            }
            foreach(DataRow dr in chitietve.Rows)
            {
                chitiet.Rows.Add(dr[0], dr[1], dr[2]);    
            }
            return chitiet;
        }
        
        public DataTable getChiTietHD(string mahd)
        {
            DataTable chitiet = new DataTable();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayChiTietHD(@MaHD)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[0].Value = mahd;
            chitiet = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            return chitiet;
        }

        public DataTable getDiemTL(string makh)
        {
            DataTable chitiet = new DataTable();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayDiemTL(@MaKH)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10);
            parameters[0].Value = makh;
            chitiet = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            return chitiet;
        }
    }
}
