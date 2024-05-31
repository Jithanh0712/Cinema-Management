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
    public class QuanLyTheLoaiPhim
    {
        DBMain dbMain;
        public QuanLyTheLoaiPhim()
        {
            this.dbMain = new DBMain();
        }
        public bool ThemTheLoai(DTO_TheLoaiPhim TLP)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemTheLoai";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = TLP.MaPhim };
            parameters[1] = new SqlParameter("@TheLoai", SqlDbType.NVarChar, 20) { Value = TLP.TheLoai };

            string error = string.Empty;
            result = dbMain.MyExecuteNonQuery(strSQL, ct, parameters, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi");
            }

            return result;
        }
    }
}
