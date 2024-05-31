using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Reflection.Metadata;

namespace RapChieuPhim.SourceCode
{
    public class ThanhToan
    {
        DBMain dbMain;

        public ThanhToan()
        {
            this.dbMain = new DBMain();
        }
        public string TaoMaHoaDonTuDong()
        {
            dbMain = null;
            dbMain = new DBMain();
            string maHD = String.Empty;
            string error = string.Empty;
            string strSql = "SET @MaHD = dbo.TaoMaHoaDonTuDong();";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaHD", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);
                if (parameters[0].Value != DBNull.Value)
                {
                    maHD = parameters[0].Value.ToString();
                }
                else
                {
                    maHD = "HD00000001";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return maHD;
        }

        public bool ThemHoaDon(string maHD, DateTime thoiGian, float tongTien, string phuongThucTT, string maKH, string maNV, string maGG)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.ThemHoaDon";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[0].Value = maHD;
            parameters[1] = new SqlParameter("@ThoiGian", SqlDbType.DateTime);
            parameters[1].Value = thoiGian;
            parameters[2] = new SqlParameter("@TongTien", SqlDbType.Float);
            parameters[2].Value = tongTien;
            parameters[3] = new SqlParameter("@PhuongThucTT", SqlDbType.VarChar, 20);
            parameters[3].Value = phuongThucTT;
            parameters[4] = new SqlParameter("@MaKH", SqlDbType.VarChar, 10);
            parameters[4].Value = maKH;
            parameters[5] = new SqlParameter("@MaNV", SqlDbType.VarChar, 10);
            parameters[5].Value = maNV;
            parameters[6] = new SqlParameter("@MaGG", SqlDbType.VarChar, 10);
            parameters[6].Value = maGG;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi");
                return false;
            }
            return true;
        }

        public bool ThemChiTietHD(string maHD, string maHH, int SL, float tongTien)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.ThemCHITIETHDHH";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[0].Value = maHD;
            parameters[1] = new SqlParameter("@MaHH", SqlDbType.Char, 10);
            parameters[1].Value = maHH;
            parameters[2] = new SqlParameter("@SL", SqlDbType.Int);
            parameters[2].Value = SL;
            parameters[3] = new SqlParameter("@TongTien", SqlDbType.Float);
            parameters[3].Value = tongTien;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi");
                return false;
            }
            return true;
        }


        public void CapNhatMaHD(string maVe, string maHD)
        {
            dbMain = null;
            dbMain = new DBMain();
            string err = string.Empty;
            string sqlString = "dbo.CapNhatMaHDVaTrangThai";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaVe", SqlDbType.Char, 36);
            parameters[0].Value = maVe;
            parameters[1] = new SqlParameter("@MaHD", SqlDbType.Char, 10);
            parameters[1].Value = maHD;
            parameters[2] = new SqlParameter("@TrangThai", SqlDbType.Bit);
            parameters[2].Value = 1;
            dbMain.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, parameters, ref err);
        }

        public void LayThongTinVe(string maVe, out string loaiVe, out float gia)
        {
            dbMain = null;
            dbMain = new DBMain();
            string query = "SELECT * FROM dbo.ThongTinVe(@MaVe)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaVe", SqlDbType.Char, 36);
            parameters[0].Value = maVe;
            string error = string.Empty;
            DataTable result = dbMain.ExecuteQueryDataSet(query, CommandType.Text, parameters, ref error);

            if (result.Rows.Count > 0)
            {
                loaiVe = result.Rows[0]["LoaiVe"].ToString();
                gia = Convert.ToSingle(result.Rows[0]["Gia"]);
            }
            else
            {
                loaiVe = string.Empty;
                gia = 0;
            }
        }
    }
}
