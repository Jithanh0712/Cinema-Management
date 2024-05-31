using RapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    public class DangNhap
    {
        DBMain dbMain;
        public DangNhap()
        {
            dbMain = new DBMain();
        }

        public TaiKhoan TryLogin(string TenDN, string MK)
        {
            TaiKhoan nguoiDung = new TaiKhoan();
            DataTable dtTaiKhoan;
            int ketQua = 0;
            string maTaiKhoan = "";
            string phanQuyen = "";
            string strSQL = "Select * from dbo.DangNhap(@TaiKhoanLogin,@MatKhau)";
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@TaiKhoanLogin", SqlDbType.VarChar, 255) { Value = TenDN };
            parameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar, 255) { Value = MK };
            string error = string.Empty;
            dtTaiKhoan = dbMain.ExecuteQueryDataSet(strSQL, ct, parameters, ref error);
            if (dtTaiKhoan.Rows.Count > 0)
            {
                // Lấy giá trị từ DataTable
                ketQua = Convert.ToInt32(dtTaiKhoan.Rows[0]["KetQua"]);
                maTaiKhoan = dtTaiKhoan.Rows[0]["MaTaiKhoan"].ToString();
                phanQuyen = dtTaiKhoan.Rows[0]["PhanQuyen"].ToString();
            }
            else
            {
                error = "Không có dữ liệu trả về từ hàm.";
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
                return null;
            }
            if (ketQua == 1)
            {
                dbMain = null;
                dbMain = new DBMain();
                string errorLayMa = String.Empty;
                nguoiDung.MaTaiKhoan = maTaiKhoan;
                nguoiDung.PhanQuyen = phanQuyen;
                SqlParameter[] @params = new SqlParameter[]
                {
                    new SqlParameter("@MaTaiKhoan", SqlDbType.Char, 10)
                    {
                        Value = maTaiKhoan
                    },
                    new SqlParameter("@Result", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };
                if (phanQuyen == "KhachHang")
                    strSQL = "EXEC @Result = dbo.LayMaKH @MaTaiKhoan = @MaTaiKhoan; " +
                                      "SELECT @Result AS MaKH;";
                else
                    strSQL = "EXEC @Result = dbo.LayMaNV @MaTaiKhoan = @MaTaiKhoan; " +
                                      "SELECT @Result AS MaNV;";
                dbMain.MyExecuteNonQuery(strSQL, CommandType.Text, @params, ref errorLayMa);
                if (!string.IsNullOrEmpty(errorLayMa))
                {
                    MessageBox.Show(errorLayMa, "Lỗi");
                    return null;
                }
                nguoiDung.Id = @params[1].Value.ToString();
                nguoiDung.TaiKhoanLogin = TenDN;
                nguoiDung.MatKhau = MK;
            }
            else
                return null;
            return nguoiDung;
        }

        public bool KiemTraMaGG()
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            dbMain.MyExecuteNonQuery("dbo.KiemTraGiamGiaHetHan", CommandType.StoredProcedure, null, ref err);
            if(err != string.Empty)
            {
                MessageBox.Show(err);
            }
            return true;
        }
    }
}
