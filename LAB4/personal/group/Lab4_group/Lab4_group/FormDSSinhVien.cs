using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_group
{
    public partial class FormDSSinhVien : Form
    {
        public string MANV { get; set; }
        public string MANV2 { get; set; } //MA NHAN VIEN HIEN TAI CUA LOP
        public string MaLop { get; set; }
        SinhVien_Func svf;
        RSAA rsa = new RSAA();
        public FormDSSinhVien()
        {
            InitializeComponent();
            svf = new SinhVien_Func();
            rsa = new RSAA();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDSLop lop = new FormDSLop();
            this.Hide();
            lop.ShowDialog();
        }

        public void showAllSinhVien(string xx)
        {
            DataTable dt = svf.getAllSinhVien(xx);
            dta_SV.DataSource = dt;
            dta_SV.Update();
            dta_SV.Refresh();
        }

        private void FormDSSinhVien_Load(object sender, EventArgs e)
        {
            txtMaLop.Text = MaLop;
            txtMaNV.Text = MANV2;
            showAllSinhVien(MaLop);
        }

        private void dta_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dta_SV.Rows.Count - 1)
            {
                txtMaSV.Text = dta_SV.Rows[index].Cells["MASV"].Value.ToString();
                txtHoTen.Text = dta_SV.Rows[index].Cells["HOTEN"].Value.ToString();
            }
            else
            {
                txtMaSV.Text = string.Empty;
                txtHoTen.Text = string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //1 - Ko thuoc quyen quan ly cua GV
            //2 - Thanh cong
            //3 - Loi khi cap nhat
            //else- chua chon sinh vien can thay doi
            if (svf.editInf(MANV, MANV2, txtMaSV.Text, txtHoTen.Text) == 1)
            {
                MessageBox.Show("Khong thuoc quyen quan ly cua GV !!!");
            }
            else if (svf.editInf(MANV, MANV2, txtMaSV.Text, txtHoTen.Text) == 2)
                showAllSinhVien(MaLop);
            else if (svf.editInf(MANV, MANV2, txtMaSV.Text, txtHoTen.Text) == 3)
                MessageBox.Show("Error!!!");
            else
                MessageBox.Show("Chua chon SV can chinh sua thong tin!!!");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (MANV != MANV2)
            {
                MessageBox.Show("Khong thuoc quyen quan ly cua GV !!!");
            }
            else
            {
                DataTable diem = svf.getDiemThi(MaLop, MANV);
                dta_SV.DataSource = diem;
                dta_SV.Update();
                dta_SV.Refresh();
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (MANV != MANV2)
            {
                MessageBox.Show("Khong thuoc quyen GV quan ly !!!");
            }
            else
            {
                NhapDiemSV ndsv = new NhapDiemSV();
                ndsv.malop = MaLop;
                ndsv.manv = MANV;
                this.Hide();
                ndsv.ShowDialog();
            }
        }
    }
}
