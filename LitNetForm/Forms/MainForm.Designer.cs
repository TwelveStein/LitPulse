namespace LitNetForm.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSaveReport = new Button();
            dataGridViewReport = new DataGridView();
            Status = new DataGridViewTextBoxColumn();
            Operation = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonStop = new Button();
            buttonStartSession = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            dataGridViewLinks = new DataGridView();
            Link = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            buttonClearLinks = new Button();
            buttonDeleteLink = new Button();
            buttonAddLink = new Button();
            buttonImportLinks = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridViewAccounts = new DataGridView();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            buttonClearAccounts = new Button();
            buttonDeleteAccount = new Button();
            buttonImportAccounts = new Button();
            buttonAddAccount = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            richTextBoxProfile = new RichTextBox();
            label4 = new Label();
            comboBoxReadProfiles = new ComboBox();
            label6 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            buttonUploadLogs = new Button();
            richTextBoxLog = new RichTextBox();
            label5 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            buttonAccountGenerator = new Button();
            button_instruction = new Button();
            buttonOtherSettings = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinks).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(1034, 415);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 4);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel2.Size = new Size(1024, 255);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveReport, 0, 3);
            tableLayoutPanel4.Controls.Add(dataGridViewReport, 0, 2);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(685, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(336, 251);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Dock = DockStyle.Fill;
            buttonSaveReport.Enabled = false;
            buttonSaveReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveReport.Image = LitPulse.Properties.Resources.DownLoadIcon;
            buttonSaveReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveReport.Location = new Point(3, 213);
            buttonSaveReport.Margin = new Padding(3, 2, 3, 2);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(330, 36);
            buttonSaveReport.TabIndex = 7;
            buttonSaveReport.Text = "Скачать отчет";
            buttonSaveReport.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToOrderColumns = true;
            dataGridViewReport.BackgroundColor = SystemColors.Control;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] { Status, Operation });
            dataGridViewReport.Dock = DockStyle.Fill;
            dataGridViewReport.Enabled = false;
            dataGridViewReport.Location = new Point(3, 57);
            dataGridViewReport.Margin = new Padding(3, 2, 3, 2);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(330, 152);
            dataGridViewReport.TabIndex = 6;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Operation
            // 
            Operation.HeaderText = "Операция";
            Operation.MinimumWidth = 6;
            Operation.Name = "Operation";
            Operation.ReadOnly = true;
            Operation.Width = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(330, 15);
            label3.TabIndex = 3;
            label3.Text = "Отчет (Не реализовано)";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel5.Controls.Add(buttonStop, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 2);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.Size = new Size(330, 36);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Red;
            buttonStop.Dock = DockStyle.Fill;
            buttonStop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStop.ForeColor = SystemColors.ControlText;
            buttonStop.Image = LitPulse.Properties.Resources.StopIcon;
            buttonStop.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStop.Location = new Point(195, 2);
            buttonStop.Margin = new Padding(3, 2, 3, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(132, 32);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "СТОП";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStartSession
            // 
            buttonStartSession.BackColor = Color.YellowGreen;
            buttonStartSession.Dock = DockStyle.Fill;
            buttonStartSession.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStartSession.ForeColor = SystemColors.ControlText;
            buttonStartSession.Image = LitPulse.Properties.Resources.StartIcon;
            buttonStartSession.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStartSession.Location = new Point(3, 2);
            buttonStartSession.Margin = new Padding(3, 2, 3, 2);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(186, 32);
            buttonStartSession.TabIndex = 6;
            buttonStartSession.Text = "ЗАПУСК СЕАНСА";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(dataGridViewLinks, 0, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(344, 2);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.Size = new Size(335, 251);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridViewLinks
            // 
            dataGridViewLinks.AllowUserToOrderColumns = true;
            dataGridViewLinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLinks.Columns.AddRange(new DataGridViewColumn[] { Link });
            dataGridViewLinks.Dock = DockStyle.Fill;
            dataGridViewLinks.Location = new Point(3, 17);
            dataGridViewLinks.Margin = new Padding(3, 2, 3, 2);
            dataGridViewLinks.Name = "dataGridViewLinks";
            dataGridViewLinks.RowHeadersWidth = 51;
            dataGridViewLinks.Size = new Size(329, 192);
            dataGridViewLinks.TabIndex = 1;
            // 
            // Link
            // 
            Link.DataPropertyName = "Link";
            Link.HeaderText = "Ссылка";
            Link.MinimumWidth = 100;
            Link.Name = "Link";
            Link.Width = 700;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Ссылки";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel10.Controls.Add(buttonClearLinks, 3, 0);
            tableLayoutPanel10.Controls.Add(buttonDeleteLink, 2, 0);
            tableLayoutPanel10.Controls.Add(buttonAddLink, 1, 0);
            tableLayoutPanel10.Controls.Add(buttonImportLinks, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 213);
            tableLayoutPanel10.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(329, 36);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // buttonClearLinks
            // 
            buttonClearLinks.BackColor = Color.Red;
            buttonClearLinks.Dock = DockStyle.Fill;
            buttonClearLinks.Image = LitPulse.Properties.Resources.ClearIcon_White;
            buttonClearLinks.Location = new Point(292, 2);
            buttonClearLinks.Margin = new Padding(3, 2, 3, 2);
            buttonClearLinks.Name = "buttonClearLinks";
            buttonClearLinks.Size = new Size(34, 32);
            buttonClearLinks.TabIndex = 8;
            buttonClearLinks.UseVisualStyleBackColor = false;
            buttonClearLinks.Click += buttonClearLinks_Click;
            // 
            // buttonDeleteLink
            // 
            buttonDeleteLink.Dock = DockStyle.Fill;
            buttonDeleteLink.Image = LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonDeleteLink.Location = new Point(252, 2);
            buttonDeleteLink.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteLink.Name = "buttonDeleteLink";
            buttonDeleteLink.Size = new Size(34, 32);
            buttonDeleteLink.TabIndex = 7;
            buttonDeleteLink.UseVisualStyleBackColor = true;
            buttonDeleteLink.Click += buttonDeleteLink_Click;
            // 
            // buttonAddLink
            // 
            buttonAddLink.Dock = DockStyle.Fill;
            buttonAddLink.Image = LitPulse.Properties.Resources.AddIcon;
            buttonAddLink.Location = new Point(212, 2);
            buttonAddLink.Margin = new Padding(3, 2, 3, 2);
            buttonAddLink.Name = "buttonAddLink";
            buttonAddLink.Size = new Size(34, 32);
            buttonAddLink.TabIndex = 6;
            buttonAddLink.UseVisualStyleBackColor = true;
            buttonAddLink.Click += buttonAddLink_Click;
            // 
            // buttonImportLinks
            // 
            buttonImportLinks.Dock = DockStyle.Fill;
            buttonImportLinks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportLinks.Image = LitPulse.Properties.Resources.uploadIcon;
            buttonImportLinks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportLinks.Location = new Point(3, 2);
            buttonImportLinks.Margin = new Padding(3, 2, 3, 2);
            buttonImportLinks.Name = "buttonImportLinks";
            buttonImportLinks.Size = new Size(203, 32);
            buttonImportLinks.TabIndex = 5;
            buttonImportLinks.Text = "Импорт ссылок";
            buttonImportLinks.UseVisualStyleBackColor = true;
            buttonImportLinks.Click += buttonImportLinks_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridViewAccounts, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(335, 251);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.AllowUserToOrderColumns = true;
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Columns.AddRange(new DataGridViewColumn[] { Login, Password });
            dataGridViewAccounts.Dock = DockStyle.Fill;
            dataGridViewAccounts.Location = new Point(3, 17);
            dataGridViewAccounts.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.RowHeadersWidth = 51;
            dataGridViewAccounts.Size = new Size(329, 192);
            dataGridViewAccounts.TabIndex = 1;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Логин";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.Width = 350;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 350;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Аккаунты";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.Controls.Add(buttonClearAccounts, 3, 0);
            tableLayoutPanel9.Controls.Add(buttonDeleteAccount, 2, 0);
            tableLayoutPanel9.Controls.Add(buttonImportAccounts, 0, 0);
            tableLayoutPanel9.Controls.Add(buttonAddAccount, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 213);
            tableLayoutPanel9.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(329, 36);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // buttonClearAccounts
            // 
            buttonClearAccounts.BackColor = Color.Red;
            buttonClearAccounts.Dock = DockStyle.Fill;
            buttonClearAccounts.Image = LitPulse.Properties.Resources.ClearIcon_White;
            buttonClearAccounts.Location = new Point(292, 2);
            buttonClearAccounts.Margin = new Padding(3, 2, 3, 2);
            buttonClearAccounts.Name = "buttonClearAccounts";
            buttonClearAccounts.Size = new Size(34, 32);
            buttonClearAccounts.TabIndex = 7;
            buttonClearAccounts.UseVisualStyleBackColor = false;
            buttonClearAccounts.Click += buttonClearAccounts_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.Dock = DockStyle.Fill;
            buttonDeleteAccount.Image = LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonDeleteAccount.Location = new Point(252, 2);
            buttonDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(34, 32);
            buttonDeleteAccount.TabIndex = 6;
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // buttonImportAccounts
            // 
            buttonImportAccounts.Dock = DockStyle.Fill;
            buttonImportAccounts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportAccounts.Image = LitPulse.Properties.Resources.uploadIcon;
            buttonImportAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportAccounts.Location = new Point(3, 2);
            buttonImportAccounts.Margin = new Padding(3, 2, 3, 2);
            buttonImportAccounts.Name = "buttonImportAccounts";
            buttonImportAccounts.Size = new Size(203, 32);
            buttonImportAccounts.TabIndex = 4;
            buttonImportAccounts.Text = "Импорт аккаунтов";
            buttonImportAccounts.UseVisualStyleBackColor = true;
            buttonImportAccounts.Click += buttonImportAccounts_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Dock = DockStyle.Fill;
            buttonAddAccount.Image = LitPulse.Properties.Resources.AddIcon;
            buttonAddAccount.Location = new Point(212, 2);
            buttonAddAccount.Margin = new Padding(3, 2, 3, 2);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(34, 32);
            buttonAddAccount.TabIndex = 5;
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 2, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel11, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(5, 265);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel7.Size = new Size(1024, 146);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxProfile);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxReadProfiles);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(335, 142);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры";
            // 
            // richTextBoxProfile
            // 
            richTextBoxProfile.BackColor = SystemColors.Control;
            richTextBoxProfile.BorderStyle = BorderStyle.None;
            richTextBoxProfile.Dock = DockStyle.Fill;
            richTextBoxProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxProfile.Location = new Point(3, 71);
            richTextBoxProfile.Margin = new Padding(3, 2, 3, 2);
            richTextBoxProfile.Name = "richTextBoxProfile";
            richTextBoxProfile.Size = new Size(329, 69);
            richTextBoxProfile.TabIndex = 9;
            richTextBoxProfile.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 56);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 8;
            label4.Text = "Описание профиля:";
            // 
            // comboBoxReadProfiles
            // 
            comboBoxReadProfiles.Dock = DockStyle.Top;
            comboBoxReadProfiles.FormattingEnabled = true;
            comboBoxReadProfiles.Items.AddRange(new object[] { "Быстрое чтение", "Глубокое чтение", "Уставшее чтение" });
            comboBoxReadProfiles.Location = new Point(3, 33);
            comboBoxReadProfiles.Margin = new Padding(3, 2, 3, 2);
            comboBoxReadProfiles.Name = "comboBoxReadProfiles";
            comboBoxReadProfiles.Size = new Size(329, 23);
            comboBoxReadProfiles.TabIndex = 7;
            comboBoxReadProfiles.SelectedIndexChanged += comboBoxReadProfiles_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 18);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 6;
            label6.Text = "Профили чтения";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(buttonUploadLogs, 0, 2);
            tableLayoutPanel8.Controls.Add(richTextBoxLog, 0, 1);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(685, 2);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel8.Size = new Size(336, 142);
            tableLayoutPanel8.TabIndex = 12;
            // 
            // buttonUploadLogs
            // 
            buttonUploadLogs.Dock = DockStyle.Fill;
            buttonUploadLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonUploadLogs.Image = LitPulse.Properties.Resources.DownLoadIcon;
            buttonUploadLogs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUploadLogs.Location = new Point(3, 104);
            buttonUploadLogs.Margin = new Padding(3, 2, 3, 2);
            buttonUploadLogs.Name = "buttonUploadLogs";
            buttonUploadLogs.Size = new Size(330, 36);
            buttonUploadLogs.TabIndex = 8;
            buttonUploadLogs.Text = "Выгрузить логи";
            buttonUploadLogs.UseVisualStyleBackColor = true;
            buttonUploadLogs.Click += buttonUploadLogs_Click;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(3, 17);
            richTextBoxLog.Margin = new Padding(3, 2, 3, 2);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(330, 83);
            richTextBoxLog.TabIndex = 2;
            richTextBoxLog.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(330, 15);
            label5.TabIndex = 1;
            label5.Text = "Лог";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(buttonAccountGenerator, 0, 1);
            tableLayoutPanel11.Controls.Add(button_instruction, 0, 2);
            tableLayoutPanel11.Controls.Add(buttonOtherSettings, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel11.Location = new Point(344, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 4;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(335, 140);
            tableLayoutPanel11.TabIndex = 13;
            // 
            // buttonAccountGenerator
            // 
            buttonAccountGenerator.Dock = DockStyle.Fill;
            buttonAccountGenerator.Enabled = false;
            buttonAccountGenerator.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAccountGenerator.Image = LitPulse.Properties.Resources.AccountGeneratorIcon;
            buttonAccountGenerator.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccountGenerator.Location = new Point(3, 42);
            buttonAccountGenerator.Margin = new Padding(3, 2, 3, 2);
            buttonAccountGenerator.Name = "buttonAccountGenerator";
            buttonAccountGenerator.Size = new Size(329, 36);
            buttonAccountGenerator.TabIndex = 15;
            buttonAccountGenerator.Text = "Генератор аккаунтов";
            buttonAccountGenerator.UseVisualStyleBackColor = true;
            buttonAccountGenerator.Click += buttonAccountGenerator_Click;
            // 
            // button_instruction
            // 
            button_instruction.Dock = DockStyle.Fill;
            button_instruction.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_instruction.Image = LitPulse.Properties.Resources.InstructionIcon;
            button_instruction.ImageAlign = ContentAlignment.MiddleLeft;
            button_instruction.Location = new Point(3, 82);
            button_instruction.Margin = new Padding(3, 2, 3, 2);
            button_instruction.Name = "button_instruction";
            button_instruction.Size = new Size(329, 36);
            button_instruction.TabIndex = 14;
            button_instruction.Text = "Инструкция";
            button_instruction.UseVisualStyleBackColor = true;
            button_instruction.Click += button_instruction_Click;
            // 
            // buttonOtherSettings
            // 
            buttonOtherSettings.Dock = DockStyle.Fill;
            buttonOtherSettings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOtherSettings.Image = LitPulse.Properties.Resources.SettingsIcon;
            buttonOtherSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOtherSettings.Location = new Point(3, 2);
            buttonOtherSettings.Margin = new Padding(3, 2, 3, 2);
            buttonOtherSettings.Name = "buttonOtherSettings";
            buttonOtherSettings.Size = new Size(329, 36);
            buttonOtherSettings.TabIndex = 12;
            buttonOtherSettings.Text = "Дополнительные параметры";
            buttonOtherSettings.UseVisualStyleBackColor = true;
            buttonOtherSettings.Click += buttonOtherSettings_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 415);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LitPulse";
            FormClosing += MainForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinks).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridViewAccounts;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dataGridViewLinks;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Button buttonSaveReport;
        private DataGridView dataGridViewReport;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Operation;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonStartSession;
        private Button buttonStop;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxProfile;
        private Label label4;
        private ComboBox comboBoxReadProfiles;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private Button buttonUploadLogs;
        private RichTextBox richTextBoxLog;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Link;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private TableLayoutPanel tableLayoutPanel9;
        private Button buttonImportAccounts;
        private TableLayoutPanel tableLayoutPanel10;
        private Button buttonDeleteLink;
        private Button buttonAddLink;
        private Button buttonImportLinks;
        private Button buttonDeleteAccount;
        private Button buttonAddAccount;
        private Button buttonClearLinks;
        private Button buttonClearAccounts;
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel11;
        private Button buttonOtherSettings;
        private Button buttonAccountGenerator;
        private Button button_instruction;
    }
}