using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace Lab4_group
{
    internal class NhanVien_Action
    {
        ConnectSQL dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        RSAA rsaa;
        SHA1CryptoServiceProvider sh;

        public NhanVien_Action()
        {
            dc = new ConnectSQL();
            rsaa = new RSAA();
            sh = new SHA1CryptoServiceProvider();
        }

        public DataTable getAllNhanVien()
        {
            //string sql = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
            string sql = "select MANV, HOTEN, EMAIL, LUONG, TENDN from NHANVIEN";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Decrypt Luong
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["Luong"].DataType = typeof(string);

            foreach (DataRow dr in dt.Rows)
            {
                dtCloned.ImportRow(dr);
            }

            return dtCloned;
        }

        public bool insertNhanVien(string manv, string hoten, string email, string luong, string tendn, string mk, string pub)
        {
            string sql = "EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @MANV, @HOTEN, @EMAIL, @LUONG, @TENDN, @MATKHAU, @PUB";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = rsaa.Encryption(luong, manv);
                cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = tendn;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(mk));
                cmd.Parameters.Add("@PUB", SqlDbType.VarChar).Value = pub;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable getLuong(string manv)
        {
            //string sql = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
            string sql = "select MANV, HOTEN, EMAIL, LUONG, TENDN from NHANVIEN where MANV='" + manv +"';";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Decrypt Luong
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["Luong"].DataType = typeof(string);

            foreach (DataRow dr in dt.Rows)
            {
                dtCloned.ImportRow(dr);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                DataRow row2 = dtCloned.Rows[i];
                byte[] luong = (byte[])row["Luong"];
                row2["Luong"] = rsaa.Decryption(luong, manv);
            }

            return dtCloned;
        }
    }
}
