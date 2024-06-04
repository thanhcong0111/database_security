using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class ConnectSQL
    {
        string con;
        public ConnectSQL()
        {
            con = @"Data Source=LAPTOP-TULM4LVA\MSSQLGR; Initial Catalog=QLSV; Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(con);
        }
    }
}
