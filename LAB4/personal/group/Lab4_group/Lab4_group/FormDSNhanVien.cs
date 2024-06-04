using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_group
{
    public partial class FormDSNhanVien : Form
    {
        public string MANV { get; set; }

        NhanVien_Func nvf;
        public FormDSNhanVien()
        {
            InitializeComponent();
            nvf = new NhanVien_Func();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDSLop_Click(object sender, EventArgs e)
        {
            FormDSLop dsl = new FormDSLop();
            dsl.MANV = MANV;
            this.Hide();
            dsl.ShowDialog();
        }
        public void showAllNhanVien()
        {
            DataTable dt = nvf.getAllNhanVien();
            dta_nhanvien.DataSource = dt;
            dta_nhanvien.Update();
            dta_nhanvien.Refresh();
        }

        private void FormDSNhanVien_Load(object sender, EventArgs e)
        {
            showAllNhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            this.Hide();
            tnv.ShowDialog();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            this.Hide();
            tnv.ShowDialog();
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chi xem duoc LUONG cua nhan vien da dang nhap !!!");
            DataTable dt = nvf.getLuong(MANV);
            dta_nhanvien.DataSource = dt;
            dta_nhanvien.Update();
            dta_nhanvien.Refresh();
        }
    }
}
