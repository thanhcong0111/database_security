namespace Lab4_group
{
    partial class FormDSSinhVien
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
            dta_SV = new DataGridView();
            MASV = new DataGridViewTextBoxColumn();
            HOTEN = new DataGridViewTextBoxColumn();
            MAHP = new DataGridViewTextBoxColumn();
            TENHP = new DataGridViewTextBoxColumn();
            DIEMTHI = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            btnBack = new Button();
            txtMaLop = new TextBox();
            label2 = new Label();
            btnNhapDiem = new Button();
            label3 = new Label();
            txtMaNV = new TextBox();
            btnEdit = new Button();
            label4 = new Label();
            label5 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            btnXem = new Button();
            ((System.ComponentModel.ISupportInitialize)dta_SV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 42);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // dta_SV
            // 
            dta_SV.BackgroundColor = SystemColors.ButtonHighlight;
            dta_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dta_SV.Columns.AddRange(new DataGridViewColumn[] { MASV, HOTEN, MAHP, TENHP, DIEMTHI });
            dta_SV.Location = new Point(53, 144);
            dta_SV.Name = "dta_SV";
            dta_SV.RowHeadersWidth = 51;
            dta_SV.RowTemplate.Height = 29;
            dta_SV.Size = new Size(706, 292);
            dta_SV.TabIndex = 1;
            dta_SV.CellContentClick += dta_SV_CellContentClick;
            // 
            // MASV
            // 
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "MÃ SV";
            MASV.MinimumWidth = 6;
            MASV.Name = "MASV";
            MASV.Width = 125;
            // 
            // HOTEN
            // 
            HOTEN.DataPropertyName = "HOTEN";
            HOTEN.HeaderText = "HỌ TÊN";
            HOTEN.MinimumWidth = 6;
            HOTEN.Name = "HOTEN";
            HOTEN.Width = 150;
            // 
            // MAHP
            // 
            MAHP.DataPropertyName = "MAHP";
            MAHP.HeaderText = "MÃ HP";
            MAHP.MinimumWidth = 6;
            MAHP.Name = "MAHP";
            MAHP.Width = 125;
            // 
            // TENHP
            // 
            TENHP.DataPropertyName = "TENHP";
            TENHP.HeaderText = "TÊN HP";
            TENHP.MinimumWidth = 6;
            TENHP.Name = "TENHP";
            TENHP.Width = 200;
            // 
            // DIEMTHI
            // 
            DIEMTHI.DataPropertyName = "DIEMTHI";
            DIEMTHI.HeaderText = "ĐIỂM";
            DIEMTHI.MinimumWidth = 6;
            DIEMTHI.Name = "DIEMTHI";
            DIEMTHI.Width = 50;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Khaki;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Firebrick;
            btnExit.Location = new Point(656, 442);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Firebrick;
            btnBack.Location = new Point(53, 442);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(205, 51);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(147, 27);
            txtMaLop.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(106, 47);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "MÃ LỚP:";
            // 
            // btnNhapDiem
            // 
            btnNhapDiem.BackColor = Color.Khaki;
            btnNhapDiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapDiem.ForeColor = Color.Firebrick;
            btnNhapDiem.Location = new Point(496, 442);
            btnNhapDiem.Name = "btnNhapDiem";
            btnNhapDiem.Size = new Size(151, 34);
            btnNhapDiem.TabIndex = 6;
            btnNhapDiem.Text = "NHẬP ĐIỂM";
            btnNhapDiem.UseVisualStyleBackColor = false;
            btnNhapDiem.Click += btnNhapDiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(458, 47);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 7;
            label3.Text = "MÃ NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(547, 48);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(147, 27);
            txtMaNV.TabIndex = 8;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Firebrick;
            btnEdit.Location = new Point(162, 442);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 100);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 10;
            label4.Text = "MÃ SV:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(414, 104);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 11;
            label5.Text = "HỌ TÊN:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(181, 100);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(199, 27);
            txtMaSV.TabIndex = 12;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(496, 100);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(199, 27);
            txtHoTen.TabIndex = 13;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.Khaki;
            btnXem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXem.ForeColor = Color.Firebrick;
            btnXem.Location = new Point(329, 442);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(151, 34);
            btnXem.TabIndex = 14;
            btnXem.Text = "XEM ĐIỂM";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // FormDSSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(805, 503);
            Controls.Add(btnXem);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnEdit);
            Controls.Add(txtMaNV);
            Controls.Add(label3);
            Controls.Add(btnNhapDiem);
            Controls.Add(label2);
            Controls.Add(txtMaLop);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(dta_SV);
            Controls.Add(label1);
            Name = "FormDSSinhVien";
            Text = "FormDSSinhVien";
            Load += FormDSSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dta_SV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dta_SV;
        private Button btnExit;
        private Button btnBack;
        private TextBox txtMaLop;
        private Label label2;
        private Button btnNhapDiem;
        private Label label3;
        private TextBox txtMaNV;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn MAHP;
        private DataGridViewTextBoxColumn TENHP;
        private DataGridViewTextBoxColumn DIEMTHI;
        private Button btnEdit;
        private Label label4;
        private Label label5;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private Button btnXem;
    }
}