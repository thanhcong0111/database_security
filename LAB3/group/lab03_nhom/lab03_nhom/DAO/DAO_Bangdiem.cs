using lab03_nhom.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab03_nhom.DAO
{
    public class DAO_Bangdiem
    {
        private static DAO_Bangdiem Instance = null;
        private DAO_Bangdiem()
        {
            
        }
        public static DAO_Bangdiem Get_instance()
        {
            if(Instance == null)
            {
                Instance = new DAO_Bangdiem();
            }
            return Instance;
        }
        public List<DTO_Bangdiem> TaiDanhSachBangDiemTheoMaSinhVien(String tendnNV, String matkhauNV, String maSV)
        {
            List<DTO_Bangdiem> ketQua = new List<DTO_Bangdiem>();
            DataProvider dp = new DataProvider();            
            String query = "EXEC SP_SEL_BANGDIEM "+ "'" + tendnNV + "', '" + matkhauNV +"', " + "'" + maSV + "'";
            DataTable dt = dp.ExecuteQuery(query);            
            foreach (DataRow dtr in dt.Rows)
            {
                DTO_Bangdiem Bangdiem = new DTO_Bangdiem(dtr);
                ketQua.Add(Bangdiem);
            }           
            return ketQua;
        }

        public DataTable TaiBangDiemTheoMaSV(String tendnNV, String matkhauNV, String maSV)
        {
            DataProvider dp = new DataProvider();
            String query = "EXEC SP_SEL_BANGDIEM " + "'" + tendnNV + "', '" + matkhauNV + "', " + "'" + maSV + "'";
            return dp.ExecuteQuery(query);
        }

        public void CapNhatBangDiem(String MaNV, String MaSV, Dictionary<String, int> danhSachDiem)
        {
            DataProvider dp = new DataProvider();
            foreach(String MaHP in danhSachDiem.Keys)
            {
                String query = "EXEC SP_UPD_BANGDIEM " + "'" + MaNV + "', '" + MaSV + "', '" + MaHP + "', " + ((int)(danhSachDiem[MaHP]));
                dp.ExecuteNonQuery(query);
            }
        }
    }
}

