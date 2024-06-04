using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;

namespace Lab4
{
    internal class NhanVien_Action
    {
        ConnectSQL dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        AES aess;
        SHA1CryptoServiceProvider sh;
        public NhanVien_Action()
        {
            dc = new ConnectSQL();
            aess = new AES("21120419211204192112041921120419");
            sh = new SHA1CryptoServiceProvider();
        }

        public DataTable getAllNhanVien()
        {
            string sql = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
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
                row2["Luong"] = aess.Decrypt(luong);
            }

            return dtCloned;
        }

        public bool insertNhanVien(NhanVien_Struc nv)
        {
            string sql = "EXEC SP_INS_ENCRYPT_NHANVIEN @MANV, @HOTEN, @EMAIL, @LUONG, @TENDN, @MATKHAU";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = nv.Email;
                cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = aess.Encrypt(nv.Luong);
                cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = nv.TenDN;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(nv.MatKhau));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool updateNhanVien(NhanVien_Struc nv)
        {
            string sql = "update NHANVIEN set HOTEN=@HOTEN, EMAIL=@EMAIL, LUONG=@LUONG, TENDN=@TENDN, MATKHAU=@MATKHAU where MANV=@MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV   ", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = nv.Email;
                cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = aess.Encrypt(nv.Luong);
                cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = nv.TenDN;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(nv.MatKhau));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            { 
                return false; 
            }
            return true;
        }

        public bool deleteNhanVien(string MaNV)
        {
            string sql = "delete NHANVIEN where MANV=@MANV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception) { return false; }
            return true;
        }
    }
}