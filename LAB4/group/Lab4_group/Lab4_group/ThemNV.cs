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
    public partial class ThemNV : Form
    {
        NhanVien_Func nvf;
        public ThemNV()
        {
            InitializeComponent();
            nvf = new NhanVien_Func();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDSNhanVien dsnv = new FormDSNhanVien();
            this.Hide();
            dsnv.ShowDialog();
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

            if(string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Chua nhap Luong !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPub.Text))
            {
                MessageBox.Show("Chua nhap Pubkey !.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPub.Focus();
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                if(nvf.insertNhanVien(txtMaNV.Text, txtHoTen.Text, txtEmail.Text, txtLuong.Text, txtTenDN.Text, txtMK.Text, txtPub.Text))
                {
                    MessageBox.Show("Add nhan vien thanh cong !!!");
                    FormDSNhanVien dsnv = new FormDSNhanVien();
                    this.Hide();
                    dsnv.ShowDialog();
                }
                else
                    MessageBox.Show("Da xay ra loi !", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
