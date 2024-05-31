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
    public class ThamGia
    {
        DBMain dbMain;
        public ThamGia()
        {
            this.dbMain = new DBMain();
        }
        public bool ThemThamGia(DTO_ThamGia TG)
        {
            dbMain = null;
            dbMain = new DBMain();
            bool result = false;
            string strSQL = "ThemThamGia";
            CommandType ct = CommandType.StoredProcedure;

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaDV", SqlDbType.Char, 10) { Value = TG.MaDV };
            parameters[1] = new SqlParameter("@MaPhim", SqlDbType.Char, 10) { Value = TG.MaPhim };
            parameters[2] = new SqlParameter("@VaiTro", SqlDbType.NVarChar, 50) { Value = TG.VaiTro };

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
