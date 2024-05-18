namespace Login_Form;
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
        //this.components = new System.ComponentModel.Container();
        //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //this.ClientSize = new System.Drawing.Size(800, 450);
        //this.Text = "Form1";
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.txtAcc = new System.Windows.Forms.TextBox();
        this.txtPass = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // label1 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(195, 35);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(168, 17);
        this.label1.TabIndex = 0;
        this.label1.Text = "LOGIN YOUR ACCOUNT";
            
        // label2
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(106, 98);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(82, 17);
        this.label2.TabIndex = 1;
        this.label2.Text = "ACCOUNT NAME";

        //Label3
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(106, 167);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 17);
        this.label3.TabIndex = 2;
        this.label3.Text = "PASSWORD";

        // txtAcc
        this.txtAcc.Location = new System.Drawing.Point(226, 98);
        this.txtAcc.Name = "txtAcc";
        this.txtAcc.Size = new System.Drawing.Size(237, 22);
        this.txtAcc.TabIndex = 3;
            
        // txtPass 
        this.txtPass.Location = new System.Drawing.Point(226, 167);
        this.txtPass.Name = "txtMK";
        this.txtPass.Size = new System.Drawing.Size(237, 22);
        this.txtPass.TabIndex = 4;
        this.txtPass.UseSystemPasswordChar = true;

        // btnLogin
        this.btnLogin.Location = new System.Drawing.Point(93, 228);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(135, 53);
        this.btnLogin.TabIndex = 5;
        this.btnLogin.Text = "LOG IN";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            
        // btnExit
        this.btnExit.Location = new System.Drawing.Point(333, 228);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(135, 53);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "EXIT";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(549, 325);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.txtAcc);
        this.Controls.Add(this.txtPass);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "LOG IN SQL";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
        ﻿
    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAcc;
    private System.Windows.Forms.TextBox txtPass;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnExit;
}
