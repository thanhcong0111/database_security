namespace Lab4
{
    partial class FormDSNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtMK = new TextBox();
            txtLuong = new TextBox();
            txtHoTen = new TextBox();
            lbMK = new Label();
            lbLuong = new Label();
            lbHoTen = new Label();
            txtTenDN = new TextBox();
            txtEmail = new TextBox();
            txtMaNV = new TextBox();
            lbTenDN = new Label();
            lbEmail = new Label();
            lbMaNV = new Label();
            dta_nhanvien = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnGhi = new Button();
            btnKo = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dta_nhanvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtLuong);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lbMK);
            groupBox1.Controls.Add(lbLuong);
            groupBox1.Controls.Add(lbHoTen);
            groupBox1.Controls.Add(txtTenDN);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(lbTenDN);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbMaNV);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(31, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(488, 109);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(217, 30);
            txtMK.TabIndex = 11;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(488, 67);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(217, 30);
            txtLuong.TabIndex = 10;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(488, 24);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(217, 30);
            txtHoTen.TabIndex = 9;
            // 
            // lbMK
            // 
            lbMK.AutoSize = true;
            lbMK.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMK.ForeColor = SystemColors.Desktop;
            lbMK.Location = new Point(389, 112);
            lbMK.Name = "lbMK";
            lbMK.Size = new Size(103, 28);
            lbMK.TabIndex = 8;
            lbMK.Text = "Mật khẩu ";
            // 
            // lbLuong
            // 
            lbLuong.AutoSize = true;
            lbLuong.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLuong.ForeColor = SystemColors.Desktop;
            lbLuong.Location = new Point(389, 69);
            lbLuong.Name = "lbLuong";
            lbLuong.Size = new Size(68, 28);
            lbLuong.TabIndex = 7;
            lbLuong.Text = "Lương";
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbHoTen.ForeColor = SystemColors.Desktop;
            lbHoTen.Location = new Point(389, 26);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(71, 28);
            lbHoTen.TabIndex = 6;
            lbHoTen.Text = "Họ tên";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(166, 109);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(217, 30);
            txtTenDN.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 30);
            txtEmail.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(166, 24);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(217, 30);
            txtMaNV.TabIndex = 3;
            // 
            // lbTenDN
            // 
            lbTenDN.AutoSize = true;
            lbTenDN.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenDN.ForeColor = SystemColors.Desktop;
            lbTenDN.Location = new Point(24, 107);
            lbTenDN.Name = "lbTenDN";
            lbTenDN.Size = new Size(141, 28);
            lbTenDN.TabIndex = 2;
            lbTenDN.Text = "Tên đăng nhâp";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.ForeColor = SystemColors.Desktop;
            lbEmail.Location = new Point(24, 64);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(59, 28);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaNV.ForeColor = SystemColors.Desktop;
            lbMaNV.Location = new Point(24, 22);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(72, 28);
            lbMaNV.TabIndex = 0;
            lbMaNV.Text = "Mã NV";
            // 
            // dta_nhanvien
            // 
            dta_nhanvien.BackgroundColor = SystemColors.GradientActiveCaption;
            dta_nhanvien.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dta_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dta_nhanvien.GridColor = SystemColors.ButtonFace;
            dta_nhanvien.Location = new Point(31, 227);
            dta_nhanvien.Name = "dta_nhanvien";
            dta_nhanvien.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dta_nhanvien.RowHeadersWidth = 51;
            dta_nhanvien.RowTemplate.Height = 29;
            dta_nhanvien.Size = new Size(725, 281);
            dta_nhanvien.TabIndex = 12;
            dta_nhanvien.CellContentClick += dta_nhanvien_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(55, 470);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(166, 470);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(279, 470);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(403, 470);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(107, 29);
            btnGhi.TabIndex = 16;
            btnGhi.Text = "Ghi/Lưu";
            btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnKo
            // 
            btnKo.Location = new Point(516, 470);
            btnKo.Name = "btnKo";
            btnKo.Size = new Size(107, 29);
            btnKo.TabIndex = 17;
            btnKo.Text = "Không";
            btnKo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(629, 470);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDSNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 520);
            Controls.Add(btnThoat);
            Controls.Add(btnKo);
            Controls.Add(btnGhi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dta_nhanvien);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormDSNhanVien";
            Text = "Danh mục nhân viên ";
            Load += FormDSNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dta_nhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lbEmail;
        private Label lbMaNV;
        private TextBox txtMaNV;
        private Label lbTenDN;
        private TextBox txtLuong;
        private TextBox txtHoTen;
        private Label lbMK;
        private Label lbLuong;
        private Label lbHoTen;
        private TextBox txtTenDN;
        private TextBox txtEmail;
        private TextBox txtMK;
        private DataGridView dta_nhanvien;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnGhi;
        private Button btnKo;
        private Button btnThoat;
    }
}