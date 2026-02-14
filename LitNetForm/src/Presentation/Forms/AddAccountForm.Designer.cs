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
        textBoxLogin = new TextBox();
        textBoxPassword = new TextBox();
        labelLogin = new Label();
        labelPassword = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        labelLitNet = new Label();
        labelLitMarket = new Label();
        checkBoxLitMarket = new CheckBox();
        checkBoxLitNet = new CheckBox();
        buttonAddAccount = new Button();
        panel1 = new Panel();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxLogin
        // 
        textBoxLogin.Dock = DockStyle.Fill;
        textBoxLogin.Location = new Point(90, 15);
        textBoxLogin.Margin = new Padding(10, 15, 10, 15);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new Size(400, 27);
        textBoxLogin.TabIndex = 0;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Dock = DockStyle.Fill;
        textBoxPassword.Location = new Point(90, 65);
        textBoxPassword.Margin = new Padding(10, 15, 10, 15);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new Size(400, 27);
        textBoxPassword.TabIndex = 1;
        // 
        // labelLogin
        // 
        labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelLogin.Location = new Point(3, 0);
        labelLogin.Name = "labelLogin";
        labelLogin.Size = new Size(74, 50);
        labelLogin.TabIndex = 2;
        labelLogin.Text = "Логин:";
        labelLogin.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelPassword
        // 
        labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelPassword.Location = new Point(3, 50);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new Size(74, 50);
        labelPassword.TabIndex = 3;
        labelPassword.Text = "Пароль:";
        labelPassword.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(labelPassword, 0, 1);
        tableLayoutPanel1.Controls.Add(textBoxPassword, 1, 1);
        tableLayoutPanel1.Controls.Add(labelLogin, 0, 0);
        tableLayoutPanel1.Controls.Add(textBoxLogin, 1, 0);
        tableLayoutPanel1.Controls.Add(labelLitNet, 0, 2);
        tableLayoutPanel1.Controls.Add(labelLitMarket, 0, 3);
        tableLayoutPanel1.Controls.Add(checkBoxLitMarket, 1, 3);
        tableLayoutPanel1.Controls.Add(checkBoxLitNet, 1, 2);
        tableLayoutPanel1.Dock = DockStyle.Top;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel1.MaximumSize = new Size(500, 200);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.Size = new Size(500, 200);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // labelLitNet
        // 
        labelLitNet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelLitNet.Location = new Point(3, 100);
        labelLitNet.Name = "labelLitNet";
        labelLitNet.Size = new Size(74, 50);
        labelLitNet.TabIndex = 4;
        labelLitNet.Text = "LitNet:";
        labelLitNet.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelLitMarket
        // 
        labelLitMarket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelLitMarket.Location = new Point(3, 150);
        labelLitMarket.Name = "labelLitMarket";
        labelLitMarket.Size = new Size(74, 50);
        labelLitMarket.TabIndex = 5;
        labelLitMarket.Text = "LitMarket:";
        labelLitMarket.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // checkBoxLitMarket
        // 
        checkBoxLitMarket.Dock = DockStyle.Fill;
        checkBoxLitMarket.Location = new Point(83, 154);
        checkBoxLitMarket.Margin = new Padding(3, 4, 3, 4);
        checkBoxLitMarket.Name = "checkBoxLitMarket";
        checkBoxLitMarket.Size = new Size(414, 42);
        checkBoxLitMarket.TabIndex = 7;
        checkBoxLitMarket.UseVisualStyleBackColor = true;
        // 
        // checkBoxLitNet
        // 
        checkBoxLitNet.Dock = DockStyle.Fill;
        checkBoxLitNet.Location = new Point(83, 104);
        checkBoxLitNet.Margin = new Padding(3, 4, 3, 4);
        checkBoxLitNet.Name = "checkBoxLitNet";
        checkBoxLitNet.Size = new Size(414, 42);
        checkBoxLitNet.TabIndex = 6;
        checkBoxLitNet.UseVisualStyleBackColor = true;
        // 
        // buttonAddAccount
        // 
        buttonAddAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        buttonAddAccount.Location = new Point(114, 8);
        buttonAddAccount.Margin = new Padding(3, 4, 3, 4);
        buttonAddAccount.Name = "buttonAddAccount";
        buttonAddAccount.Size = new Size(250, 36);
        buttonAddAccount.TabIndex = 4;
        buttonAddAccount.Text = "Сохранить";
        buttonAddAccount.UseVisualStyleBackColor = true;
        buttonAddAccount.Click += buttonAddAccount_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonAddAccount);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 200);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(502, 53);
        panel1.TabIndex = 5;
        // 
        // AddAccountForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoValidate = AutoValidate.EnablePreventFocusChange;
        ClientSize = new Size(502, 253);
        Controls.Add(panel1);
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new Size(520, 300);
        MinimizeBox = false;
        MinimumSize = new Size(520, 300);
        Name = "AddAccountForm";
        StartPosition = FormStartPosition.CenterParent;
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