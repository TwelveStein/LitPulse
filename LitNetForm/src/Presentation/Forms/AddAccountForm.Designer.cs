using System.ComponentModel;

namespace LitPulse.Forms;

partial class AddAccountForm
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
        textBoxLogin = new System.Windows.Forms.TextBox();
        textBoxPassword = new System.Windows.Forms.TextBox();
        labelLogin = new System.Windows.Forms.Label();
        labelPassword = new System.Windows.Forms.Label();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        buttonAddAccount = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        labelLitNet = new System.Windows.Forms.Label();
        labelLitMarket = new System.Windows.Forms.Label();
        checkBoxLitNet = new System.Windows.Forms.CheckBox();
        checkBoxLitMarket = new System.Windows.Forms.CheckBox();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxLogin
        // 
        textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBoxLogin.Location = new System.Drawing.Point(69, 11);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new System.Drawing.Size(364, 23);
        textBoxLogin.TabIndex = 0;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBoxPassword.Location = new System.Drawing.Point(69, 57);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new System.Drawing.Size(364, 23);
        textBoxPassword.TabIndex = 1;
        // 
        // labelLogin
        // 
        labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        labelLogin.Location = new System.Drawing.Point(3, 0);
        labelLogin.Name = "labelLogin";
        labelLogin.Size = new System.Drawing.Size(60, 46);
        labelLogin.TabIndex = 2;
        labelLogin.Text = "Логин:";
        labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // labelPassword
        // 
        labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        labelPassword.Location = new System.Drawing.Point(3, 46);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new System.Drawing.Size(60, 46);
        labelPassword.TabIndex = 3;
        labelPassword.Text = "Пароль:";
        labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.347722F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.652275F));
        tableLayoutPanel1.Controls.Add(labelPassword, 0, 1);
        tableLayoutPanel1.Controls.Add(textBoxPassword, 1, 1);
        tableLayoutPanel1.Controls.Add(labelLogin, 0, 0);
        tableLayoutPanel1.Controls.Add(textBoxLogin, 1, 0);
        tableLayoutPanel1.Controls.Add(labelLitNet, 0, 2);
        tableLayoutPanel1.Controls.Add(labelLitMarket, 0, 3);
        tableLayoutPanel1.Controls.Add(checkBoxLitMarket, 1, 3);
        tableLayoutPanel1.Controls.Add(checkBoxLitNet, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
        tableLayoutPanel1.Size = new System.Drawing.Size(436, 163);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // buttonAddAccount
        // 
        buttonAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        buttonAddAccount.Location = new System.Drawing.Point(100, 6);
        buttonAddAccount.Name = "buttonAddAccount";
        buttonAddAccount.Size = new System.Drawing.Size(215, 29);
        buttonAddAccount.TabIndex = 4;
        buttonAddAccount.Text = "Сохранить";
        buttonAddAccount.UseVisualStyleBackColor = true;
        buttonAddAccount.Click += buttonAddAccount_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonAddAccount);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 163);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(436, 42);
        panel1.TabIndex = 5;
        // 
        // labelLitNet
        // 
        labelLitNet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        labelLitNet.Location = new System.Drawing.Point(3, 92);
        labelLitNet.Name = "labelLitNet";
        labelLitNet.Size = new System.Drawing.Size(60, 34);
        labelLitNet.TabIndex = 4;
        labelLitNet.Text = "LitNet:";
        labelLitNet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // labelLitMarket
        // 
        labelLitMarket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        labelLitMarket.Location = new System.Drawing.Point(3, 126);
        labelLitMarket.Name = "labelLitMarket";
        labelLitMarket.Size = new System.Drawing.Size(60, 37);
        labelLitMarket.TabIndex = 5;
        labelLitMarket.Text = "LitMarket:";
        labelLitMarket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // checkBoxLitNet
        // 
        checkBoxLitNet.Location = new System.Drawing.Point(69, 95);
        checkBoxLitNet.Name = "checkBoxLitNet";
        checkBoxLitNet.Size = new System.Drawing.Size(104, 28);
        checkBoxLitNet.TabIndex = 6;
        checkBoxLitNet.UseVisualStyleBackColor = true;
        // 
        // checkBoxLitMarket
        // 
        checkBoxLitMarket.Location = new System.Drawing.Point(69, 129);
        checkBoxLitMarket.Name = "checkBoxLitMarket";
        checkBoxLitMarket.Size = new System.Drawing.Size(104, 31);
        checkBoxLitMarket.TabIndex = 7;
        checkBoxLitMarket.UseVisualStyleBackColor = true;
        // 
        // AddAccountForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
        ClientSize = new System.Drawing.Size(436, 205);
        Controls.Add(panel1);
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Новый аккаунт";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelLitNet;
    private System.Windows.Forms.Label labelLitMarket;
    private System.Windows.Forms.CheckBox checkBoxLitNet;
    private System.Windows.Forms.CheckBox checkBoxLitMarket;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button buttonAddAccount;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.Label labelPassword;

    private System.Windows.Forms.TextBox textBoxLogin;
    private System.Windows.Forms.TextBox textBoxPassword;

    #endregion
}