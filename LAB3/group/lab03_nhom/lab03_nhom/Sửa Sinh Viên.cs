using lab03_nhom.DAO;
using lab03_nhom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab03_nhom
{
    public partial class Sinh_Viên : Form
    {
        private String maNV;
        private Quản_lý_lớp f;
        private int mode = 3;
        public Sinh_Viên(Quản_lý_lớp f, String maNV, DTO_SinhVien sv, int choice)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.f = f;
            TaiThongTin(sv);
            mode = choice;
        }

        private void TaiThongTin(DTO_SinhVien sv)
        {
            tbHOTEN.Text = sv.tenSV;
            tbMASV.Text = sv.maSV;
            tbDIACHI.Text = sv.diachiSV;
            tbMALOP.Text = sv.malopSV;
            tbMATKHAU.Text = sv.matkhauSV;
            tbTENDN.Text = sv.tendnSV;
            tbNGAYSINH.Text = sv.ngaysinhSV.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message;
            try
            {
                Button btn = sender as Button;
                DTO_SinhVien ttMoi = new DTO_SinhVien();
                if (String.IsNullOrEmpty(tbHOTEN.Text.ToString()) || String.IsNullOrEmpty(tbMALOP.Text.ToString()) || String.IsNullOrEmpty(tbMATKHAU.Text.ToString()) || String.IsNullOrEmpty(tbNGAYSINH.Text.ToString()) || String.IsNullOrEmpty(tbTENDN.Text.ToString()) || String.IsNullOrEmpty(tbDIACHI.Text.ToString()))
                {
                    message = "Vui lòng nhập đúng định dạng / Chú ý thông tin trùng lặp";
                }
                else 
                {
                    ttMoi.tenSV = tbHOTEN.Text.ToString();
                    ttMoi.malopSV = tbMALOP.Text.ToString();
                    ttMoi.maSV = tbMASV.Text.ToString();
                    ttMoi.matkhauSV = tbMATKHAU.Text.ToString();
                    ttMoi.ngaysinhSV = Convert.ToDateTime(tbNGAYSINH.Text.ToString());
                    ttMoi.tendnSV = tbTENDN.Text.ToString();
                    ttMoi.diachiSV = tbDIACHI.Text.ToString();
                    DAO_SinhVien.Get_instance().CapNhatSinhVien(maNV, ttMoi, mode);
                    message = "Thêm/chỉnh sửa thành công";
                    this.Close();
                }
            }
            catch (Exception svmoi)
            {
                message = "Vui lòng nhập đúng định dạng / Chú ý thông tin trùng lặp";
            }
            MessageBox.Show(message);
            f.TaiLaiDanhSach();
        }

        private void tbMALOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTENDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMASV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHOTEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNGAYSINH_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDIACHI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
