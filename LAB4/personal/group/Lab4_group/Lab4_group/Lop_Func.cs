using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_group
{
    internal class Lop_Func
    {
        Lop_Action la;
        public Lop_Func()
        {
            la = new Lop_Action();
        }

        public DataTable getAllLop()
        {
            return la.getAllLop(); 
        }
    }
}
