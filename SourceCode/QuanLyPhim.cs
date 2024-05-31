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
using RapChieuPhim.DTO;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace RapChieuPhim.SourceCode
{
    public class QuanLyPhim
    {
        DBMain dbMain;

        public QuanLyPhim()
        {
            this.dbMain = new DBMain();
        }

        public DataTable ChiTietPhim(String MaPhim)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM dbo.XemPhim WHERE MaPhim = '{MaPhim}'";
            SqlParameter[] parameters = null;
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(query, CommandType.Text, parameters, ref error);
            return dataTable;
        }

        public List<string> LayTatCaTheLoaiPhim()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaTheLoai()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);

            List<string> theLoaiList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    theLoaiList.Add(row["TheLoai"].ToString());

            return theLoaiList;
        }

        public List<string> LayTheLoaiPhim(string MaPhim)
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaTheLoai(@MaPhim)";
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = MaPhim };
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);

            List<string> theLoaiList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    theLoaiList.Add(row["TheLoai"].ToString());

            return theLoaiList;
        }
        public DataTable LayDanhSachPhim()
        {
            dbMain = null;
            dbMain = new DBMain();
            string error = string.Empty;
            return dbMain.ExecuteQueryDataSet("SELECT * FROM XemPhim", CommandType.Text, null, ref error);
        }
        public bool ThemPhim(DTO_Phim PH)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemPhim";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[11];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = PH.MaPhim };
            parameters[1] = new SqlParameter("@TenPhim", SqlDbType.NVarChar, 30) { Value = PH.TenPhim };
            parameters[2] = new SqlParameter("@DaoDien", SqlDbType.NVarChar, 30) { Value = PH.DaoDien };
            parameters[3] = new SqlParameter("@NhaSX", SqlDbType.NVarChar, 30) { Value = PH.NhaSX };
            parameters[4] = new SqlParameter("@NamSX", SqlDbType.Int) { Value = PH.NamSX };
            parameters[5] = new SqlParameter("@HinhThuc", SqlDbType.NVarChar, 20) { Value = PH.HinhThuc };
            parameters[6] = new SqlParameter("@DinhDang", SqlDbType.VarChar, 2) { Value = PH.DinhDang };
            parameters[7] = new SqlParameter("@XepLoai", SqlDbType.VarChar, 5) { Value = PH.XepLoai };
            parameters[8] = new SqlParameter("@DoDai", SqlDbType.Int) { Value = PH.DoDai };
            parameters[9] = new SqlParameter("@MoTa", SqlDbType.Text) { Value = PH.MoTa };
            parameters[10] = new SqlParameter("@HinhAnh", SqlDbType.VarBinary, -1) { Value = PH.HinhAnh };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
        public bool XoaPhim(string MaPhim)
        {
            dbMain = null;
            dbMain = new DBMain();
            string strSql = "XoaPhim";
            string error = string.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = MaPhim };

            dbMain.MyExecuteNonQuery(strSql, CommandType.StoredProcedure, parameters, ref error);
            return true;
        }
        public byte[] GetImageByMaPhim(string MaPhim)
        {
            dbMain = null;
            dbMain = new DBMain();
            byte[] imageData = null;
            string error = string.Empty;

            string strSql = "EXEC @HinhAnh = dbo.GetImageByMaPhim @MaPhim = @MaPhim; " +
                                      "SELECT @HinhAnh AS HinhAnh;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhim", SqlDbType.Char, 10)
                {
                    Value = MaPhim
                },
                new SqlParameter("@HinhAnh", SqlDbType.VarBinary, -1)
                {
                    Direction = ParameterDirection.Output
                }
            };
            dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);
            if (parameters[1].Value != DBNull.Value)
            {
                imageData = (byte[])parameters[1].Value;
            }

            return imageData;
        }

        public string TaoMaPhimTuDong()
        {
            dbMain = null;
            dbMain = new DBMain();
            string maPhim = "";
            string error = string.Empty;
            string strSql = "SET @MaPhim = dbo.TaoMaPhimTuDong();";
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaPhim", SqlDbType.Char, 10)
                    {
                        Direction = ParameterDirection.Output
                    }
                };

                dbMain.MyExecuteNonQuery(strSql, CommandType.Text, parameters, ref error);
                if (parameters[0].Value != DBNull.Value)
                {
                    maPhim = parameters[0].Value.ToString();
                }
                else
                {
                    maPhim = "P000000001";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return maPhim;
        }

        public DataTable DSPhimTheoTen(string tenPhim)
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from dbo.TimKiemTenPhim(@TenPhim)";
            string error = String.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@TenPhim", SqlDbType.NVarChar, 30) { Value = tenPhim};
            dt = dbMain.ExecuteQueryDataSet(strSQL,CommandType.Text, parameters, ref error);
            return dt;
        }

        public DataTable DSPhimTheoTheLoai(List<string> dsTheLoai) 
        {
            DataTable dsPhim = new DataTable();

            foreach (string theLoai in dsTheLoai)
            {
                dbMain = null;
                dbMain = new DBMain();
                DataTable dt = new DataTable();
                string strSQL = "Select * from dbo.TimPhimTheoTheLoai(@TheLoai)";
                string error = String.Empty;
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@TheLoai", SqlDbType.NVarChar, 20) { Value = theLoai };
                dt = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);

                DataColumn dem = new DataColumn("Dem", typeof(int));
                dem.DefaultValue = 1;
                dt.Columns.Add(dem);
                dsPhim.Merge(dt);
            }

            dsPhim.DefaultView.Sort = "Dem DESC";
            dsPhim = dsPhim.DefaultView.ToTable();
            dsPhim.Columns.Remove("Dem");

            return dsPhim;
        }

        public DataTable DSNgayKhoiChieu(DataTable dt)
        {
            DataTable dtPhim = new DataTable();
            string error = String.Empty;
            string strSQL = "SELECT MaPhim, NgayKhoiChieu FROM dbo.LayNgayKhoiChieu(@MaPhim)";

            foreach (DataRow row in dt.Rows)
            {
                // Thực hiện phiên khác sau mỗi vòng lặp.
                dbMain = null;
                dbMain = new DBMain();

                string maPhim = row["MaPhim"].ToString();

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = maPhim};

                DataTable dtResult = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);

                DataColumn colMaPhim = dtPhim.Columns["MaPhim"];

                dtPhim.Merge(dtResult, true, MissingSchemaAction.Add);
                dtPhim.PrimaryKey = new DataColumn[] { colMaPhim };
            }

            dt.Merge(dtPhim, true, MissingSchemaAction.Add);
            return dt;
        }

        public DateTime LayNgayKhoiChieu(string maPhim)
        {
            dbMain = null;
            dbMain = new DBMain();

            DateTime result = new DateTime();
            DataTable dtPhim = new DataTable();
            string error = String.Empty;
            string strSQL = "SELECT MaPhim, NgayKhoiChieu FROM dbo.LayNgayKhoiChieu(@MaPhim)";
            
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = maPhim };
            dtPhim = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);
            DateTime.TryParse(dtPhim.Rows[0]["NgayKhoiChieu"].ToString(), out result);
            return result.Date;
        }

        public List<string> LayThoiGianLichChieu(string maPhim)
        {
            dbMain = null;
            dbMain = new DBMain();

            List<string> result = new List<string>();
            DataTable lc = new DataTable();

            string strSQL = "Select * from dbo.LayLichChieuPhim(@MaPhim)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = maPhim};
            string error = string.Empty;
            lc = dbMain.ExecuteQueryDataSet(strSQL,CommandType.Text, parameters, ref error);

            for(int i = 0; i < lc.Rows.Count; ++i)
                result.Add(lc.Rows[i]["MaLC"].ToString());

            return result;
        }

        public List<string> LayDSDienVien(string maPhim)
        {
            dbMain = null;
            dbMain = new DBMain();
            List<string> dsDienVien = new List<string>();
            DataTable dtDienVien = new DataTable();
            string strSQL = "Select * from dbo.LayDSDienVien(@MaPhim)";
            string error = String.Empty;
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = maPhim };
            dtDienVien = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters, ref error);
            for(int i = 0; i < dtDienVien.Rows.Count;++i)
                dsDienVien.Add(dtDienVien.Rows[i]["TenDV"].ToString());  
            return dsDienVien;
        }
        public List<string> LayTatCaMaPhim()
        {
            DataTable dataTable = new DataTable();
            string strSQL = "SELECT * FROM dbo.LayTatCaMaPhim()";
            string error = string.Empty;
            dataTable = dbMain.ExecuteQueryDataSet(strSQL, CommandType.Text, null, ref error);
            dbMain = null;
            dbMain = new DBMain();
            List<string> maphimList = new List<string>();
            if (dataTable != null && dataTable.Rows.Count > 0)
                foreach (DataRow row in dataTable.Rows)
                    maphimList.Add(row["MaPhim"].ToString());

            return maphimList;
        }
    }
}
