using lab03_nhom.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab03_nhom.DAO
{
    public class DAO_SinhVien
    {
        private static DAO_SinhVien Instance = null;
        private DAO_SinhVien()
        {

        }
        public static DAO_SinhVien Get_instance()
        {
            if (Instance == null)
            {
                Instance = new DAO_SinhVien();
            }
            return Instance;
        }
        public List<DTO_SinhVien> TaiDanhSachSinhVienTheoMaLop(String maLop)
        {
            List<DTO_SinhVien> ketQua = new List<DTO_SinhVien>();
            DataProvider dp = new DataProvider();             
            String query = "EXEC SP_CL_STU " + "'" + maLop + "'";
            DataTable dt = dp.ExecuteQuery(query);
            foreach (DataRow dtr in dt.Rows)
            {
                DTO_SinhVien SV = new DTO_SinhVien(dtr);
                ketQua.Add(SV);
            }            

            return ketQua;
        }

        public DataTable TaiBangSinhVienTheoMaLop(String maLop)
        {
            DataProvider dp = new DataProvider();
            String query = "EXEC SP_CL_STU " + "'" + maLop + "'";
            return dp.ExecuteQuery(query);
        }
            
        public void CapNhatSinhVien(String maNV, DTO_SinhVien sv, int mode)
        {
            DataProvider dp = new DataProvider();
            String query = "EXEC SP_UPD_SINHVIEN '" + maNV + "', '" + sv.maSV + "', N'" + sv.tenSV + "', '" + sv.ngaysinhSV.ToString() + "', N'" + sv.diachiSV + "', '" + sv.malopSV + "', '" + sv.tendnSV + "', '" + sv.matkhauSV.ToString() + "', " + mode.ToString();

            dp.ExecuteNonQuery(query);
        }
      
    }
}
