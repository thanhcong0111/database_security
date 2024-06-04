namespace Lab4_group
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
            dta_nhanvien = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Luong = new DataGridViewTextBoxColumn();
            TenDN = new DataGridViewTextBoxColumn();
            btnDSLop = new Button();
            btnExit = new Button();
            btnXemLuong = new Button();
            btnAddNV = new Button();
            ((System.ComponentModel.ISupportInitialize)dta_nhanvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(192, 18);
            label1.Name = "label1";
            label1.Size = new Size(436, 42);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dta_nhanvien
            // 
            dta_nhanvien.BackgroundColor = SystemColors.ButtonHighlight;
            dta_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dta_nhanvien.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTen, Email, Luong, TenDN });
            dta_nhanvien.Location = new Point(62, 98);
            dta_nhanvien.Name = "dta_nhanvien";
            dta_nhanvien.RowHeadersWidth = 51;
            dta_nhanvien.RowTemplate.Height = 29;
            dta_nhanvien.Size = new Size(687, 298);
            dta_nhanvien.TabIndex = 1;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MANV";
            MaNV.HeaderText = "MÃ NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HOTEN";
            HoTen.HeaderText = "HỌ TÊN";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "EMAIL";
            Email.HeaderText = "EMAIL";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Luong
            // 
            Luong.DataPropertyName = "LUONG";
            Luong.HeaderText = "LƯƠNG";
            Luong.MinimumWidth = 6;
            Luong.Name = "Luong";
            Luong.Width = 125;
            // 
            // TenDN
            // 
            TenDN.DataPropertyName = "TENDN";
            TenDN.HeaderText = "TÊN DN";
            TenDN.MinimumWidth = 6;
            TenDN.Name = "TenDN";
            TenDN.Width = 125;
            // 
            // btnDSLop
            // 
            btnDSLop.BackColor = Color.Khaki;
            btnDSLop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDSLop.ForeColor = Color.Firebrick;
            btnDSLop.Location = new Point(84, 402);
            btnDSLop.Name = "btnDSLop";
            btnDSLop.Size = new Size(297, 36);
            btnDSLop.TabIndex = 2;
            btnDSLop.Text = "DANH SÁCH LỚP HỌC";
            btnDSLop.UseVisualStyleBackColor = false;
            btnDSLop.Click += btnDSLop_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Khaki;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Firebrick;
            btnExit.Location = new Point(417, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(293, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnXemLuong
            // 
            btnXemLuong.BackColor = Color.Khaki;
            btnXemLuong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemLuong.ForeColor = Color.Firebrick;
            btnXemLuong.Location = new Point(518, 56);
            btnXemLuong.Name = "btnXemLuong";
            btnXemLuong.Size = new Size(192, 36);
            btnXemLuong.TabIndex = 5;
            btnXemLuong.Text = "XEM LUONG";
            btnXemLuong.UseVisualStyleBackColor = false;
            btnXemLuong.Click += btnXemLuong_Click;
            // 
            // btnAddNV
            // 
            btnAddNV.BackColor = Color.Khaki;
            btnAddNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNV.ForeColor = Color.Firebrick;
            btnAddNV.Location = new Point(101, 56);
            btnAddNV.Name = "btnAddNV";
            btnAddNV.Size = new Size(192, 36);
            btnAddNV.TabIndex = 6;
            btnAddNV.Text = "ADD NHÂN VIÊN";
            btnAddNV.UseVisualStyleBackColor = false;
            btnAddNV.Click += btnAddNV_Click;
            // 
            // FormDSNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNV);
            Controls.Add(btnXemLuong);
            Controls.Add(btnExit);
            Controls.Add(btnDSLop);
            Controls.Add(dta_nhanvien);
            Controls.Add(label1);
            Name = "FormDSNhanVien";
            Text = "FormDSNhanVien";
            Load += FormDSNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dta_nhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dta_nhanvien;
        private Button btnDSLop;
        private Button button2;
        private Button btnExit;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Luong;
        private DataGridViewTextBoxColumn TenDN;
        private Button btnAdd;
        private Button btnXemLuong;
        private Button btnAddNV;
    }
}