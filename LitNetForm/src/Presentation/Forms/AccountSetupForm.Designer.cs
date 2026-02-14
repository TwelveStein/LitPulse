namespace LitPulse.Forms
{
    partial class AccountSetupForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonImportAccounts = new Button();
            buttonAddAccount = new Button();
            buttonRemoveAccount = new Button();
            tableLayoutPanelSettings = new TableLayoutPanel();
            checkBoxReadBook = new CheckBox();
            checkBoxBuyABook = new CheckBox();
            checkBoxMakeADonationToTheAuthor = new CheckBox();
            checkBoxPostComment = new CheckBox();
            checkBoxSubscribeToTheAuthor = new CheckBox();
            checkBoxAddToLibrary = new CheckBox();
            checkBoxLikeTheBook = new CheckBox();
            numericOrderReadBook = new NumericUpDown();
            numericOrderLikeBook = new NumericUpDown();
            numericOrderAddToLibrary = new NumericUpDown();
            numericOrderPostComment = new NumericUpDown();
            numericOrderDonateAuthor = new NumericUpDown();
            numericOrderSubscribeToTheAuthor = new NumericUpDown();
            numericOrderBuyABook = new NumericUpDown();
            comboBoxReadProfile = new ComboBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonMoveInactiveAccount = new Button();
            buttonMoveActiveAccount = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelAllAccounts = new Label();
            dataGridViewInactiveAccounts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            dataGridViewActiveAccounts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSaveSetupSettings = new Button();
            buttonStartSession = new Button();
            buttonCancel = new Button();
            openFileDialog = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericOrderReadBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderLikeBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderAddToLibrary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderPostComment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderDonateAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderSubscribeToTheAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderBuyABook).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Size = new Size(1282, 853);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanelSettings);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 640);
            flowLayoutPanel1.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1276, 206);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonImportAccounts);
            flowLayoutPanel2.Controls.Add(buttonAddAccount);
            flowLayoutPanel2.Controls.Add(buttonRemoveAccount);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 5);
            flowLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1265, 65);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonImportAccounts
            // 
            buttonImportAccounts.Dock = DockStyle.Top;
            buttonImportAccounts.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportAccounts.Image = Properties.Resources.uploadIcon;
            buttonImportAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportAccounts.Location = new Point(10, 5);
            buttonImportAccounts.Margin = new Padding(10, 5, 5, 5);
            buttonImportAccounts.Name = "buttonImportAccounts";
            buttonImportAccounts.Size = new Size(300, 55);
            buttonImportAccounts.TabIndex = 0;
            buttonImportAccounts.Text = "Импорт аккаунтов";
            buttonImportAccounts.UseVisualStyleBackColor = true;
            buttonImportAccounts.Click += buttonImportAccounts_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Image = Properties.Resources.AddIcon;
            buttonAddAccount.Location = new Point(318, 5);
            buttonAddAccount.Margin = new Padding(3, 5, 3, 5);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(55, 55);
            buttonAddAccount.TabIndex = 1;
            toolTip1.SetToolTip(buttonAddAccount, "Добавить новый аккаунт (Аккаунт сразу добавляется в \"Выбранные аккаунты\")");
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // buttonRemoveAccount
            // 
            buttonRemoveAccount.Image = Properties.Resources.RemoveIcon_Full;
            buttonRemoveAccount.Location = new Point(379, 5);
            buttonRemoveAccount.Margin = new Padding(3, 5, 3, 5);
            buttonRemoveAccount.Name = "buttonRemoveAccount";
            buttonRemoveAccount.Size = new Size(55, 55);
            buttonRemoveAccount.TabIndex = 2;
            toolTip1.SetToolTip(buttonRemoveAccount, "Удалить аккаунт из БД (из таблицы \"Все аккаунты\")");
            buttonRemoveAccount.UseVisualStyleBackColor = true;
            buttonRemoveAccount.Click += buttonRemoveAccount_Click;
            // 
            // tableLayoutPanelSettings
            // 
            tableLayoutPanelSettings.ColumnCount = 6;
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 431F));
            tableLayoutPanelSettings.Controls.Add(checkBoxReadBook, 0, 0);
            tableLayoutPanelSettings.Controls.Add(checkBoxBuyABook, 4, 0);
            tableLayoutPanelSettings.Controls.Add(checkBoxMakeADonationToTheAuthor, 2, 2);
            tableLayoutPanelSettings.Controls.Add(checkBoxPostComment, 2, 1);
            tableLayoutPanelSettings.Controls.Add(checkBoxSubscribeToTheAuthor, 2, 0);
            tableLayoutPanelSettings.Controls.Add(checkBoxAddToLibrary, 0, 2);
            tableLayoutPanelSettings.Controls.Add(checkBoxLikeTheBook, 0, 1);
            tableLayoutPanelSettings.Controls.Add(numericOrderReadBook, 1, 0);
            tableLayoutPanelSettings.Controls.Add(numericOrderLikeBook, 1, 1);
            tableLayoutPanelSettings.Controls.Add(numericOrderAddToLibrary, 1, 2);
            tableLayoutPanelSettings.Controls.Add(numericOrderPostComment, 3, 1);
            tableLayoutPanelSettings.Controls.Add(numericOrderDonateAuthor, 3, 2);
            tableLayoutPanelSettings.Controls.Add(numericOrderSubscribeToTheAuthor, 3, 0);
            tableLayoutPanelSettings.Controls.Add(numericOrderBuyABook, 5, 0);
            tableLayoutPanelSettings.Controls.Add(comboBoxReadProfile, 5, 1);
            tableLayoutPanelSettings.Controls.Add(label2, 4, 1);
            tableLayoutPanelSettings.Location = new Point(3, 80);
            tableLayoutPanelSettings.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            tableLayoutPanelSettings.RowCount = 3;
            tableLayoutPanelSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelSettings.Size = new Size(1265, 120);
            tableLayoutPanelSettings.TabIndex = 7;
            // 
            // checkBoxReadBook
            // 
            checkBoxReadBook.AutoSize = true;
            checkBoxReadBook.Location = new Point(3, 7);
            checkBoxReadBook.Margin = new Padding(3, 7, 3, 7);
            checkBoxReadBook.Name = "checkBoxReadBook";
            checkBoxReadBook.Size = new Size(120, 24);
            checkBoxReadBook.TabIndex = 6;
            checkBoxReadBook.Text = "Читать книгу";
            checkBoxReadBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuyABook
            // 
            checkBoxBuyABook.AutoSize = true;
            checkBoxBuyABook.Enabled = false;
            checkBoxBuyABook.Location = new Point(597, 7);
            checkBoxBuyABook.Margin = new Padding(3, 7, 3, 7);
            checkBoxBuyABook.Name = "checkBoxBuyABook";
            checkBoxBuyABook.Size = new Size(200, 24);
            checkBoxBuyABook.TabIndex = 5;
            checkBoxBuyABook.Text = "Купить книгу из читалки";
            checkBoxBuyABook.UseVisualStyleBackColor = true;
            // 
            // checkBoxMakeADonationToTheAuthor
            // 
            checkBoxMakeADonationToTheAuthor.AutoSize = true;
            checkBoxMakeADonationToTheAuthor.Enabled = false;
            checkBoxMakeADonationToTheAuthor.Location = new Point(300, 87);
            checkBoxMakeADonationToTheAuthor.Margin = new Padding(3, 7, 3, 7);
            checkBoxMakeADonationToTheAuthor.Name = "checkBoxMakeADonationToTheAuthor";
            checkBoxMakeADonationToTheAuthor.Size = new Size(183, 24);
            checkBoxMakeADonationToTheAuthor.TabIndex = 4;
            checkBoxMakeADonationToTheAuthor.Text = "Сделать Донат автору";
            checkBoxMakeADonationToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostComment
            // 
            checkBoxPostComment.AutoSize = true;
            checkBoxPostComment.Enabled = false;
            checkBoxPostComment.Location = new Point(300, 47);
            checkBoxPostComment.Margin = new Padding(3, 7, 3, 7);
            checkBoxPostComment.Name = "checkBoxPostComment";
            checkBoxPostComment.Size = new Size(194, 24);
            checkBoxPostComment.TabIndex = 3;
            checkBoxPostComment.Text = "Оставить комментарий";
            checkBoxPostComment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new Point(300, 7);
            checkBoxSubscribeToTheAuthor.Margin = new Padding(3, 7, 3, 7);
            checkBoxSubscribeToTheAuthor.Name = "checkBoxSubscribeToTheAuthor";
            checkBoxSubscribeToTheAuthor.Size = new Size(194, 24);
            checkBoxSubscribeToTheAuthor.TabIndex = 2;
            checkBoxSubscribeToTheAuthor.Text = "Подписаться на автора";
            checkBoxSubscribeToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new Point(3, 87);
            checkBoxAddToLibrary.Margin = new Padding(3, 7, 3, 7);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new Size(195, 24);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLikeTheBook
            // 
            checkBoxLikeTheBook.AutoSize = true;
            checkBoxLikeTheBook.Location = new Point(3, 47);
            checkBoxLikeTheBook.Margin = new Padding(3, 7, 3, 7);
            checkBoxLikeTheBook.Name = "checkBoxLikeTheBook";
            checkBoxLikeTheBook.Size = new Size(182, 24);
            checkBoxLikeTheBook.TabIndex = 1;
            checkBoxLikeTheBook.Text = "Поставить лайк книге";
            checkBoxLikeTheBook.UseVisualStyleBackColor = true;
            // 
            // numericOrderReadBook
            // 
            numericOrderReadBook.Location = new Point(243, 5);
            numericOrderReadBook.Margin = new Padding(3, 5, 3, 5);
            numericOrderReadBook.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numericOrderReadBook.Name = "numericOrderReadBook";
            numericOrderReadBook.Size = new Size(46, 27);
            numericOrderReadBook.TabIndex = 7;
            // 
            // numericOrderLikeBook
            // 
            numericOrderLikeBook.Location = new Point(243, 45);
            numericOrderLikeBook.Margin = new Padding(3, 5, 3, 5);
            numericOrderLikeBook.Name = "numericOrderLikeBook";
            numericOrderLikeBook.Size = new Size(46, 27);
            numericOrderLikeBook.TabIndex = 8;
            // 
            // numericOrderAddToLibrary
            // 
            numericOrderAddToLibrary.Location = new Point(243, 85);
            numericOrderAddToLibrary.Margin = new Padding(3, 5, 3, 5);
            numericOrderAddToLibrary.Name = "numericOrderAddToLibrary";
            numericOrderAddToLibrary.Size = new Size(46, 27);
            numericOrderAddToLibrary.TabIndex = 9;
            // 
            // numericOrderPostComment
            // 
            numericOrderPostComment.Location = new Point(540, 45);
            numericOrderPostComment.Margin = new Padding(3, 5, 3, 5);
            numericOrderPostComment.Name = "numericOrderPostComment";
            numericOrderPostComment.Size = new Size(47, 27);
            numericOrderPostComment.TabIndex = 11;
            // 
            // numericOrderDonateAuthor
            // 
            numericOrderDonateAuthor.Location = new Point(540, 85);
            numericOrderDonateAuthor.Margin = new Padding(3, 5, 3, 5);
            numericOrderDonateAuthor.Name = "numericOrderDonateAuthor";
            numericOrderDonateAuthor.Size = new Size(47, 27);
            numericOrderDonateAuthor.TabIndex = 12;
            // 
            // numericOrderSubscribeToTheAuthor
            // 
            numericOrderSubscribeToTheAuthor.Location = new Point(540, 5);
            numericOrderSubscribeToTheAuthor.Margin = new Padding(3, 5, 3, 5);
            numericOrderSubscribeToTheAuthor.Name = "numericOrderSubscribeToTheAuthor";
            numericOrderSubscribeToTheAuthor.Size = new Size(47, 27);
            numericOrderSubscribeToTheAuthor.TabIndex = 13;
            // 
            // numericOrderBuyABook
            // 
            numericOrderBuyABook.Location = new Point(837, 5);
            numericOrderBuyABook.Margin = new Padding(3, 5, 3, 5);
            numericOrderBuyABook.Name = "numericOrderBuyABook";
            numericOrderBuyABook.Size = new Size(54, 27);
            numericOrderBuyABook.TabIndex = 14;
            // 
            // comboBoxReadProfile
            // 
            comboBoxReadProfile.Anchor = AnchorStyles.Left;
            comboBoxReadProfile.FormattingEnabled = true;
            comboBoxReadProfile.Items.AddRange(new object[] { "Глубокое чтение", "Быстрое чтение", "Уставшее чтение" });
            comboBoxReadProfile.Location = new Point(837, 46);
            comboBoxReadProfile.Margin = new Padding(3, 4, 3, 4);
            comboBoxReadProfile.Name = "comboBoxReadProfile";
            comboBoxReadProfile.Size = new Size(229, 28);
            comboBoxReadProfile.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Location = new Point(597, 42);
            label2.Name = "label2";
            label2.Size = new Size(137, 36);
            label2.TabIndex = 16;
            label2.Text = "Режим чтения:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 85);
            tableLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1276, 543);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.Controls.Add(buttonMoveInactiveAccount, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonMoveActiveAccount, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(608, 5);
            tableLayoutPanel3.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(59, 533);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonMoveInactiveAccount
            // 
            buttonMoveInactiveAccount.Dock = DockStyle.Fill;
            buttonMoveInactiveAccount.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMoveInactiveAccount.Location = new Point(3, 192);
            buttonMoveInactiveAccount.Margin = new Padding(3, 5, 3, 5);
            buttonMoveInactiveAccount.Name = "buttonMoveInactiveAccount";
            buttonMoveInactiveAccount.Size = new Size(53, 61);
            buttonMoveInactiveAccount.TabIndex = 0;
            buttonMoveInactiveAccount.Text = ">";
            buttonMoveInactiveAccount.UseVisualStyleBackColor = true;
            buttonMoveInactiveAccount.Click += buttonMoveInactiveAccount_Click;
            // 
            // buttonMoveActiveAccount
            // 
            buttonMoveActiveAccount.Dock = DockStyle.Fill;
            buttonMoveActiveAccount.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMoveActiveAccount.Location = new Point(3, 280);
            buttonMoveActiveAccount.Margin = new Padding(3, 5, 3, 5);
            buttonMoveActiveAccount.Name = "buttonMoveActiveAccount";
            buttonMoveActiveAccount.Size = new Size(53, 61);
            buttonMoveActiveAccount.TabIndex = 1;
            buttonMoveActiveAccount.Text = "<";
            buttonMoveActiveAccount.UseVisualStyleBackColor = true;
            buttonMoveActiveAccount.Click += buttonMoveActiveAccount_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(labelAllAccounts, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridViewInactiveAccounts, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 4);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(599, 535);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // labelAllAccounts
            // 
            labelAllAccounts.AutoSize = true;
            labelAllAccounts.Dock = DockStyle.Fill;
            labelAllAccounts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelAllAccounts.Location = new Point(3, 0);
            labelAllAccounts.Name = "labelAllAccounts";
            labelAllAccounts.Size = new Size(593, 40);
            labelAllAccounts.TabIndex = 0;
            labelAllAccounts.Text = "Все аккаунты";
            labelAllAccounts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewInactiveAccounts
            // 
            dataGridViewInactiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewInactiveAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInactiveAccounts.Columns.AddRange(new DataGridViewColumn[] { Id, Login, Password });
            dataGridViewInactiveAccounts.Dock = DockStyle.Fill;
            dataGridViewInactiveAccounts.Location = new Point(3, 47);
            dataGridViewInactiveAccounts.Margin = new Padding(3, 7, 3, 7);
            dataGridViewInactiveAccounts.MultiSelect = false;
            dataGridViewInactiveAccounts.Name = "dataGridViewInactiveAccounts";
            dataGridViewInactiveAccounts.RowHeadersWidth = 51;
            dataGridViewInactiveAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInactiveAccounts.Size = new Size(593, 481);
            dataGridViewInactiveAccounts.TabIndex = 2;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 70;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Логин";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.Width = 250;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 350;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(dataGridViewActiveAccounts, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(673, 4);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(600, 535);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(594, 40);
            label1.TabIndex = 1;
            label1.Text = "Выбранные аккаунты";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewActiveAccounts
            // 
            dataGridViewActiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewActiveAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveAccounts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewActiveAccounts.Dock = DockStyle.Fill;
            dataGridViewActiveAccounts.Location = new Point(3, 47);
            dataGridViewActiveAccounts.Margin = new Padding(3, 7, 3, 7);
            dataGridViewActiveAccounts.MultiSelect = false;
            dataGridViewActiveAccounts.Name = "dataGridViewActiveAccounts";
            dataGridViewActiveAccounts.RowHeadersWidth = 51;
            dataGridViewActiveAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveAccounts.Size = new Size(594, 481);
            dataGridViewActiveAccounts.TabIndex = 3;
            dataGridViewActiveAccounts.RowEnter += dataGridViewActiveAccounts_RowLeave;
            dataGridViewActiveAccounts.SelectionChanged += dataGridViewActiveAccounts_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            dataGridViewTextBoxColumn2.HeaderText = "Логин";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 350;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveSetupSettings, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCancel, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 5);
            tableLayoutPanel4.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1276, 70);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonSaveSetupSettings
            // 
            buttonSaveSetupSettings.BackColor = SystemColors.ButtonFace;
            buttonSaveSetupSettings.Dock = DockStyle.Fill;
            buttonSaveSetupSettings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveSetupSettings.ForeColor = SystemColors.ControlText;
            buttonSaveSetupSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveSetupSettings.Location = new Point(265, 7);
            buttonSaveSetupSettings.Margin = new Padding(3, 7, 3, 7);
            buttonSaveSetupSettings.Name = "buttonSaveSetupSettings";
            buttonSaveSetupSettings.Size = new Size(386, 56);
            buttonSaveSetupSettings.TabIndex = 9;
            buttonSaveSetupSettings.Text = "СОХРАНИТЬ ИЗМЕНЕНИЯ";
            buttonSaveSetupSettings.UseVisualStyleBackColor = false;
            buttonSaveSetupSettings.Click += buttonSaveSetupSettings_Click;
            // 
            // buttonStartSession
            // 
            buttonStartSession.BackColor = Color.YellowGreen;
            buttonStartSession.Dock = DockStyle.Fill;
            buttonStartSession.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStartSession.ForeColor = SystemColors.ControlText;
            buttonStartSession.Image = Properties.Resources.StartIcon;
            buttonStartSession.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStartSession.Location = new Point(3, 7);
            buttonStartSession.Margin = new Padding(3, 7, 3, 7);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(256, 56);
            buttonStartSession.TabIndex = 7;
            buttonStartSession.Text = "ЗАПУСК СЕАНСА";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ButtonFace;
            buttonCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(657, 7);
            buttonCancel.Margin = new Padding(3, 7, 3, 7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(254, 56);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "ОТМЕНА";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AccountSetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1300, 900);
            Name = "AccountSetupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Параметры учетных записей";
            Load += AccountSetupForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanelSettings.ResumeLayout(false);
            tableLayoutPanelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericOrderReadBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderLikeBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderAddToLibrary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderPostComment).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderDonateAuthor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderSubscribeToTheAuthor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOrderBuyABook).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxReadProfile;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Button buttonRemoveAccount;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.Button buttonImportAccounts;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

        private System.Windows.Forms.NumericUpDown numericOrderReadBook;
        private System.Windows.Forms.NumericUpDown numericOrderLikeBook;
        private System.Windows.Forms.NumericUpDown numericOrderAddToLibrary;
        private System.Windows.Forms.NumericUpDown numericOrderSubscribeToTheAuthor;
        private System.Windows.Forms.NumericUpDown numericOrderPostComment;
        private System.Windows.Forms.NumericUpDown numericOrderDonateAuthor;
        private System.Windows.Forms.NumericUpDown numericOrderBuyABook;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonMoveInactiveAccount;
        private System.Windows.Forms.Button buttonMoveActiveAccount;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonStartSession;
        private System.Windows.Forms.Button buttonSaveSetupSettings;
        private Button buttonCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxReadBook;
        private System.Windows.Forms.CheckBox checkBoxLikeTheBook;
        private System.Windows.Forms.CheckBox checkBoxAddToLibrary;
        private System.Windows.Forms.CheckBox checkBoxSubscribeToTheAuthor;
        private System.Windows.Forms.CheckBox checkBoxPostComment;
        private System.Windows.Forms.CheckBox checkBoxMakeADonationToTheAuthor;
        private System.Windows.Forms.CheckBox checkBoxBuyABook;
        private System.Windows.Forms.DataGridView dataGridViewInactiveAccounts;
        private System.Windows.Forms.DataGridView dataGridViewActiveAccounts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelAllAccounts;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private ToolTip toolTip1;
    }
}