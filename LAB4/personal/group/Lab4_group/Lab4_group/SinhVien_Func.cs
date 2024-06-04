using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_group
{
    internal class SinhVien_Func
    {
        SinhVien_Action la;
        public SinhVien_Func()
        {
            la = new SinhVien_Action();
        }

        public DataTable getAllSinhVien(string malop)
        {
            return la.getAllSinhVien(malop);
        }

        public int editInf(string manv1, string manv2, string txtSV, string HoTen)
        {
            return la.editInf(manv1, manv2, txtSV, HoTen);
        }

        public DataTable getDiemThi(string malop, string manv)
        {
            return la.getDiemThi(malop, manv);
        }
        public DataTable getSVtoNhapDiem(string malop)
        {
            return la.getSVtoNhapDiem(malop);
        }
        public bool luuDiem(string diem, string manv, string mahp, string masv)
        {
            return la.luuDiem(diem, manv, mahp, masv);
        }
    }
}
