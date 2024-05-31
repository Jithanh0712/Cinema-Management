using RapChieuPhim.DTO;
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
    
    public class QuanLyNhanVien
    {
        DBMain dbMain = null;
        public QuanLyNhanVien()
        {
            dbMain = new DBMain();
        }

        public DataTable LayDanhSachNhanVien()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemNhanVien", CommandType.Text, null, ref error);
        }

        public bool ThemNhanVien(DTO_NhanVien NV)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemNhanVien";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30) { Value = NV.HoTen };
            parameters[1] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = NV.DiaChi };
            parameters[2] = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = NV.NgaySinh };
            parameters[3] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = NV.SDT };
            parameters[4] = new SqlParameter("@GioiTinh", SqlDbType.VarChar, 10) { Value = NV.GioiTinh };
            parameters[5] = new SqlParameter("@ChucVu", SqlDbType.VarChar, 20) { Value = NV.ChucVu };
            parameters[6] = new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10) { Value = NV.MaTaiKhoan };
            parameters[7] = new SqlParameter("@Luong", SqlDbType.Float) { Value = NV.Luong };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaNhanVien(string MaNV)
        {
            string strSql = "XoaNhanVien";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.Char, 10) { Value = MaNV };

            dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);
            return true;
        }
        public bool CapNhatNhanVien(DTO_NhanVien NV)
        {
            string strSql = "CapNhatNhanVien";
            CommandType ct = CommandType.StoredProcedure;
            string error = string.Empty;

            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.Char, 10) { Value = NV.MaNV };
            parameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30) { Value = NV.HoTen };
            parameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = NV.DiaChi };
            parameters[3] = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = NV.NgaySinh };
            parameters[4] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = NV.SDT };
            parameters[5] = new SqlParameter("@GioiTinh", SqlDbType.VarChar, 10) { Value = NV.GioiTinh };
            parameters[6] = new SqlParameter("@ChucVu", SqlDbType.VarChar, 20) { Value = NV.ChucVu };
            parameters[7] = new SqlParameter("@Luong", SqlDbType.Float) { Value = NV.Luong };

            bool success = dbMain.MyExecuteNonQuery(strSql, ct, parameters, ref error);

            if (success)
                return true;
            else
            {
                Console.WriteLine("Lỗi khi cập nhật nhân viên: " + error);
                return false;
            }
        }
    }
}
