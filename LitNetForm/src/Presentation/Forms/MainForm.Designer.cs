namespace LitPulse.Forms
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            buttonSaveReport = new System.Windows.Forms.Button();
            dataGridViewReport = new System.Windows.Forms.DataGridView();
            SessionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SheetsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SessionDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            checkBoxRunningInMultithreadingMode = new System.Windows.Forms.CheckBox();
            buttonStop = new System.Windows.Forms.Button();
            buttonStartSession = new System.Windows.Forms.Button();
            checkBoxBatchLaunch = new System.Windows.Forms.CheckBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewLinks = new System.Windows.Forms.DataGridView();
            Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            buttonClearLinks = new System.Windows.Forms.Button();
            buttonDeleteLink = new System.Windows.Forms.Button();
            buttonAddLink = new System.Windows.Forms.Button();
            buttonImportLinks = new System.Windows.Forms.Button();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage4 = new System.Windows.Forms.TabPage();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            numericUpDownConstantDelay = new System.Windows.Forms.NumericUpDown();
            numericUpDownFloatingIncrementalDelay = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            numericUpDownAccountCount = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            richTextBoxLog = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            buttonAccountGenerator = new System.Windows.Forms.Button();
            button_instruction = new System.Windows.Forms.Button();
            buttonUploadLogs = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLinks).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstantDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloatingIncrementalDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccountCount).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1810, 881);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.44444445F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.27778F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2549F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(5, 6);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1800, 574);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveReport, 0, 3);
            tableLayoutPanel4.Controls.Add(dataGridViewReport, 0, 2);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(1132, 4);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            tableLayoutPanel4.Size = new System.Drawing.Size(665, 566);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSaveReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonSaveReport.Image = global::LitPulse.Properties.Resources.DownLoadIcon;
            buttonSaveReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveReport.Location = new System.Drawing.Point(3, 499);
            buttonSaveReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new System.Drawing.Size(659, 63);
            buttonSaveReport.TabIndex = 7;
            buttonSaveReport.Text = "Скачать отчет";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += buttonSaveReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToOrderColumns = true;
            dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SessionId, User, UserIpAddress, Operation, Book, SheetsCount, Status, SessionDateTime });
            dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewReport.Location = new System.Drawing.Point(3, 155);
            dataGridViewReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new System.Drawing.Size(659, 336);
            dataGridViewReport.TabIndex = 6;
            // 
            // SessionId
            // 
            SessionId.DataPropertyName = "SessionId";
            SessionId.HeaderText = "ID сессии";
            SessionId.MinimumWidth = 6;
            SessionId.Name = "SessionId";
            SessionId.ReadOnly = true;
            SessionId.Width = 125;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "Пользователь";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 125;
            // 
            // UserIpAddress
            // 
            UserIpAddress.DataPropertyName = "IpAddress";
            UserIpAddress.HeaderText = "IP Адрес";
            UserIpAddress.MinimumWidth = 6;
            UserIpAddress.Name = "UserIpAddress";
            UserIpAddress.ReadOnly = true;
            UserIpAddress.Width = 125;
            // 
            // Operation
            // 
            Operation.DataPropertyName = "Operation";
            Operation.HeaderText = "Операция";
            Operation.MinimumWidth = 6;
            Operation.Name = "Operation";
            Operation.ReadOnly = true;
            Operation.Width = 125;
            // 
            // Book
            // 
            Book.DataPropertyName = "Book";
            Book.HeaderText = "Книга";
            Book.MinimumWidth = 6;
            Book.Name = "Book";
            Book.ReadOnly = true;
            Book.Width = 125;
            // 
            // SheetsCount
            // 
            SheetsCount.DataPropertyName = "SheetsCount";
            SheetsCount.HeaderText = "Кол-во страниц";
            SheetsCount.MinimumWidth = 6;
            SheetsCount.Name = "SheetsCount";
            SheetsCount.ReadOnly = true;
            SheetsCount.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // SessionDateTime
            // 
            SessionDateTime.DataPropertyName = "SessionDateTime";
            SessionDateTime.HeaderText = "Время";
            SessionDateTime.MinimumWidth = 6;
            SessionDateTime.Name = "SessionDateTime";
            SessionDateTime.ReadOnly = true;
            SessionDateTime.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label3.Location = new System.Drawing.Point(3, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(659, 27);
            label3.TabIndex = 3;
            label3.Text = "Отчет";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.666668F));
            tableLayoutPanel5.Controls.Add(checkBoxRunningInMultithreadingMode, 0, 1);
            tableLayoutPanel5.Controls.Add(buttonStop, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxBatchLaunch, 1, 1);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 4);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel5.Size = new System.Drawing.Size(659, 116);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // checkBoxRunningInMultithreadingMode
            // 
            checkBoxRunningInMultithreadingMode.AutoSize = true;
            checkBoxRunningInMultithreadingMode.Location = new System.Drawing.Point(3, 75);
            checkBoxRunningInMultithreadingMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxRunningInMultithreadingMode.Name = "checkBoxRunningInMultithreadingMode";
            checkBoxRunningInMultithreadingMode.Size = new System.Drawing.Size(240, 19);
            checkBoxRunningInMultithreadingMode.TabIndex = 8;
            checkBoxRunningInMultithreadingMode.Text = "Запускать в режиме многопоточности";
            toolTip1.SetToolTip(checkBoxRunningInMultithreadingMode, ("При включенном параметре программа начинает работать в режиме многопоточности, \r\n" + "где каждый аккаунт - это отдельное окно браузера. (!!!Требует больших ресурсов к" + "омпьютера!!!)"));
            checkBoxRunningInMultithreadingMode.UseVisualStyleBackColor = true;
            checkBoxRunningInMultithreadingMode.CheckedChanged += checkBoxRunningInMultithreadingMode_CheckedChanged;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = System.Drawing.Color.Red;
            buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonStop.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonStop.Image = global::LitPulse.Properties.Resources.StopIcon;
            buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonStop.Location = new System.Drawing.Point(387, 4);
            buttonStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(269, 63);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "СТОП";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStartSession
            // 
            buttonStartSession.BackColor = System.Drawing.Color.YellowGreen;
            buttonStartSession.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonStartSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonStartSession.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonStartSession.Image = global::LitPulse.Properties.Resources.StartIcon;
            buttonStartSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonStartSession.Location = new System.Drawing.Point(3, 4);
            buttonStartSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new System.Drawing.Size(378, 63);
            buttonStartSession.TabIndex = 6;
            buttonStartSession.Text = "ЗАПУСК СЕАНСА";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // checkBoxBatchLaunch
            // 
            checkBoxBatchLaunch.Enabled = false;
            checkBoxBatchLaunch.Location = new System.Drawing.Point(387, 75);
            checkBoxBatchLaunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxBatchLaunch.Name = "checkBoxBatchLaunch";
            checkBoxBatchLaunch.Size = new System.Drawing.Size(238, 32);
            checkBoxBatchLaunch.TabIndex = 9;
            checkBoxBatchLaunch.Text = "Порционный режим";
            checkBoxBatchLaunch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(dataGridViewLinks, 0, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(11, 4);
            tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            tableLayoutPanel6.Size = new System.Drawing.Size(1115, 566);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridViewLinks
            // 
            dataGridViewLinks.AllowUserToOrderColumns = true;
            dataGridViewLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Link });
            dataGridViewLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewLinks.Location = new System.Drawing.Point(3, 31);
            dataGridViewLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewLinks.Name = "dataGridViewLinks";
            dataGridViewLinks.RowHeadersWidth = 51;
            dataGridViewLinks.Size = new System.Drawing.Size(1109, 460);
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
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Ссылки";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel10.Controls.Add(buttonClearLinks, 3, 0);
            tableLayoutPanel10.Controls.Add(buttonDeleteLink, 2, 0);
            tableLayoutPanel10.Controls.Add(buttonAddLink, 1, 0);
            tableLayoutPanel10.Controls.Add(buttonImportLinks, 0, 0);
            tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel10.Location = new System.Drawing.Point(3, 499);
            tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new System.Drawing.Size(1109, 63);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // buttonClearLinks
            // 
            buttonClearLinks.BackColor = System.Drawing.Color.Red;
            buttonClearLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonClearLinks.Image = global::LitPulse.Properties.Resources.ClearIcon_White;
            buttonClearLinks.Location = new System.Drawing.Point(1059, 4);
            buttonClearLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonClearLinks.Name = "buttonClearLinks";
            buttonClearLinks.Size = new System.Drawing.Size(47, 55);
            buttonClearLinks.TabIndex = 8;
            toolTip1.SetToolTip(buttonClearLinks, "Очистить список ссылок");
            buttonClearLinks.UseVisualStyleBackColor = false;
            buttonClearLinks.Click += buttonClearLinks_Click;
            // 
            // buttonDeleteLink
            // 
            buttonDeleteLink.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonDeleteLink.Image = global::LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonDeleteLink.Location = new System.Drawing.Point(1006, 4);
            buttonDeleteLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonDeleteLink.Name = "buttonDeleteLink";
            buttonDeleteLink.Size = new System.Drawing.Size(47, 55);
            buttonDeleteLink.TabIndex = 7;
            toolTip1.SetToolTip(buttonDeleteLink, "Удалить ссылку из списка");
            buttonDeleteLink.UseVisualStyleBackColor = true;
            buttonDeleteLink.Click += buttonDeleteLink_Click;
            // 
            // buttonAddLink
            // 
            buttonAddLink.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonAddLink.Image = global::LitPulse.Properties.Resources.AddIcon;
            buttonAddLink.Location = new System.Drawing.Point(953, 4);
            buttonAddLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAddLink.Name = "buttonAddLink";
            buttonAddLink.Size = new System.Drawing.Size(47, 55);
            buttonAddLink.TabIndex = 6;
            toolTip1.SetToolTip(buttonAddLink, "Добавить новую строку в список");
            buttonAddLink.UseVisualStyleBackColor = true;
            buttonAddLink.Click += buttonAddLink_Click;
            // 
            // buttonImportLinks
            // 
            buttonImportLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonImportLinks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonImportLinks.Image = global::LitPulse.Properties.Resources.uploadIcon;
            buttonImportLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonImportLinks.Location = new System.Drawing.Point(3, 4);
            buttonImportLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonImportLinks.Name = "buttonImportLinks";
            buttonImportLinks.Size = new System.Drawing.Size(944, 55);
            buttonImportLinks.TabIndex = 5;
            buttonImportLinks.Text = "Импорт ссылок";
            toolTip1.SetToolTip(buttonImportLinks, "Выбрать файл");
            buttonImportLinks.UseVisualStyleBackColor = true;
            buttonImportLinks.Click += buttonImportLinks_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.1111112F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.61111F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2549F));
            tableLayoutPanel7.Controls.Add(tabControl2, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 2, 0);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(5, 590);
            tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new System.Drawing.Size(1800, 285);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(23, 4);
            tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1103, 277);
            tabControl2.TabIndex = 13;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(flowLayoutPanel1);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage4.Size = new System.Drawing.Size(1095, 249);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Настройки запуска";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1089, 241);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel11);
            groupBox2.Location = new System.Drawing.Point(3, 4);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(431, 141);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Таймаут запуска сеансов";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel11.Controls.Add(label7, 0, 0);
            tableLayoutPanel11.Controls.Add(label8, 0, 1);
            tableLayoutPanel11.Controls.Add(numericUpDownConstantDelay, 1, 0);
            tableLayoutPanel11.Controls.Add(numericUpDownFloatingIncrementalDelay, 1, 1);
            tableLayoutPanel11.Controls.Add(label9, 0, 2);
            tableLayoutPanel11.Controls.Add(numericUpDownAccountCount, 1, 2);
            tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel11.Location = new System.Drawing.Point(3, 20);
            tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel11.Size = new System.Drawing.Size(425, 117);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(162, 15);
            label7.TabIndex = 0;
            label7.Text = "Постоянная задержка (сек.):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(3, 40);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(231, 15);
            label8.TabIndex = 1;
            label8.Text = "Плавающая добавочная задержка (сек.):";
            // 
            // numericUpDownConstantDelay
            // 
            numericUpDownConstantDelay.Location = new System.Drawing.Point(348, 4);
            numericUpDownConstantDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownConstantDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownConstantDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownConstantDelay.Name = "numericUpDownConstantDelay";
            numericUpDownConstantDelay.Size = new System.Drawing.Size(73, 23);
            numericUpDownConstantDelay.TabIndex = 2;
            numericUpDownConstantDelay.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownConstantDelay.ValueChanged += numericUpDownConstantDelay_ValueChanged;
            // 
            // numericUpDownFloatingIncrementalDelay
            // 
            numericUpDownFloatingIncrementalDelay.Location = new System.Drawing.Point(348, 44);
            numericUpDownFloatingIncrementalDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownFloatingIncrementalDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Name = "numericUpDownFloatingIncrementalDelay";
            numericUpDownFloatingIncrementalDelay.Size = new System.Drawing.Size(73, 23);
            numericUpDownFloatingIncrementalDelay.TabIndex = 3;
            numericUpDownFloatingIncrementalDelay.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.ValueChanged += numericUpDownFloatingIncrementalDelay_ValueChanged;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(3, 80);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(264, 31);
            label9.TabIndex = 4;
            label9.Text = "Кол-во аккаунтов:";
            // 
            // numericUpDownAccountCount
            // 
            numericUpDownAccountCount.Location = new System.Drawing.Point(348, 84);
            numericUpDownAccountCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownAccountCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownAccountCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownAccountCount.Name = "numericUpDownAccountCount";
            numericUpDownAccountCount.Size = new System.Drawing.Size(73, 23);
            numericUpDownAccountCount.TabIndex = 5;
            numericUpDownAccountCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(richTextBoxLog, 0, 1);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel12, 0, 2);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel8.Location = new System.Drawing.Point(1132, 4);
            tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            tableLayoutPanel8.Size = new System.Drawing.Size(665, 277);
            tableLayoutPanel8.TabIndex = 12;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxLog.Location = new System.Drawing.Point(3, 31);
            richTextBoxLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new System.Drawing.Size(659, 171);
            richTextBoxLog.TabIndex = 2;
            richTextBoxLog.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(659, 15);
            label5.TabIndex = 1;
            label5.Text = "Лог";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            tableLayoutPanel12.Controls.Add(buttonAccountGenerator, 2, 0);
            tableLayoutPanel12.Controls.Add(button_instruction, 1, 0);
            tableLayoutPanel12.Controls.Add(buttonUploadLogs, 0, 0);
            tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel12.Location = new System.Drawing.Point(3, 210);
            tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new System.Drawing.Size(659, 63);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // buttonAccountGenerator
            // 
            buttonAccountGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonAccountGenerator.Enabled = false;
            buttonAccountGenerator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonAccountGenerator.Image = global::LitPulse.Properties.Resources.AccountGeneratorIcon;
            buttonAccountGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAccountGenerator.Location = new System.Drawing.Point(423, 4);
            buttonAccountGenerator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAccountGenerator.Name = "buttonAccountGenerator";
            buttonAccountGenerator.Size = new System.Drawing.Size(233, 55);
            buttonAccountGenerator.TabIndex = 16;
            buttonAccountGenerator.Text = "Генератор аккаунтов";
            buttonAccountGenerator.UseVisualStyleBackColor = true;
            buttonAccountGenerator.Click += buttonAccountGenerator_Click;
            // 
            // button_instruction
            // 
            button_instruction.Dock = System.Windows.Forms.DockStyle.Fill;
            button_instruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            button_instruction.Image = global::LitPulse.Properties.Resources.InstructionIcon;
            button_instruction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button_instruction.Location = new System.Drawing.Point(213, 4);
            button_instruction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_instruction.Name = "button_instruction";
            button_instruction.Size = new System.Drawing.Size(204, 55);
            button_instruction.TabIndex = 15;
            button_instruction.Text = "Инструкция";
            button_instruction.UseVisualStyleBackColor = true;
            button_instruction.Click += button_instruction_Click;
            // 
            // buttonUploadLogs
            // 
            buttonUploadLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonUploadLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonUploadLogs.Image = global::LitPulse.Properties.Resources.DownLoadIcon;
            buttonUploadLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonUploadLogs.Location = new System.Drawing.Point(3, 4);
            buttonUploadLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUploadLogs.Name = "buttonUploadLogs";
            buttonUploadLogs.Size = new System.Drawing.Size(204, 55);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1810, 881);
            Controls.Add(tableLayoutPanel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(1826, 918);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            tableLayoutPanel7.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstantDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloatingIncrementalDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccountCount).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBoxBatchLaunch;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownAccountCount;

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dataGridViewLinks;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Button buttonStartSession;
        private Button buttonStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button buttonDeleteLink;
        private System.Windows.Forms.Button buttonAddLink;
        private System.Windows.Forms.Button buttonImportLinks;
        private System.Windows.Forms.Button buttonClearLinks;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button buttonAccountGenerator;
        private System.Windows.Forms.Button button_instruction;
        private System.Windows.Forms.Button buttonUploadLogs;
        private System.Windows.Forms.TabControl tabControl2;
        private TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDownConstantDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownFloatingIncrementalDelay;
        private System.Windows.Forms.CheckBox checkBoxRunningInMultithreadingMode;
    }
}