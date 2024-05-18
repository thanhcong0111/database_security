using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab03_nhom.DTO
{
    public class DTO_SinhVien
    {
        public String maSV;
        public String tenSV;
        public DateTime ngaysinhSV;
        public String diachiSV;
        public String malopSV;
        public String tendnSV;
        public String matkhauSV;

        public DTO_SinhVien()
        { }
        public DTO_SinhVien(DataRow dtr)
        {
            maSV = (String)dtr["MASV"];
            tenSV = (String)dtr["HOTEN"];
            ngaysinhSV = (DateTime)dtr["NGAYSINH"];
            diachiSV = (String)dtr["DIACHI"];
            malopSV = (String)dtr["MALOP"];
            tendnSV = (String)dtr["TENDN"];
            char[] cs = BitConverter.ToString(((byte[])(dtr["MATKHAU"]))).Where(c => c != '-').ToArray();
            String s = new String(cs);
            s = "0x" + s;
            //String s = "";
            //foreach (byte b in ((byte[])(dtr["MATKHAU"])))
            //{
            //    s += Convert.ToChar(b);
            //}
            matkhauSV = s;           
        }
    }
}
