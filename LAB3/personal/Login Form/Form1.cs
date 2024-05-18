using System.Data.SqlClient;
namespace Login_Form;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TULM4LVA\MSSQLGR; Initial Catalog=QLSV; Integrated Security=True");
        try
        {
            con.Open();

            string acc = txtAcc.Text.ToString();
            string pass = txtPass.Text.ToString();
            string sql = "select* from SINHVIEN where '" + acc + "' = TENDN and HASHBYTES('MD5', '" + pass + "') = MATKHAU";
            string sql_nv = "select* from NHANVIEN where '" + acc + "' = TENDN and HASHBYTES('SHA1', '" + pass + "') = MATKHAU";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
                MessageBox.Show("Đăng nhập thành công");
            else
            {
                dta.Close();
                cmd = new SqlCommand(sql_nv, con);
                dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                    MessageBox.Show("Đăng nhập thành công");
                else
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
            }

        }
        catch(Exception)
        {
            MessageBox.Show("Lỗi kết nối");
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
