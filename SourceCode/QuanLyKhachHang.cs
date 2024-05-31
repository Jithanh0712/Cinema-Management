using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Security.Cryptography.Xml;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyKhachHang
    {
        DBMain dbMain = null;
        public QuanLyKhachHang()
        {
            dbMain = new DBMain();
        }

        public DataTable LayDanhSachKhachHang()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemKhachHang", CommandType.Text, null, ref error);
        }

        public bool ThemKhachHang(DTO_KhachHang KH)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemKhachHang";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30) { Value = KH.HoTen };
            parameters[1] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = KH.DiaChi };
            parameters[2] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 10) { Value = KH.GioiTinh };
            parameters[3] = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = KH.NgaySinh };
            parameters[4] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = KH.SDT };
            parameters[5] = new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10) { Value = KH.MaTaiKhoan };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaKhachHang(string MaKH)
        {
            string strSql = "XoaKhachHang";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10) { Value = MaKH };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }
        public bool CapNhatKhachHang(DTO_KhachHang KH)
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSql = "CapNhatKhachHang";
            bool success = false;
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10) { Value = KH.MaKH };
            parameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30) { Value = KH.HoTen };
            parameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = KH.DiaChi };
            parameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 10) { Value = KH.GioiTinh };
            parameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = KH.NgaySinh };
            parameters[5] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = KH.SDT };
            
            success = dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }
            return success;
        }
    }
}
