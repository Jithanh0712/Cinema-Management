using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class DangKy
    {
        DBMain dbMain;
        public DangKy() { this.dbMain = new DBMain(); }

        public bool DangKyKH(String hoTen, DateTime ngaySinh, bool gioiTinh, String diaChi,
            string sdt,string tk, string mk)
        {
            dbMain = null;
            dbMain = new DBMain();
            QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
            string matk = qltk.TaoMaTaiKhoanTuDong();
            DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan(matk, tk, mk, "KhachHang");
            if(!qltk.ThemTaiKhoan(taiKhoan))
                return false;

            bool result = true;
            string strSQL = "dbo.ThemKhachHang";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30) { Value = hoTen };
            parameters[1] = new SqlParameter("@DiaChi",SqlDbType.NVarChar,255) { Value = diaChi};
            parameters[2] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar,10) { Value = gioiTinh ? "Nữ" : "Nam" };
            parameters[3] = new SqlParameter("@NgaySinh", SqlDbType.Date, 10) { Value = ngaySinh };
            parameters[4] = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = sdt };
            parameters[5] = new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10) { Value = matk };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
                result = false;
            }
            
            return result;
        }

    }
}
