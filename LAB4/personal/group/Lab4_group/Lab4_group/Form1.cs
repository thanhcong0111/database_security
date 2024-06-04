using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;

namespace Lab4_group
{
    public partial class Form1 : Form
    {
        SHA1CryptoServiceProvider sh;
        public Form1()
        {
            InitializeComponent();
            sh = new SHA1CryptoServiceProvider();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConnectSQL dc = new ConnectSQL();
            try
            {
                using (SqlConnection con = dc.getConnect())
                {
                    string acc = txtAcc.Text;
                    string pass = txtPass.Text;
                    byte[] sh_pass = sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
                    string sh_pass_str = "0x" + BitConverter.ToString(sh_pass).Replace("-", "");

                    string sql = "select * from NHANVIEN where MANV = N'" + acc + "' and MATKHAU = " + sh_pass_str + ";";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dta = cmd.ExecuteReader();

                    if (dta.Read())
                    {
                        con.Close();
                        MessageBox.Show("Dang nhap thanh cong !");
                        FormDSNhanVien dsnv = new FormDSNhanVien();
                        this.Hide();
                        dsnv.MANV = txtAcc.Text;
                        dsnv.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ten dang nhap va mat khau khong hop le !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi: " + ex.Message);
            }

        }
    }
}
