namespace Lab4_group
{
    partial class FormDSLop
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
            dta_lop = new DataGridView();
            MaLop = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            btn_DSSV = new Button();
            txtMaLop = new TextBox();
            label2 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dta_lop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH LỚP HỌC";
            // 
            // dta_lop
            // 
            dta_lop.BackgroundColor = SystemColors.ButtonHighlight;
            dta_lop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dta_lop.Columns.AddRange(new DataGridViewColumn[] { MaLop, TenLop, MaNV });
            dta_lop.Location = new Point(72, 90);
            dta_lop.Name = "dta_lop";
            dta_lop.RowHeadersWidth = 51;
            dta_lop.RowTemplate.Height = 29;
            dta_lop.Size = new Size(653, 293);
            dta_lop.TabIndex = 1;
            dta_lop.CellContentClick += dta_lop_CellContentClick;
            // 
            // MaLop
            // 
            MaLop.DataPropertyName = "MALOP";
            MaLop.HeaderText = "MÃ LỚP";
            MaLop.MinimumWidth = 6;
            MaLop.Name = "MaLop";
            MaLop.Width = 135;
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TENLOP";
            TenLop.HeaderText = "TÊN LỚP";
            TenLop.MinimumWidth = 6;
            TenLop.Name = "TenLop";
            TenLop.Width = 330;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MANV";
            MaNV.HeaderText = "MÃ NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 130;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Khaki;
            btnExit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Firebrick;
            btnExit.Location = new Point(595, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 49);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btn_DSSV
            // 
            btn_DSSV.BackColor = Color.Khaki;
            btn_DSSV.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DSSV.ForeColor = Color.Firebrick;
            btn_DSSV.Location = new Point(238, 389);
            btn_DSSV.Name = "btn_DSSV";
            btn_DSSV.Size = new Size(330, 49);
            btn_DSSV.TabIndex = 3;
            btn_DSSV.Text = "DS SINH VIÊN";
            btn_DSSV.UseVisualStyleBackColor = false;
            btn_DSSV.Click += btn_DSSV_Click;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(361, 53);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(135, 27);
            txtMaLop.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(270, 53);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "MÃ LỚP:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Firebrick;
            btnBack.Location = new Point(99, 389);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 49);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormDSLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(txtMaLop);
            Controls.Add(btn_DSSV);
            Controls.Add(btnExit);
            Controls.Add(dta_lop);
            Controls.Add(label1);
            Name = "FormDSLop";
            Text = "FormDSLop";
            Load += FormDSLop_Load;
            ((System.ComponentModel.ISupportInitialize)dta_lop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dta_lop;
        private Button btnExit;
        private Button btn_DSSV;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn MaNV;
        private TextBox txtMaLop;
        private Label label2;
        private Button btnBack;
    }
}