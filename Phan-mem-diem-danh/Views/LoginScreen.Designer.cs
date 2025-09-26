using System.ComponentModel;

namespace Phan_mem_diem_danh.Views;

partial class LoginScreen
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        txtMSV = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        SuspendLayout();
        // 
        // txtMSV
        // 
        txtMSV.Location = new Point(290, 237);
        txtMSV.Name = "txtMSV";
        txtMSV.Size = new Size(223, 27);
        txtMSV.TabIndex = 0;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(290, 292);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(223, 27);
        txtPassword.TabIndex = 1;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(351, 367);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(94, 29);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += button1_Click;
        // 
        // LoginScreen
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(txtMSV);
        Name = "LoginScreen";
        Text = "LoginScreen";
        Load += LoginScreen_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtMSV;
    private TextBox txtPassword;
    private Button btnLogin;
}