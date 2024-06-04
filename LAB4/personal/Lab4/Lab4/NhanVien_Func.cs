using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
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

        public bool insertNhanVien(NhanVien_Struc nv)
        {
            return nva.insertNhanVien(nv);
        }

        public bool updateNhanVien(NhanVien_Struc nv)
        {
            return nva.updateNhanVien(nv);
        }

        public bool deleteNhanVien(string MaNV)
        {
            return nva.deleteNhanVien(MaNV);
        }
    }
}
