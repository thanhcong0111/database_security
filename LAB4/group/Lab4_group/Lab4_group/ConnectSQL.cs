using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab4_group
{
    internal class ConnectSQL
    {
        string con;
        public ConnectSQL()
        {
            con = @"Data Source=LAPTOP-TULM4LVA\MSSQLGR; Initial Catalog=QLSVNhom; Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(con);
        }
    }
}
