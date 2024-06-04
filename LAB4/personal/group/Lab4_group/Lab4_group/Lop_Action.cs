using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_group
{
    internal class Lop_Action
    {
        ConnectSQL dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public Lop_Action() 
        { 
            dc = new ConnectSQL();
        }

        public DataTable getAllLop()
        {
            string sql = "select * from LOP";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }
    }
}
