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
            components = new System.ComponentModel.Container();
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
            checkBoxRunningInMultithreadingMode = new CheckBox();
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
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBoxReadBook = new CheckBox();
            checkBoxLikeTheBook = new CheckBox();
            checkBoxAddToLibrary = new CheckBox();
            checkBoxSubscribeToTheAuthor = new CheckBox();
            checkBoxPostComment = new CheckBox();
            checkBoxMakeADonationToTheAuthor = new CheckBox();
            checkBoxBuyABook = new CheckBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            numericUpDownConstantDelay = new NumericUpDown();
            numericUpDownFloatingIncrementalDelay = new NumericUpDown();
            groupBox1 = new GroupBox();
            richTextBoxProfile = new RichTextBox();
            label4 = new Label();
            comboBoxReadProfiles = new ComboBox();
            label6 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            richTextBoxLog = new RichTextBox();
            label5 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            buttonAccountGenerator = new Button();
            button_instruction = new Button();
            buttonUploadLogs = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
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
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstantDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloatingIncrementalDelay).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Size = new Size(1582, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5098038F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2352943F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2549F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1572, 421);
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
            tableLayoutPanel4.Location = new Point(989, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel4.Size = new Size(580, 415);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Dock = DockStyle.Fill;
            buttonSaveReport.Enabled = false;
            buttonSaveReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveReport.Image = LitPulse.Properties.Resources.DownLoadIcon;
            buttonSaveReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveReport.Location = new Point(3, 365);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(574, 47);
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
            dataGridViewReport.Location = new Point(3, 116);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(574, 243);
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
            label3.Location = new Point(3, 93);
            label3.Name = "label3";
            label3.Size = new Size(574, 20);
            label3.TabIndex = 3;
            label3.Text = "Отчет (Не реализовано)";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.33333F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel5.Controls.Add(checkBoxRunningInMultithreadingMode, 0, 1);
            tableLayoutPanel5.Controls.Add(buttonStop, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(574, 87);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // checkBoxRunningInMultithreadingMode
            // 
            checkBoxRunningInMultithreadingMode.AutoSize = true;
            checkBoxRunningInMultithreadingMode.Location = new Point(3, 56);
            checkBoxRunningInMultithreadingMode.Name = "checkBoxRunningInMultithreadingMode";
            checkBoxRunningInMultithreadingMode.Size = new Size(300, 24);
            checkBoxRunningInMultithreadingMode.TabIndex = 8;
            checkBoxRunningInMultithreadingMode.Text = "Запускать в режиме многопоточности";
            toolTip1.SetToolTip(checkBoxRunningInMultithreadingMode, "При включенном параметре программа начинает работать в режиме многопоточности, \r\nгде каждый аккаунт - это отдельное окно браузера. (!!!Требует больших ресурсов компьютера!!!)");
            checkBoxRunningInMultithreadingMode.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Red;
            buttonStop.Dock = DockStyle.Fill;
            buttonStop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStop.ForeColor = SystemColors.ControlText;
            buttonStop.Image = LitPulse.Properties.Resources.StopIcon;
            buttonStop.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStop.Location = new Point(337, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(234, 47);
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
            buttonStartSession.Location = new Point(3, 3);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(328, 47);
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
            tableLayoutPanel6.Location = new Point(388, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel6.Size = new Size(595, 415);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridViewLinks
            // 
            dataGridViewLinks.AllowUserToOrderColumns = true;
            dataGridViewLinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLinks.Columns.AddRange(new DataGridViewColumn[] { Link });
            dataGridViewLinks.Dock = DockStyle.Fill;
            dataGridViewLinks.Location = new Point(3, 23);
            dataGridViewLinks.Name = "dataGridViewLinks";
            dataGridViewLinks.RowHeadersWidth = 51;
            dataGridViewLinks.Size = new Size(589, 336);
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
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Ссылки";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel10.Controls.Add(buttonClearLinks, 3, 0);
            tableLayoutPanel10.Controls.Add(buttonDeleteLink, 2, 0);
            tableLayoutPanel10.Controls.Add(buttonAddLink, 1, 0);
            tableLayoutPanel10.Controls.Add(buttonImportLinks, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 365);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(589, 47);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // buttonClearLinks
            // 
            buttonClearLinks.BackColor = Color.Red;
            buttonClearLinks.Dock = DockStyle.Fill;
            buttonClearLinks.Image = LitPulse.Properties.Resources.ClearIcon_White;
            buttonClearLinks.Location = new Point(546, 3);
            buttonClearLinks.Name = "buttonClearLinks";
            buttonClearLinks.Size = new Size(40, 41);
            buttonClearLinks.TabIndex = 8;
            toolTip1.SetToolTip(buttonClearLinks, "Очистить список ссылок");
            buttonClearLinks.UseVisualStyleBackColor = false;
            buttonClearLinks.Click += buttonClearLinks_Click;
            // 
            // buttonDeleteLink
            // 
            buttonDeleteLink.Dock = DockStyle.Fill;
            buttonDeleteLink.Image = LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonDeleteLink.Location = new Point(500, 3);
            buttonDeleteLink.Name = "buttonDeleteLink";
            buttonDeleteLink.Size = new Size(40, 41);
            buttonDeleteLink.TabIndex = 7;
            toolTip1.SetToolTip(buttonDeleteLink, "Удалить ссылку из списка");
            buttonDeleteLink.UseVisualStyleBackColor = true;
            buttonDeleteLink.Click += buttonDeleteLink_Click;
            // 
            // buttonAddLink
            // 
            buttonAddLink.Dock = DockStyle.Fill;
            buttonAddLink.Image = LitPulse.Properties.Resources.AddIcon;
            buttonAddLink.Location = new Point(454, 3);
            buttonAddLink.Name = "buttonAddLink";
            buttonAddLink.Size = new Size(40, 41);
            buttonAddLink.TabIndex = 6;
            toolTip1.SetToolTip(buttonAddLink, "Добавить новую строку в список");
            buttonAddLink.UseVisualStyleBackColor = true;
            buttonAddLink.Click += buttonAddLink_Click;
            // 
            // buttonImportLinks
            // 
            buttonImportLinks.Dock = DockStyle.Fill;
            buttonImportLinks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportLinks.Image = LitPulse.Properties.Resources.uploadIcon;
            buttonImportLinks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportLinks.Location = new Point(3, 3);
            buttonImportLinks.Name = "buttonImportLinks";
            buttonImportLinks.Size = new Size(445, 41);
            buttonImportLinks.TabIndex = 5;
            buttonImportLinks.Text = "Импорт ссылок";
            toolTip1.SetToolTip(buttonImportLinks, "Выбрать файл");
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
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.Size = new Size(379, 415);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.AllowUserToOrderColumns = true;
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Columns.AddRange(new DataGridViewColumn[] { Login, Password });
            dataGridViewAccounts.Dock = DockStyle.Fill;
            dataGridViewAccounts.Location = new Point(3, 23);
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.RowHeadersWidth = 51;
            dataGridViewAccounts.Size = new Size(373, 336);
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
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Аккаунты";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel9.Controls.Add(buttonClearAccounts, 3, 0);
            tableLayoutPanel9.Controls.Add(buttonDeleteAccount, 2, 0);
            tableLayoutPanel9.Controls.Add(buttonImportAccounts, 0, 0);
            tableLayoutPanel9.Controls.Add(buttonAddAccount, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 365);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(373, 47);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // buttonClearAccounts
            // 
            buttonClearAccounts.BackColor = Color.Red;
            buttonClearAccounts.Dock = DockStyle.Fill;
            buttonClearAccounts.Image = LitPulse.Properties.Resources.ClearIcon_White;
            buttonClearAccounts.Location = new Point(330, 3);
            buttonClearAccounts.Name = "buttonClearAccounts";
            buttonClearAccounts.Size = new Size(40, 41);
            buttonClearAccounts.TabIndex = 7;
            toolTip1.SetToolTip(buttonClearAccounts, "Очистить список аккаунтов");
            buttonClearAccounts.UseVisualStyleBackColor = false;
            buttonClearAccounts.Click += buttonClearAccounts_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.Dock = DockStyle.Fill;
            buttonDeleteAccount.Image = LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonDeleteAccount.Location = new Point(284, 3);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(40, 41);
            buttonDeleteAccount.TabIndex = 6;
            toolTip1.SetToolTip(buttonDeleteAccount, "Удалить аккаунт из списка");
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // buttonImportAccounts
            // 
            buttonImportAccounts.Dock = DockStyle.Fill;
            buttonImportAccounts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportAccounts.Image = LitPulse.Properties.Resources.uploadIcon;
            buttonImportAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportAccounts.Location = new Point(3, 3);
            buttonImportAccounts.Name = "buttonImportAccounts";
            buttonImportAccounts.Size = new Size(229, 41);
            buttonImportAccounts.TabIndex = 4;
            buttonImportAccounts.Text = "Импорт аккаунтов";
            toolTip1.SetToolTip(buttonImportAccounts, "Выбрать файл");
            buttonImportAccounts.UseVisualStyleBackColor = true;
            buttonImportAccounts.Click += buttonImportAccounts_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Dock = DockStyle.Fill;
            buttonAddAccount.Image = LitPulse.Properties.Resources.AddIcon;
            buttonAddAccount.Location = new Point(238, 3);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(40, 41);
            buttonAddAccount.TabIndex = 5;
            toolTip1.SetToolTip(buttonAddAccount, "Добавить новую строку в список");
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5098038F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2352943F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2549F));
            tableLayoutPanel7.Controls.Add(tabControl2, 1, 0);
            tableLayoutPanel7.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(5, 434);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1572, 214);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(388, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(595, 208);
            tabControl2.TabIndex = 13;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(flowLayoutPanel1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(587, 175);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Настройки запуска";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBoxReadBook);
            flowLayoutPanel1.Controls.Add(checkBoxLikeTheBook);
            flowLayoutPanel1.Controls.Add(checkBoxAddToLibrary);
            flowLayoutPanel1.Controls.Add(checkBoxSubscribeToTheAuthor);
            flowLayoutPanel1.Controls.Add(checkBoxPostComment);
            flowLayoutPanel1.Controls.Add(checkBoxMakeADonationToTheAuthor);
            flowLayoutPanel1.Controls.Add(checkBoxBuyABook);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(581, 169);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // checkBoxReadBook
            // 
            checkBoxReadBook.AutoSize = true;
            checkBoxReadBook.Location = new Point(3, 3);
            checkBoxReadBook.Name = "checkBoxReadBook";
            checkBoxReadBook.Size = new Size(120, 24);
            checkBoxReadBook.TabIndex = 6;
            checkBoxReadBook.Text = "Читать книгу";
            checkBoxReadBook.UseVisualStyleBackColor = true;
            checkBoxReadBook.CheckedChanged += checkBoxReadBook_CheckedChanged;
            // 
            // checkBoxLikeTheBook
            // 
            checkBoxLikeTheBook.AutoSize = true;
            checkBoxLikeTheBook.Location = new Point(3, 33);
            checkBoxLikeTheBook.Name = "checkBoxLikeTheBook";
            checkBoxLikeTheBook.Size = new Size(182, 24);
            checkBoxLikeTheBook.TabIndex = 1;
            checkBoxLikeTheBook.Text = "Поставить лайк книге";
            checkBoxLikeTheBook.UseVisualStyleBackColor = true;
            checkBoxLikeTheBook.CheckedChanged += checkBoxLikeTheBook_CheckedChanged;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new Point(3, 63);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new Size(195, 24);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
            checkBoxAddToLibrary.CheckedChanged += checkBoxAddToLibrary_CheckedChanged;
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new Point(3, 93);
            checkBoxSubscribeToTheAuthor.Name = "checkBoxSubscribeToTheAuthor";
            checkBoxSubscribeToTheAuthor.Size = new Size(194, 24);
            checkBoxSubscribeToTheAuthor.TabIndex = 2;
            checkBoxSubscribeToTheAuthor.Text = "Подписаться на автора";
            checkBoxSubscribeToTheAuthor.UseVisualStyleBackColor = true;
            checkBoxSubscribeToTheAuthor.CheckedChanged += checkBoxSubscribeToTheAuthor_CheckedChanged;
            // 
            // checkBoxPostComment
            // 
            checkBoxPostComment.AutoSize = true;
            checkBoxPostComment.Enabled = false;
            checkBoxPostComment.Location = new Point(3, 123);
            checkBoxPostComment.Name = "checkBoxPostComment";
            checkBoxPostComment.Size = new Size(194, 24);
            checkBoxPostComment.TabIndex = 3;
            checkBoxPostComment.Text = "Оставить комментарий";
            checkBoxPostComment.UseVisualStyleBackColor = true;
            checkBoxPostComment.CheckedChanged += checkBoxPostComment_CheckedChanged;
            // 
            // checkBoxMakeADonationToTheAuthor
            // 
            checkBoxMakeADonationToTheAuthor.AutoSize = true;
            checkBoxMakeADonationToTheAuthor.Enabled = false;
            checkBoxMakeADonationToTheAuthor.Location = new Point(204, 3);
            checkBoxMakeADonationToTheAuthor.Name = "checkBoxMakeADonationToTheAuthor";
            checkBoxMakeADonationToTheAuthor.Size = new Size(183, 24);
            checkBoxMakeADonationToTheAuthor.TabIndex = 4;
            checkBoxMakeADonationToTheAuthor.Text = "Сделать Донат автору";
            checkBoxMakeADonationToTheAuthor.UseVisualStyleBackColor = true;
            checkBoxMakeADonationToTheAuthor.CheckedChanged += checkBoxMakeADonationToTheAuthor_CheckedChanged;
            // 
            // checkBoxBuyABook
            // 
            checkBoxBuyABook.AutoSize = true;
            checkBoxBuyABook.Enabled = false;
            checkBoxBuyABook.Location = new Point(204, 33);
            checkBoxBuyABook.Name = "checkBoxBuyABook";
            checkBoxBuyABook.Size = new Size(200, 24);
            checkBoxBuyABook.TabIndex = 5;
            checkBoxBuyABook.Text = "Купить книгу из читалки";
            checkBoxBuyABook.UseVisualStyleBackColor = true;
            checkBoxBuyABook.CheckedChanged += checkBoxBuyABook_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel11);
            groupBox2.Location = new Point(204, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 93);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Таймаут запуска сеансов";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel11.Controls.Add(label7, 0, 0);
            tableLayoutPanel11.Controls.Add(label8, 0, 1);
            tableLayoutPanel11.Controls.Add(numericUpDownConstantDelay, 1, 0);
            tableLayoutPanel11.Controls.Add(numericUpDownFloatingIncrementalDelay, 1, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 23);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(371, 67);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(205, 20);
            label7.TabIndex = 0;
            label7.Text = "Постоянная задержка (сек.):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 30);
            label8.Name = "label8";
            label8.Size = new Size(292, 20);
            label8.TabIndex = 1;
            label8.Text = "Плавающая добавочная задержка (сек.):";
            // 
            // numericUpDownConstantDelay
            // 
            numericUpDownConstantDelay.Location = new Point(304, 3);
            numericUpDownConstantDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownConstantDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownConstantDelay.Name = "numericUpDownConstantDelay";
            numericUpDownConstantDelay.Size = new Size(64, 27);
            numericUpDownConstantDelay.TabIndex = 2;
            numericUpDownConstantDelay.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownConstantDelay.ValueChanged += numericUpDownConstantDelay_ValueChanged;
            // 
            // numericUpDownFloatingIncrementalDelay
            // 
            numericUpDownFloatingIncrementalDelay.Location = new Point(304, 33);
            numericUpDownFloatingIncrementalDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Name = "numericUpDownFloatingIncrementalDelay";
            numericUpDownFloatingIncrementalDelay.Size = new Size(64, 27);
            numericUpDownFloatingIncrementalDelay.TabIndex = 3;
            numericUpDownFloatingIncrementalDelay.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.ValueChanged += numericUpDownFloatingIncrementalDelay_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxProfile);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxReadProfiles);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 208);
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
            richTextBoxProfile.Location = new Point(3, 91);
            richTextBoxProfile.Name = "richTextBoxProfile";
            richTextBoxProfile.Size = new Size(373, 114);
            richTextBoxProfile.TabIndex = 9;
            richTextBoxProfile.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 71);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 8;
            label4.Text = "Описание профиля:";
            // 
            // comboBoxReadProfiles
            // 
            comboBoxReadProfiles.Dock = DockStyle.Top;
            comboBoxReadProfiles.FormattingEnabled = true;
            comboBoxReadProfiles.Items.AddRange(new object[] { "Быстрое чтение", "Глубокое чтение", "Уставшее чтение" });
            comboBoxReadProfiles.Location = new Point(3, 43);
            comboBoxReadProfiles.Name = "comboBoxReadProfiles";
            comboBoxReadProfiles.Size = new Size(373, 28);
            comboBoxReadProfiles.TabIndex = 7;
            comboBoxReadProfiles.SelectedIndexChanged += comboBoxReadProfiles_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 23);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 6;
            label6.Text = "Профили чтения";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(richTextBoxLog, 0, 1);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel12, 0, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(989, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel8.Size = new Size(580, 208);
            tableLayoutPanel8.TabIndex = 12;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(3, 23);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(574, 129);
            richTextBoxLog.TabIndex = 2;
            richTextBoxLog.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(574, 20);
            label5.TabIndex = 1;
            label5.Text = "Лог";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel12.Controls.Add(buttonAccountGenerator, 2, 0);
            tableLayoutPanel12.Controls.Add(button_instruction, 1, 0);
            tableLayoutPanel12.Controls.Add(buttonUploadLogs, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 158);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(574, 47);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // buttonAccountGenerator
            // 
            buttonAccountGenerator.Dock = DockStyle.Fill;
            buttonAccountGenerator.Enabled = false;
            buttonAccountGenerator.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAccountGenerator.Image = LitPulse.Properties.Resources.AccountGeneratorIcon;
            buttonAccountGenerator.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccountGenerator.Location = new Point(369, 3);
            buttonAccountGenerator.Name = "buttonAccountGenerator";
            buttonAccountGenerator.Size = new Size(202, 41);
            buttonAccountGenerator.TabIndex = 16;
            buttonAccountGenerator.Text = "Генератор аккаунтов";
            buttonAccountGenerator.UseVisualStyleBackColor = true;
            buttonAccountGenerator.Click += buttonAccountGenerator_Click;
            // 
            // button_instruction
            // 
            button_instruction.Dock = DockStyle.Fill;
            button_instruction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_instruction.Image = LitPulse.Properties.Resources.InstructionIcon;
            button_instruction.ImageAlign = ContentAlignment.MiddleLeft;
            button_instruction.Location = new Point(186, 3);
            button_instruction.Name = "button_instruction";
            button_instruction.Size = new Size(177, 41);
            button_instruction.TabIndex = 15;
            button_instruction.Text = "Инструкция";
            button_instruction.UseVisualStyleBackColor = true;
            button_instruction.Click += button_instruction_Click;
            // 
            // buttonUploadLogs
            // 
            buttonUploadLogs.Dock = DockStyle.Fill;
            buttonUploadLogs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUploadLogs.Image = LitPulse.Properties.Resources.DownLoadIcon;
            buttonUploadLogs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUploadLogs.Location = new Point(3, 3);
            buttonUploadLogs.Name = "buttonUploadLogs";
            buttonUploadLogs.Size = new Size(177, 41);
            buttonUploadLogs.TabIndex = 9;
            buttonUploadLogs.Text = "Выгрузить логи";
            toolTip1.SetToolTip(buttonUploadLogs, "Выгрузить лог");
            buttonUploadLogs.UseVisualStyleBackColor = true;
            buttonUploadLogs.Click += buttonUploadLogs_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 653);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1600, 700);
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
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinks).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstantDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloatingIncrementalDelay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
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
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel12;
        private Button buttonAccountGenerator;
        private Button button_instruction;
        private Button buttonUploadLogs;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxReadBook;
        private CheckBox checkBoxLikeTheBook;
        private CheckBox checkBoxAddToLibrary;
        private CheckBox checkBoxSubscribeToTheAuthor;
        private CheckBox checkBoxPostComment;
        private CheckBox checkBoxMakeADonationToTheAuthor;
        private CheckBox checkBoxBuyABook;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDownConstantDelay;
        private NumericUpDown numericUpDownFloatingIncrementalDelay;
        private CheckBox checkBoxRunningInMultithreadingMode;
    }
}