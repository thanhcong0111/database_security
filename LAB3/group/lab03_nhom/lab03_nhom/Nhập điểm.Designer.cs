
namespace lab03_nhom
{
    partial class Nhập_điểm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.Label();
            this.tbDangNhap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ma_sv = new System.Windows.Forms.Label();
            this.DataHP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataHP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGiaiMa);
            this.panel1.Controls.Add(this.tbMatKhau);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.tendangnhap);
            this.panel1.Controls.Add(this.tbDangNhap);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ma_sv);
            this.panel1.Controls.Add(this.DataHP);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 283);
            this.panel1.TabIndex = 0;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btGiaiMa.Location = new System.Drawing.Point(121, 241);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(86, 39);
            this.btGiaiMa.TabIndex = 8;
            this.btGiaiMa.Text = "Xem";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(11, 164);
            this.tbMatKhau.MaxLength = 10;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(196, 27);
            this.tbMatKhau.TabIndex = 7;
            this.tbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(7, 141);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(75, 20);
            this.matkhau.TabIndex = 6;
            this.matkhau.Text = "Mật khẩu";
            this.matkhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tendangnhap
            // 
            this.tendangnhap.AutoSize = true;
            this.tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendangnhap.Location = new System.Drawing.Point(7, 56);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(116, 20);
            this.tendangnhap.TabIndex = 5;
            this.tendangnhap.Text = "Tên đăng nhập";
            this.tendangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDangNhap
            // 
            this.tbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDangNhap.Location = new System.Drawing.Point(11, 79);
            this.tbDangNhap.MaxLength = 5;
            this.tbDangNhap.Name = "tbDangNhap";
            this.tbDangNhap.Size = new System.Drawing.Size(196, 27);
            this.tbDangNhap.TabIndex = 3;
            this.tbDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ma_sv
            // 
            this.ma_sv.Location = new System.Drawing.Point(317, 7);
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.Size = new System.Drawing.Size(147, 23);
            this.ma_sv.TabIndex = 1;
            this.ma_sv.Text = "MASV";
            this.ma_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataHP
            // 
            this.DataHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataHP.Location = new System.Drawing.Point(227, 36);
            this.DataHP.Name = "DataHP";
            this.DataHP.Size = new System.Drawing.Size(579, 244);
            this.DataHP.TabIndex = 0;
            // 
            // Nhập_điểm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 332);
            this.Controls.Add(this.panel1);
            this.Name = "Nhập_điểm";
            this.Text = "Nhập_điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataHP;
        private System.Windows.Forms.Label ma_sv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label tendangnhap;
        private System.Windows.Forms.TextBox tbDangNhap;
    }
}