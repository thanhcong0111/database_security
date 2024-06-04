using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
namespace Lab4
{
    public partial class MyForm : Form
    {
        SHA1CryptoServiceProvider sh;
        MD5CryptoServiceProvider md;
        public MyForm()
        {
            InitializeComponent();
            sh = new SHA1CryptoServiceProvider();
            md = new MD5CryptoServiceProvider();
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

                    byte[] md_pass = md.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
                    string md_pass_str = "0x" + BitConverter.ToString(md_pass).Replace("-", "");

                    string sql_nv = "select * from NHANVIEN where TENDN = N'" + acc + "' and MATKHAU = " + sh_pass_str + ";";
                    string sql_sv = "select * from SINHVIEN where TENDN = N'" + acc + "' and MATKHAU = " + md_pass_str + ";";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_nv, con);
                    SqlDataReader dta = cmd.ExecuteReader();

                    if (dta.Read())
                    {
                        con.Close();
                        MessageBox.Show("Dang nhap thanh cong !");
                        FormDSNhanVien fs = new FormDSNhanVien();
                        this.Hide();
                        fs.ShowDialog();
                    }
                    else
                    {
                        dta.Close();
                        cmd = new SqlCommand(sql_sv, con);
                        dta = cmd.ExecuteReader();
                        if (dta.Read() == true)
                        {
                            con.Close();
                            MessageBox.Show("Dang nhap thanh cong !");
                            FormDSNhanVien fs = new FormDSNhanVien();
                            this.Hide();
                            fs.ShowDialog();
                        }
                        else
                            MessageBox.Show("Ten dang nhap va mat khau khong hop le !");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
