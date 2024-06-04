using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_group
{
    public partial class FormDSLop : Form
    {
        public string MANV {  get; set; }
        public string MANVTemp { get; set; }

        Lop_Func lf;
        public FormDSLop()
        {
            InitializeComponent();
            lf = new Lop_Func();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void showAllLop()
        {
            DataTable dt = lf.getAllLop();
            dta_lop.DataSource = dt;
            dta_lop.Update();
            dta_lop.Refresh();
        }

        private void FormDSLop_Load(object sender, EventArgs e)
        {
            showAllLop();
        }

        private void dta_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dta_lop.Rows.Count - 1)
            {
                txtMaLop.Text = dta_lop.Rows[index].Cells["MaLop"].Value.ToString();
                MANVTemp = dta_lop.Rows[index].Cells["MaNV"].Value.ToString();
            }
            else
            {
                txtMaLop.Text = string.Empty;
            }
        }

        private void btn_DSSV_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == string.Empty)
            {
                MessageBox.Show("Chua chon lop can xem !!");
            }
            else
            {
                FormDSSinhVien dssv = new FormDSSinhVien();
                dssv.MaLop = txtMaLop.Text;
                dssv.MANV = MANV;
                dssv.MANV2 = MANVTemp;
                this.Hide();
                dssv.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDSNhanVien nv = new FormDSNhanVien();
            this.Hide();
            nv.ShowDialog();
        }
    }
}
