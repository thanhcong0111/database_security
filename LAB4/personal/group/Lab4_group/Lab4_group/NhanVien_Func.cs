using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_group
{
    internal class NhanVien_Func
    {
        NhanVien_Action nva;
        public NhanVien_Func()
        {
            nva = new NhanVien_Action();
        }

        public DataTable getAllNhanVien()
        {
            return nva.getAllNhanVien();
        }

        public bool insertNhanVien(string manv, string hoten, string email, string luong, string tendn, string mk, string pub)
        {
            return nva.insertNhanVien(manv, hoten, email, luong, tendn, mk, pub);
        }
        public DataTable getLuong(string manv)
        {
            return nva.getLuong(manv);
        }
    }
}
