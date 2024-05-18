using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab03_nhom.DTO
{
    public class DTO_Bangdiem
    {
        public String maHP;
        public String tenHP;
        public int sotcHP;
        public int diemHP;
        public DTO_Bangdiem(DataRow dtr)
        {
            maHP = (String)dtr["MAHP"];
            tenHP = (String)dtr["TENHP"];
            sotcHP = (int)dtr["SOTC"];
            if (dtr["DIEMTHIDC"].GetType().ToString().Equals("System.DBNull"))
            {
                diemHP = 0;
            }
            else
            {                
                diemHP = (int)dtr["DIEMTHIDC"];
            }            
        }
    }
}
