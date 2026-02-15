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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSaveReport = new Button();
            dataGridViewReport = new DataGridView();
            SessionId = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            UserIpAddress = new DataGridViewTextBoxColumn();
            Operation = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            SheetsCount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            SessionDateTime = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            checkBoxRunningInMultithreadingMode = new CheckBox();
            buttonStop = new Button();
            buttonStartSession = new Button();
            checkBoxBatchLaunch = new CheckBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            dataGridViewLinks = new DataGridView();
            Link = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            buttonClearLinks = new Button();
            buttonDeleteLink = new Button();
            buttonAddLink = new Button();
            buttonImportLinks = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            numericUpDownConstantDelay = new NumericUpDown();
            numericUpDownFloatingIncrementalDelay = new NumericUpDown();
            label9 = new Label();
            numericUpDownAccountCount = new NumericUpDown();
            groupBoxProxys = new GroupBox();
            label1 = new Label();
            buttonClearProxysList = new Button();
            buttonLoadProxysList = new Button();
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
            richTextBox1 = new RichTextBox();
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
            groupBoxProxys.SuspendLayout();
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
            tableLayoutPanel1.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Size = new Size(1582, 853);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 7);
            tableLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1572, 537);
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
            tableLayoutPanel4.Location = new Point(789, 5);
            tableLayoutPanel4.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel4.Size = new Size(780, 527);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Dock = DockStyle.Fill;
            buttonSaveReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveReport.Image = Properties.Resources.DownLoadIcon;
            buttonSaveReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveReport.Location = new Point(3, 437);
            buttonSaveReport.Margin = new Padding(3, 5, 3, 5);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(774, 85);
            buttonSaveReport.TabIndex = 7;
            buttonSaveReport.Text = "Скачать отчет";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += buttonSaveReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToOrderColumns = true;
            dataGridViewReport.BackgroundColor = SystemColors.Control;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] { SessionId, User, UserIpAddress, Operation, Book, SheetsCount, Status, SessionDateTime });
            dataGridViewReport.Dock = DockStyle.Fill;
            dataGridViewReport.Location = new Point(3, 206);
            dataGridViewReport.Margin = new Padding(3, 5, 3, 5);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(774, 221);
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
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 165);
            label3.Name = "label3";
            label3.Size = new Size(774, 36);
            label3.TabIndex = 3;
            label3.Text = "Отчет";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.33333F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel5.Controls.Add(checkBoxRunningInMultithreadingMode, 0, 1);
            tableLayoutPanel5.Controls.Add(buttonStop, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxBatchLaunch, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 5);
            tableLayoutPanel5.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel5.Size = new Size(774, 155);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // checkBoxRunningInMultithreadingMode
            // 
            checkBoxRunningInMultithreadingMode.AutoSize = true;
            checkBoxRunningInMultithreadingMode.Location = new Point(3, 100);
            checkBoxRunningInMultithreadingMode.Margin = new Padding(3, 5, 3, 5);
            checkBoxRunningInMultithreadingMode.Name = "checkBoxRunningInMultithreadingMode";
            checkBoxRunningInMultithreadingMode.Size = new Size(300, 24);
            checkBoxRunningInMultithreadingMode.TabIndex = 8;
            checkBoxRunningInMultithreadingMode.Text = "Запускать в режиме многопоточности";
            toolTip1.SetToolTip(checkBoxRunningInMultithreadingMode, "При включенном параметре программа начинает работать в режиме многопоточности, \r\nгде каждый аккаунт - это отдельное окно браузера. (!!!Требует больших ресурсов компьютера!!!)");
            checkBoxRunningInMultithreadingMode.UseVisualStyleBackColor = true;
            checkBoxRunningInMultithreadingMode.CheckedChanged += checkBoxRunningInMultithreadingMode_CheckedChanged;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Red;
            buttonStop.Dock = DockStyle.Fill;
            buttonStop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStop.ForeColor = SystemColors.ControlText;
            buttonStop.Image = Properties.Resources.StopIcon;
            buttonStop.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStop.Location = new Point(454, 5);
            buttonStop.Margin = new Padding(3, 5, 3, 5);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(317, 85);
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
            buttonStartSession.Image = Properties.Resources.StartIcon;
            buttonStartSession.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStartSession.Location = new Point(3, 5);
            buttonStartSession.Margin = new Padding(3, 5, 3, 5);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(445, 85);
            buttonStartSession.TabIndex = 6;
            buttonStartSession.Text = "ЗАПУСК СЕАНСА";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // checkBoxBatchLaunch
            // 
            checkBoxBatchLaunch.Enabled = false;
            checkBoxBatchLaunch.Location = new Point(454, 100);
            checkBoxBatchLaunch.Margin = new Padding(3, 5, 3, 5);
            checkBoxBatchLaunch.Name = "checkBoxBatchLaunch";
            checkBoxBatchLaunch.Size = new Size(272, 43);
            checkBoxBatchLaunch.TabIndex = 9;
            checkBoxBatchLaunch.Text = "Порционный режим";
            checkBoxBatchLaunch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(dataGridViewLinks, 0, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 5);
            tableLayoutPanel6.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel6.Size = new Size(780, 527);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridViewLinks
            // 
            dataGridViewLinks.AllowUserToOrderColumns = true;
            dataGridViewLinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLinks.Columns.AddRange(new DataGridViewColumn[] { Link });
            dataGridViewLinks.Dock = DockStyle.Fill;
            dataGridViewLinks.Location = new Point(3, 41);
            dataGridViewLinks.Margin = new Padding(3, 5, 3, 5);
            dataGridViewLinks.Name = "dataGridViewLinks";
            dataGridViewLinks.RowHeadersWidth = 51;
            dataGridViewLinks.Size = new Size(774, 386);
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
            label2.Size = new Size(71, 23);
            label2.TabIndex = 2;
            label2.Text = "Ссылки";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel10.Controls.Add(buttonClearLinks, 3, 0);
            tableLayoutPanel10.Controls.Add(buttonDeleteLink, 2, 0);
            tableLayoutPanel10.Controls.Add(buttonAddLink, 1, 0);
            tableLayoutPanel10.Controls.Add(buttonImportLinks, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 437);
            tableLayoutPanel10.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(774, 85);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // buttonClearLinks
            // 
            buttonClearLinks.BackColor = Color.Red;
            buttonClearLinks.Dock = DockStyle.Fill;
            buttonClearLinks.Image = Properties.Resources.ClearIcon_White;
            buttonClearLinks.Location = new Point(716, 5);
            buttonClearLinks.Margin = new Padding(3, 5, 3, 5);
            buttonClearLinks.Name = "buttonClearLinks";
            buttonClearLinks.Size = new Size(55, 75);
            buttonClearLinks.TabIndex = 8;
            toolTip1.SetToolTip(buttonClearLinks, "Очистить список ссылок");
            buttonClearLinks.UseVisualStyleBackColor = false;
            buttonClearLinks.Click += buttonClearLinks_Click;
            // 
            // buttonDeleteLink
            // 
            buttonDeleteLink.Dock = DockStyle.Fill;
            buttonDeleteLink.Image = Properties.Resources.RemoveIcon_Full;
            buttonDeleteLink.Location = new Point(655, 5);
            buttonDeleteLink.Margin = new Padding(3, 5, 3, 5);
            buttonDeleteLink.Name = "buttonDeleteLink";
            buttonDeleteLink.Size = new Size(55, 75);
            buttonDeleteLink.TabIndex = 7;
            toolTip1.SetToolTip(buttonDeleteLink, "Удалить ссылку из списка");
            buttonDeleteLink.UseVisualStyleBackColor = true;
            buttonDeleteLink.Click += buttonDeleteLink_Click;
            // 
            // buttonAddLink
            // 
            buttonAddLink.Dock = DockStyle.Fill;
            buttonAddLink.Image = Properties.Resources.AddIcon;
            buttonAddLink.Location = new Point(594, 5);
            buttonAddLink.Margin = new Padding(3, 5, 3, 5);
            buttonAddLink.Name = "buttonAddLink";
            buttonAddLink.Size = new Size(55, 75);
            buttonAddLink.TabIndex = 6;
            toolTip1.SetToolTip(buttonAddLink, "Добавить новую строку в список");
            buttonAddLink.UseVisualStyleBackColor = true;
            buttonAddLink.Click += buttonAddLink_Click;
            // 
            // buttonImportLinks
            // 
            buttonImportLinks.Dock = DockStyle.Fill;
            buttonImportLinks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportLinks.Image = Properties.Resources.uploadIcon;
            buttonImportLinks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportLinks.Location = new Point(3, 5);
            buttonImportLinks.Margin = new Padding(3, 5, 3, 5);
            buttonImportLinks.Name = "buttonImportLinks";
            buttonImportLinks.Size = new Size(585, 75);
            buttonImportLinks.TabIndex = 5;
            buttonImportLinks.Text = "Импорт ссылок";
            toolTip1.SetToolTip(buttonImportLinks, "Выбрать файл");
            buttonImportLinks.UseVisualStyleBackColor = true;
            buttonImportLinks.Click += buttonImportLinks_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(5, 556);
            tableLayoutPanel7.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1572, 290);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(3, 5);
            tabControl2.Margin = new Padding(3, 5, 3, 5);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(780, 280);
            tabControl2.TabIndex = 13;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(flowLayoutPanel1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 5, 3, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 5, 3, 5);
            tabPage4.Size = new Size(772, 247);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Настройки запуска";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBoxProxys);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 5);
            flowLayoutPanel1.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(766, 237);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel11);
            groupBox2.Location = new Point(3, 5);
            groupBox2.Margin = new Padding(3, 5, 3, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 5, 3, 5);
            groupBox2.Size = new Size(430, 190);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Таймаут запуска сеансов";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel11.Controls.Add(label7, 0, 0);
            tableLayoutPanel11.Controls.Add(label8, 0, 1);
            tableLayoutPanel11.Controls.Add(numericUpDownConstantDelay, 1, 0);
            tableLayoutPanel11.Controls.Add(numericUpDownFloatingIncrementalDelay, 1, 1);
            tableLayoutPanel11.Controls.Add(label9, 0, 2);
            tableLayoutPanel11.Controls.Add(numericUpDownAccountCount, 1, 2);
            tableLayoutPanel11.Location = new Point(3, 32);
            tableLayoutPanel11.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel11.Size = new Size(408, 150);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(302, 50);
            label7.TabIndex = 0;
            label7.Text = "Постоянная задержка (сек.):";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 50);
            label8.Name = "label8";
            label8.Size = new Size(302, 49);
            label8.TabIndex = 1;
            label8.Text = "Плавающая добавочная задержка (сек.):";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownConstantDelay
            // 
            numericUpDownConstantDelay.Location = new Point(311, 5);
            numericUpDownConstantDelay.Margin = new Padding(3, 5, 3, 5);
            numericUpDownConstantDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownConstantDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownConstantDelay.Name = "numericUpDownConstantDelay";
            numericUpDownConstantDelay.Size = new Size(83, 27);
            numericUpDownConstantDelay.TabIndex = 2;
            numericUpDownConstantDelay.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownConstantDelay.ValueChanged += numericUpDownConstantDelay_ValueChanged;
            // 
            // numericUpDownFloatingIncrementalDelay
            // 
            numericUpDownFloatingIncrementalDelay.Location = new Point(311, 55);
            numericUpDownFloatingIncrementalDelay.Margin = new Padding(3, 5, 3, 5);
            numericUpDownFloatingIncrementalDelay.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.Name = "numericUpDownFloatingIncrementalDelay";
            numericUpDownFloatingIncrementalDelay.Size = new Size(83, 27);
            numericUpDownFloatingIncrementalDelay.TabIndex = 3;
            numericUpDownFloatingIncrementalDelay.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFloatingIncrementalDelay.ValueChanged += numericUpDownFloatingIncrementalDelay_ValueChanged;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 99);
            label9.Name = "label9";
            label9.Size = new Size(302, 51);
            label9.TabIndex = 4;
            label9.Text = "Кол-во аккаунтов:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownAccountCount
            // 
            numericUpDownAccountCount.Location = new Point(311, 104);
            numericUpDownAccountCount.Margin = new Padding(3, 5, 3, 5);
            numericUpDownAccountCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownAccountCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownAccountCount.Name = "numericUpDownAccountCount";
            numericUpDownAccountCount.Size = new Size(83, 27);
            numericUpDownAccountCount.TabIndex = 5;
            numericUpDownAccountCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // groupBoxProxys
            // 
            groupBoxProxys.Controls.Add(richTextBox1);
            groupBoxProxys.Controls.Add(label1);
            groupBoxProxys.Controls.Add(buttonClearProxysList);
            groupBoxProxys.Controls.Add(buttonLoadProxysList);
            groupBoxProxys.Location = new Point(439, 3);
            groupBoxProxys.Name = "groupBoxProxys";
            groupBoxProxys.Size = new Size(324, 231);
            groupBoxProxys.TabIndex = 1;
            groupBoxProxys.TabStop = false;
            groupBoxProxys.Text = "Прокси";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 98);
            label1.Name = "label1";
            label1.Size = new Size(286, 20);
            label1.TabIndex = 2;
            label1.Text = "Формат прокси: host:port:login:password";
            // 
            // buttonClearProxysList
            // 
            buttonClearProxysList.Location = new Point(6, 61);
            buttonClearProxysList.Name = "buttonClearProxysList";
            buttonClearProxysList.Size = new Size(225, 29);
            buttonClearProxysList.TabIndex = 1;
            buttonClearProxysList.Text = "Очистить список прокси";
            buttonClearProxysList.UseVisualStyleBackColor = true;
            buttonClearProxysList.Click += buttonClearProxysList_Click;
            // 
            // buttonLoadProxysList
            // 
            buttonLoadProxysList.Location = new Point(6, 26);
            buttonLoadProxysList.Name = "buttonLoadProxysList";
            buttonLoadProxysList.Size = new Size(225, 29);
            buttonLoadProxysList.TabIndex = 0;
            buttonLoadProxysList.Text = "Загрузить список прокси";
            buttonLoadProxysList.UseVisualStyleBackColor = true;
            buttonLoadProxysList.Click += buttonLoadProxysList_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(richTextBoxLog, 0, 1);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel12, 0, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(789, 5);
            tableLayoutPanel8.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel8.Size = new Size(780, 280);
            tableLayoutPanel8.TabIndex = 12;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(3, 41);
            richTextBoxLog.Margin = new Padding(3, 5, 3, 5);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(774, 139);
            richTextBoxLog.TabIndex = 2;
            richTextBoxLog.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(774, 20);
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
            tableLayoutPanel12.Location = new Point(3, 190);
            tableLayoutPanel12.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(774, 85);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // buttonAccountGenerator
            // 
            buttonAccountGenerator.Dock = DockStyle.Fill;
            buttonAccountGenerator.Enabled = false;
            buttonAccountGenerator.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAccountGenerator.Image = Properties.Resources.AccountGeneratorIcon;
            buttonAccountGenerator.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccountGenerator.Location = new Point(497, 5);
            buttonAccountGenerator.Margin = new Padding(3, 5, 3, 5);
            buttonAccountGenerator.Name = "buttonAccountGenerator";
            buttonAccountGenerator.Size = new Size(274, 75);
            buttonAccountGenerator.TabIndex = 16;
            buttonAccountGenerator.Text = "Генератор аккаунтов";
            buttonAccountGenerator.UseVisualStyleBackColor = true;
            buttonAccountGenerator.Click += buttonAccountGenerator_Click;
            // 
            // button_instruction
            // 
            button_instruction.Dock = DockStyle.Fill;
            button_instruction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_instruction.Image = Properties.Resources.InstructionIcon;
            button_instruction.ImageAlign = ContentAlignment.MiddleLeft;
            button_instruction.Location = new Point(250, 5);
            button_instruction.Margin = new Padding(3, 5, 3, 5);
            button_instruction.Name = "button_instruction";
            button_instruction.Size = new Size(241, 75);
            button_instruction.TabIndex = 15;
            button_instruction.Text = "Инструкция";
            button_instruction.UseVisualStyleBackColor = true;
            button_instruction.Click += button_instruction_Click;
            // 
            // buttonUploadLogs
            // 
            buttonUploadLogs.Dock = DockStyle.Fill;
            buttonUploadLogs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUploadLogs.Image = Properties.Resources.DownLoadIcon;
            buttonUploadLogs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUploadLogs.Location = new Point(3, 5);
            buttonUploadLogs.Margin = new Padding(3, 5, 3, 5);
            buttonUploadLogs.Name = "buttonUploadLogs";
            buttonUploadLogs.Size = new Size(241, 75);
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
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.Location = new Point(11, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 90);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Важно!!! В открытых ботом окнах браузера НЕ открывать замеры скорости интернета!!! При замере израсходуется весь трафик прокси!!!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1600, 900);
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
            groupBoxProxys.ResumeLayout(false);
            groupBoxProxys.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBoxBatchLaunch;

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
        private System.Windows.Forms.CheckBox checkBoxRunningInMultithreadingMode;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDownConstantDelay;
        private NumericUpDown numericUpDownFloatingIncrementalDelay;
        private Label label9;
        private NumericUpDown numericUpDownAccountCount;
        private GroupBox groupBoxProxys;
        private Label label1;
        private Button buttonClearProxysList;
        private Button buttonLoadProxysList;
        private RichTextBox richTextBox1;
    }
}