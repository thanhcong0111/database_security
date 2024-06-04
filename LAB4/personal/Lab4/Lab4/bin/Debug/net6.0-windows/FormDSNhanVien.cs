using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FormDSNhanVien : Form
    {
        NhanVien_Func nvf;
        public FormDSNhanVien()
        {
            InitializeComponent();
            nvf = new NhanVien_Func();
        }
        public void showAllNhanVien()
        {
            DataTable dt = nvf.getAllNhanVien();
            dta_nhanvien.DataSource = dt;
            dta_nhanvien.Update();
            dta_nhanvien.Refresh();
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chua nhap Ma NV !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Chua nhap Ho Ten !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Chua nhap Email !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Chua nhap Mat Khau !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Chua nhap Ten DN !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDN.Focus();
                return false;
            }

            return true;
        }

        private void FormDSNhanVien_Load(object sender, EventArgs e)
        {
            showAllNhanVien();
        }

        private void dta_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dta_nhanvien.Rows.Count - 1)
            {
                txtMaNV.Text = dta_nhanvien.Rows[index].Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dta_nhanvien.Rows[index].Cells["HoTen"].Value.ToString();
                txtEmail.Text = dta_nhanvien.Rows[index].Cells["email"].Value.ToString();
                txtLuong.Text = dta_nhanvien.Rows[index].Cells["Luong"].Value.ToString();
                txtTenDN.Text = String.Empty;
                txtMK.Text = String.Empty;
            }
            else
            {
                txtMaNV.Text = String.Empty;
                txtHoTen.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtLuong.Text = String.Empty;
                txtTenDN.Text = String.Empty;
                txtMK.Text = String.Empty;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhanVien_Struc nv = new NhanVien_Struc();
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtHoTen.Text;
                nv.Email = txtEmail.Text;
                nv.Luong = txtLuong.Text;
                nv.TenDN = txtTenDN.Text;
                nv.MatKhau = txtMK.Text;
                if (nvf.insertNhanVien(nv))
                    showAllNhanVien();
                else
                    MessageBox.Show("Da xay ra loi !", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop); ;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chua nhap Ma NV", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
            }
            else if (MessageBox.Show("Ban co muon xoa khong?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (nvf.deleteNhanVien(txtMaNV.Text))
                    showAllNhanVien();
                else
                    MessageBox.Show("Da xay ra loi", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhanVien_Struc nv = new NhanVien_Struc();
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtHoTen.Text;
                nv.Email = txtEmail.Text;
                nv.Luong = txtLuong.Text;
                nv.TenDN = txtTenDN.Text;
                nv.MatKhau = txtMK.Text;
                if (nvf.updateNhanVien(nv))
                    showAllNhanVien();
                else
                    MessageBox.Show("Da xay ra loi !", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
