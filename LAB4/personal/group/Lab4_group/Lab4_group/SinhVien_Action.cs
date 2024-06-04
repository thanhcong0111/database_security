using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing;

namespace Lab4_group
{
    internal class SinhVien_Action
    {
        ConnectSQL dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        RSAA rsa = new RSAA();
        public SinhVien_Action()
        {
            dc = new ConnectSQL();
        }

        public DataTable getAllSinhVien(string malop)
        {
            string sql = "EXEC SP_SEL_DSSV '" + malop + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        public int editInf(string manv1, string manv2, string txtSV, string HoTen)
        {
            if (manv1 != manv2) // khong thuoc quyen quan ly
            {
                return 1;
            }
            else if (txtSV != string.Empty) // thanh cong
            {
                string sql = "update SINHVIEN set MASV='" + txtSV + "', HOTEN='" + HoTen + "' where MASV='" + txtSV + "'";
                SqlConnection con = dc.getConnect();
                try
                {
                    cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = txtSV;
                    cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar).Value = HoTen;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 2;
                }
                catch (Exception)
                {
                    return 3;
                }
               
            }
            else //chua chon SV
            {
                return 4;
            }
        }

        public DataTable getDiemThi(string malop, string manv)
        {
            string sql = "EXEC SP_SEL_DSSV '" + malop + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //decrypt bang diem
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["DIEMTHI"].DataType = typeof(string);

            foreach (DataRow dr in dt.Rows)
            {
                dtCloned.ImportRow(dr);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                DataRow row2 = dtCloned.Rows[i];
                byte[] diem = (byte[])row["DIEMTHI"];
                row2["DIEMTHI"] = rsa.Decryption(diem, manv);
            }

            return dtCloned;
        }

        public bool nhapDiem(string malop, string manv)
        {
            return true;

        }

        public DataTable getSVtoNhapDiem(string malop)
        {
            string sql = "EXEC SP_SEL_TO_INSERT_DSSV '" + malop + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["DIEMTHI"].DataType = typeof(string);

            foreach (DataRow dr in dt.Rows)
            {
                dtCloned.ImportRow(dr);
            }

            return dtCloned;
        }

        public bool luuDiem(string diem, string manv, string mahp, string masv)
        {
            string sql = "update BANGDIEM set DIEMTHI=@DIEMTHI where MAHP=@MAHP and MASV=@MASV";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@DIEMTHI", SqlDbType.VarBinary).Value = rsa.Encryption(diem, manv);
                cmd.Parameters.Add("@MAHP", SqlDbType.VarChar).Value = mahp;
                cmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = masv;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
