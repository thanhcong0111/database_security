namespace Lab4_group
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAcc = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(206, 38);
            label1.Name = "label1";
            label1.Size = new Size(415, 35);
            label1.TabIndex = 0;
            label1.Text = "LOG IN YOUR ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(59, 104);
            label2.Name = "label2";
            label2.Size = new Size(160, 34);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(59, 167);
            label3.Name = "label3";
            label3.Size = new Size(152, 34);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txtAcc
            // 
            txtAcc.BackColor = SystemColors.InactiveBorder;
            txtAcc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcc.Location = new Point(225, 111);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(462, 31);
            txtAcc.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.InactiveBorder;
            txtPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(225, 174);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(462, 31);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.Font = new Font("Rockwell Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Firebrick;
            btnLogin.Location = new Point(281, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 70);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Khaki;
            btnExit.Font = new Font("Rockwell Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Firebrick;
            btnExit.Location = new Point(482, 225);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 70);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(765, 340);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtAcc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "QUAN LY DANG NHAP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAcc;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
    }
}
