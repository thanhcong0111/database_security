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
    public partial class Quản_lý_lớp : Form
    {
        private List<DTO_Lop> danhSachLop;
        private List<DTO_SinhVien> danhSachSinhVien;
        private String maNhanVien;
        private String maLopDangXem;
        private String tenLopDangXem;
        public Quản_lý_lớp(String maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            ThemLop();
            for(int i = 0; i < danhSachLop.Count; i++)
            {
                Button butt = new Button();
                butt.Text = danhSachLop[i].tenLop;
                butt.Size = new Size(170, 23);
                butt.Click += new EventHandler((sender, e) => OnClick(sender, e));
                flowLayoutPanel1.Controls.Add(butt);
            }
            if (danhSachLop.Count > 0)
            {
                TaiDanhSachHocVien(danhSachLop[0].maLop, danhSachLop[0].tenLop);
                maLopDangXem = danhSachLop[0].maLop;
                tenLopDangXem = danhSachLop[0].tenLop;
            }
        }

        private void ThemLop()
        {
            danhSachLop = DAO_Lop.Get_instance().TaiDanhSachLopTheoMaNhanVien(maNhanVien);
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String tenLop = btn.Text.ToString();
            try
            {
                String maLop = danhSachLop.First(lop => lop.tenLop == tenLop).maLop;
                maLopDangXem = maLop;
                tenLopDangXem = tenLop;
                TaiDanhSachHocVien(maLop, tenLop);
            }
            catch (Exception fail)
            {
                MessageBox.Show("Danh sách lớp trống");
            }
        }

        public void TaiDanhSachHocVien(string maLop, string tenLop)
        {
            classrom_name.Text = tenLop;

            danhSachSinhVien = DAO_SinhVien.Get_instance().TaiDanhSachSinhVienTheoMaLop(maLop);

            //DataTable dt 
            DataTable dt = ListToDataTable(new List<string>(){"MASV","TENSV","NGAYSINH","DIACHI","MALOP","TENDN","MATKHAU"}, danhSachSinhVien);

            DataSV.DataSource = dt;
            
            DataSV.Update();
            DataSV.Refresh();
        }

        private DataTable ListToDataTable(List<String> col, List<DTO_SinhVien> danhSachSinhVien)
        {
            DataTable dt = new DataTable();
            foreach(String s in col) 
            {
                dt.Columns.Add(s);
            }
            foreach(DTO_SinhVien sv in danhSachSinhVien)
            {
                dt.Rows.Add(new object[] { sv.maSV, sv.tenSV, sv.ngaysinhSV, sv.diachiSV, sv.malopSV, sv.tendnSV, sv.matkhauSV });
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cần nhập lại tên đăng nhập và mật khẩu để xem và giải mâ bảng điểm");
            try
            {
                String maSV = DataSV.SelectedRows[0].Cells[0].Value.ToString();
                Nhập_điểm nd = new Nhập_điểm(maNhanVien, maSV);
                nd.Show();
            }
            catch (Exception fail)
            {
                MessageBox.Show("Danh sách lớp trống");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sinh_Viên f = new Sinh_Viên(this, maNhanVien, danhSachSinhVien[DataSV.CurrentCell.RowIndex], 3);
                f.Show();
            }
            catch (Exception fail)
            {
                MessageBox.Show("Danh sách lớp trống");
            }
        }

        public void TaiLaiDanhSach()
        {
            DataSV.DataSource = null;
            TaiDanhSachHocVien(maLopDangXem, tenLopDangXem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_SinhVien.Get_instance().CapNhatSinhVien(maNhanVien, danhSachSinhVien[DataSV.CurrentCell.RowIndex], 2);
                TaiLaiDanhSach();
            }
            catch(Exception delete_fail)
            {
                MessageBox.Show("Danh sách lớp trống");
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            DTO_SinhVien empty = new DTO_SinhVien();
            Sinh_Viên f = new Sinh_Viên(this, maNhanVien, empty, 1);
            f.Show();
        }

        private void DataSV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DataSV.Columns.IndexOf(DataSV.Columns["MATKHAU"]))
            {
                if (e.Value != null)
                {
                    string hidden = "HIDDEN";
                    e.Value = hidden;
                }
                else
                    e.Value = "Null";
            }

        }
    }
}
