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
    public partial class NhapDiemSV : Form
    {
        public string malop { get; set; }
        public string manv { get; set; }
        public string mahp { get; set; }
        public string masv { get; set; }
        SinhVien_Func svf;
        public NhapDiemSV()
        {
            InitializeComponent();
            svf = new SinhVien_Func();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDSSinhVien dssv = new FormDSSinhVien();
            this.Hide();
            dssv.ShowDialog();
        }

        public void getAllSV(string xx)
        {
            DataTable ndsv = svf.getSVtoNhapDiem(xx);
            dta_NhapDiem.DataSource = ndsv;
            dta_NhapDiem.Update();
            dta_NhapDiem.Refresh();
        }

        private void NhapDiemSV_Load(object sender, EventArgs e)
        {
            txtMaLop.Text = malop;
            getAllSV(malop);
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Chua nhap Diem Thi !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;
            }
            return true;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (svf.luuDiem(txtDiem.Text, manv, mahp, masv))
                {
                    MessageBox.Show("Nhap diem thanh cong !!!");
                }
                else
                    MessageBox.Show("Da xay ra loi !", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dta_NhapDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dta_NhapDiem.Rows.Count - 1)
            {
                txtDiem.Text = dta_NhapDiem.Rows[index].Cells["DIEMTHI"].Value.ToString();
                this.mahp = dta_NhapDiem.Rows[index].Cells["MAHP"].Value.ToString();
                this.masv = dta_NhapDiem.Rows[index].Cells["MASV"].Value.ToString();
            }
            else
            {
                txtDiem.Text = string.Empty;
                this.mahp = string.Empty;
                this.masv = string.Empty;
            }
        }
    }
}
