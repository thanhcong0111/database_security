namespace Lab4
{
    partial class MyForm
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
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(168, 44);
            label1.Name = "label1";
            label1.Size = new Size(386, 37);
            label1.TabIndex = 0;
            label1.Text = "LOG IN YOUR ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(67, 111);
            label2.Name = "label2";
            label2.Size = new Size(160, 34);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(67, 181);
            label3.Name = "label3";
            label3.Size = new Size(152, 34);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txtAcc
            // 
            txtAcc.Location = new Point(243, 118);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(356, 27);
            txtAcc.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(243, 181);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(356, 27);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(268, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 67);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location = new Point(434, 247);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 67);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(701, 368);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtAcc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyForm";
            Text = "LOG IN";
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
