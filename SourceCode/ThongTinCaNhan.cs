using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim.SourceCode
{
    internal class ThongTinCaNhan
    {
        DBMain dbMain;
        public ThongTinCaNhan()
        {
            dbMain = new DBMain();
        }

        public ThongTin getThongTinKhachHang(string id)
        {
            ThongTin khachhang = new ThongTin();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayThongTinKhachHang(@MaKH)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10);
            parameters[0].Value = id;
            DataTable dt = new DataTable();
            dt = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            if (dt.Rows.Count != 0)
            {
                khachhang.MaNguoiDung = Convert.ToString(dt.Rows[0][0]);
                khachhang.Hoten = Convert.ToString(dt.Rows[0][1]);
                khachhang.Diachi = Convert.ToString(dt.Rows[0][2]);
                khachhang.Gioitinh = Convert.ToString(dt.Rows[0][3]);
                khachhang.NgaySinh = Convert.ToDateTime(dt.Rows[0][4]);
                khachhang.Sdt = Convert.ToString(dt.Rows[0][5]);
                khachhang.DiemTL = Convert.ToInt32(dt.Rows[0][6]);
                khachhang.LoaiKH = Convert.ToString(dt.Rows[0][7]);
            }
            return khachhang;
        }
        public ThongTin getThongTinNhanVien(string id)
        {
            ThongTin nhanvien = new ThongTin();
            string err = string.Empty;
            string sqlString = "SELECT * FROM dbo.LayThongTinNhanVien(@MaNV)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.Char, 10);
            parameters[0].Value = id;
            DataTable dt = new DataTable();
            dt = dbMain.ExecuteQueryDataSet(sqlString, CommandType.Text, parameters, ref err);
            dbMain = null;
            dbMain = new DBMain();
            if (dt.Rows.Count != 0)
            {
                nhanvien.MaNguoiDung = Convert.ToString(dt.Rows[0][0]);
                nhanvien.Hoten = Convert.ToString(dt.Rows[0][1]);
                nhanvien.Diachi = Convert.ToString(dt.Rows[0][2]);
                nhanvien.Gioitinh = Convert.ToString(dt.Rows[0][5]);
                nhanvien.NgaySinh = Convert.ToDateTime(dt.Rows[0][3]);
                nhanvien.Sdt = Convert.ToString(dt.Rows[0][4]);
            }
            return nhanvien;
        }
        public bool updateThongTinKhachHang(string id, string ten, string diachi, string gioitinh, string ngaysinh, string sdt, ThongTin khachhang)
        {
            string err = string.Empty;
            string sqlString = "dbo.CapNhatThongTinKhachHang";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaKH", SqlDbType.Char, 10);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            parameters[1].Value = ten;
            parameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255);
            parameters[2].Value = diachi;
            parameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 10);
            parameters[3].Value = gioitinh;
            parameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            parameters[4].Value = ngaysinh;
            parameters[5] = new SqlParameter("@SDT", SqlDbType.VarChar, 10);
            parameters[5].Value = sdt;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (err != string.Empty)
            {
                MessageBox.Show(err);
            }
            dbMain = null;
            dbMain = new DBMain();
            khachhang.Hoten = ten;
            khachhang.Diachi = diachi;
            khachhang.Gioitinh = gioitinh;
            khachhang.NgaySinh = Convert.ToDateTime(ngaysinh);
            khachhang.Sdt = sdt;
            return true;
        }
        public bool updateThongTinNhanVien(string id, string ten, string diachi, string gioitinh, string ngaysinh, string sdt, ThongTin nhanvien)
        {
            string err = string.Empty;
            string sqlString = "dbo.CapNhatThongTinNhanVien";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.Char, 10);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            parameters[1].Value = ten;
            parameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255);
            parameters[2].Value = diachi;
            parameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 10);
            parameters[3].Value = gioitinh;
            parameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            parameters[4].Value = ngaysinh;
            parameters[5] = new SqlParameter("@SDT", SqlDbType.VarChar, 10);
            parameters[5].Value = sdt;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (err != string.Empty)
            {
                MessageBox.Show(err);
            }
            dbMain = null;
            dbMain = new DBMain();
            nhanvien.Hoten = ten;
            nhanvien.Diachi = diachi;
            nhanvien.Gioitinh = gioitinh;
            nhanvien.NgaySinh = Convert.ToDateTime(ngaysinh);
            nhanvien.Sdt = sdt;
            return true;
        }
    }
}
