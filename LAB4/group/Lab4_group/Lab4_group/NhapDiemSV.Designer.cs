namespace Lab4_group
{
    partial class NhapDiemSV
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
            label2 = new Label();
            txtMaLop = new TextBox();
            dta_NhapDiem = new DataGridView();
            label3 = new Label();
            txtDiem = new TextBox();
            btnBack = new Button();
            btnInsert = new Button();
            btnExit = new Button();
            MASV = new DataGridViewTextBoxColumn();
            MAHP = new DataGridViewTextBoxColumn();
            DIEMTHI = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dta_NhapDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGoldenrodYellow;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "NHẬP ĐIỂM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(251, 37);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(335, 38);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 2;
            // 
            // dta_NhapDiem
            // 
            dta_NhapDiem.BackgroundColor = SystemColors.ButtonHighlight;
            dta_NhapDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dta_NhapDiem.Columns.AddRange(new DataGridViewColumn[] { MASV, MAHP, DIEMTHI });
            dta_NhapDiem.Location = new Point(33, 106);
            dta_NhapDiem.Name = "dta_NhapDiem";
            dta_NhapDiem.RowHeadersWidth = 51;
            dta_NhapDiem.RowTemplate.Height = 29;
            dta_NhapDiem.Size = new Size(427, 223);
            dta_NhapDiem.TabIndex = 3;
            dta_NhapDiem.CellContentClick += dta_NhapDiem_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(33, 69);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 4;
            label3.Text = "Điểm:";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(106, 73);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(122, 27);
            txtDiem.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Firebrick;
            btnBack.Location = new Point(33, 335);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 47);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Khaki;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.Firebrick;
            btnInsert.Location = new Point(167, 335);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(143, 47);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Khaki;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Firebrick;
            btnExit.Location = new Point(345, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 47);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MASV
            // 
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "MÃ SV";
            MASV.MinimumWidth = 6;
            MASV.Name = "MASV";
            MASV.Width = 125;
            // 
            // MAHP
            // 
            MAHP.DataPropertyName = "MAHP";
            MAHP.HeaderText = "MÃ HP";
            MAHP.MinimumWidth = 6;
            MAHP.Name = "MAHP";
            MAHP.Width = 130;
            // 
            // DIEMTHI
            // 
            DIEMTHI.DataPropertyName = "DIEMTHI";
            DIEMTHI.HeaderText = "ĐIỂM";
            DIEMTHI.MinimumWidth = 6;
            DIEMTHI.Name = "DIEMTHI";
            DIEMTHI.Width = 110;
            // 
            // NhapDiemSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(492, 394);
            Controls.Add(btnExit);
            Controls.Add(btnInsert);
            Controls.Add(btnBack);
            Controls.Add(txtDiem);
            Controls.Add(label3);
            Controls.Add(dta_NhapDiem);
            Controls.Add(txtMaLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhapDiemSV";
            Text = "NhapDiemSV";
            Load += NhapDiemSV_Load;
            ((System.ComponentModel.ISupportInitialize)dta_NhapDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaLop;
        private DataGridView dta_NhapDiem;
        private Label label3;
        private TextBox txtDiem;
        private Button btnBack;
        private Button btnInsert;
        private Button btnExit;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn MAHP;
        private DataGridViewTextBoxColumn DIEMTHI;
    }
}