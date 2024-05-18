using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace lab03_nhom.DTO
{
    public class DTO_Lop
    {

        public String maLop;
        public String tenLop;
        public DTO_Lop(DataRow dtr)
        {
            maLop = (String)dtr["MALOP"];
            tenLop = (String)dtr["TEN"];
        }
    }
}
