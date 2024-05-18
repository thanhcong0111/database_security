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
    public partial class Nhập_điểm : Form
    {
        private List<DTO_Bangdiem> danhsachhocphan;
        private String maSV;
        private String maNV;   
        public Nhập_điểm(String maNV, String maSV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.maSV = maSV;
            ma_sv.Text = "Mã sinh viên: " + maSV;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, int> danhSachDiem = new Dictionary<String, int>();            
            foreach(DataGridViewRow row in DataHP.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                    danhSachDiem.Add(row.Cells[0].Value.ToString(), (int)row.Cells[3].Value);
            }
            DAO_Bangdiem.Get_instance().CapNhatBangDiem(maNV, maSV, danhSachDiem);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                String tendnNV = tbDangNhap.Text.ToString();
                String matkhauNV = tbMatKhau.Text.ToString();
                String maSV = this.maSV;
                danhsachhocphan = DAO_Bangdiem.Get_instance().TaiDanhSachBangDiemTheoMaSinhVien(tendnNV, matkhauNV, maSV);
                DataHP.DataSource = DAO_Bangdiem.Get_instance().TaiBangDiemTheoMaSV(tendnNV, matkhauNV, maSV);
                if(DataHP == null || DataHP.Rows.Count <= 0)
                {
                    MessageBox.Show("Danh sách môn trống (kiểm tra lại thông tin đăng nhập hoặc database)");
                }
                
            }
            catch (Exception fail)
            {
                MessageBox.Show("Danh sách môn trống / Khác nhân viên quản lí ");
            }
        }
    }
}
