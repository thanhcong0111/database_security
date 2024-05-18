using lab03_nhom.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace lab03_nhom.DAO
{
    public class DAO_Lop
    {
        private static DAO_Lop Instance = null;
        private DAO_Lop()
        {

        }
        public static DAO_Lop Get_instance()
        {
            if (Instance == null)
            {
                Instance = new DAO_Lop();
            }
            return Instance;
        }
        public List<DTO_Lop> TaiDanhSachLopTheoMaNhanVien(String maNhanVien)
        {
            List<DTO_Lop> ketQua = new List<DTO_Lop>();
            DataProvider dp = new DataProvider();
            String query = "EXEC SP_GET_CL " + "'" + maNhanVien + "'";
            DataTable dt = dp.ExecuteQuery(query);
            foreach(DataRow dtr in dt.Rows)
            {
                DTO_Lop lop = new DTO_Lop(dtr);
                ketQua.Add(lop);
            }
            return ketQua;
        }
    }
}
