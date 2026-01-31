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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            buttonImportAccounts = new System.Windows.Forms.Button();
            buttonAddAccount = new System.Windows.Forms.Button();
            buttonRemoveAccount = new System.Windows.Forms.Button();
            tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            checkBoxReadBook = new System.Windows.Forms.CheckBox();
            checkBoxBuyABook = new System.Windows.Forms.CheckBox();
            checkBoxMakeADonationToTheAuthor = new System.Windows.Forms.CheckBox();
            checkBoxPostComment = new System.Windows.Forms.CheckBox();
            checkBoxSubscribeToTheAuthor = new System.Windows.Forms.CheckBox();
            checkBoxAddToLibrary = new System.Windows.Forms.CheckBox();
            checkBoxLikeTheBook = new System.Windows.Forms.CheckBox();
            numericOrderReadBook = new System.Windows.Forms.NumericUpDown();
            numericOrderLikeBook = new System.Windows.Forms.NumericUpDown();
            numericOrderAddToLibrary = new System.Windows.Forms.NumericUpDown();
            numericOrderPostComment = new System.Windows.Forms.NumericUpDown();
            numericOrderDonateAuthor = new System.Windows.Forms.NumericUpDown();
            numericOrderSubscribeToTheAuthor = new System.Windows.Forms.NumericUpDown();
            numericOrderBuyABook = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewActiveAccounts = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewInactiveAccounts = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            buttonMoveInactiveAccount = new System.Windows.Forms.Button();
            buttonMoveActiveAccount = new System.Windows.Forms.Button();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            buttonSaveSetupSettings = new System.Windows.Forms.Button();
            buttonStartSession = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            tableLayoutPanel1.Size = new System.Drawing.Size(984, 721);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanelSettings);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 560);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(978, 157);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonImportAccounts);
            flowLayoutPanel2.Controls.Add(buttonAddAccount);
            flowLayoutPanel2.Controls.Add(buttonRemoveAccount);
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(636, 50);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonImportAccounts
            // 
            buttonImportAccounts.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonImportAccounts.Image = global::LitPulse.Properties.Resources.uploadIcon;
            buttonImportAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonImportAccounts.Location = new System.Drawing.Point(3, 3);
            buttonImportAccounts.Name = "buttonImportAccounts";
            buttonImportAccounts.Size = new System.Drawing.Size(234, 44);
            buttonImportAccounts.TabIndex = 0;
            buttonImportAccounts.Text = "Импорт аккаунтов";
            buttonImportAccounts.UseVisualStyleBackColor = true;
            buttonImportAccounts.Click += buttonImportAccounts_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Image = global::LitPulse.Properties.Resources.AddIcon;
            buttonAddAccount.Location = new System.Drawing.Point(243, 3);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new System.Drawing.Size(58, 44);
            buttonAddAccount.TabIndex = 1;
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // buttonRemoveAccount
            // 
            buttonRemoveAccount.Image = global::LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonRemoveAccount.Location = new System.Drawing.Point(307, 3);
            buttonRemoveAccount.Name = "buttonRemoveAccount";
            buttonRemoveAccount.Size = new System.Drawing.Size(56, 44);
            buttonRemoveAccount.TabIndex = 2;
            buttonRemoveAccount.UseVisualStyleBackColor = true;
            buttonRemoveAccount.Click += buttonRemoveAccount_Click;
            // 
            // tableLayoutPanelSettings
            // 
            tableLayoutPanelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            tableLayoutPanelSettings.ColumnCount = 6;
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
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
            tableLayoutPanelSettings.Location = new System.Drawing.Point(3, 59);
            tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            tableLayoutPanelSettings.RowCount = 3;
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanelSettings.Size = new System.Drawing.Size(639, 94);
            tableLayoutPanelSettings.TabIndex = 7;
            // 
            // checkBoxReadBook
            // 
            checkBoxReadBook.AutoSize = true;
            checkBoxReadBook.Location = new System.Drawing.Point(3, 4);
            checkBoxReadBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxReadBook.Name = "checkBoxReadBook";
            checkBoxReadBook.Size = new System.Drawing.Size(97, 19);
            checkBoxReadBook.TabIndex = 6;
            checkBoxReadBook.Text = "Читать книгу";
            checkBoxReadBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuyABook
            // 
            checkBoxBuyABook.AutoSize = true;
            checkBoxBuyABook.Enabled = false;
            checkBoxBuyABook.Location = new System.Drawing.Point(422, 4);
            checkBoxBuyABook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxBuyABook.Name = "checkBoxBuyABook";
            checkBoxBuyABook.Size = new System.Drawing.Size(161, 19);
            checkBoxBuyABook.TabIndex = 5;
            checkBoxBuyABook.Text = "Купить книгу из читалки";
            checkBoxBuyABook.UseVisualStyleBackColor = true;
            // 
            // checkBoxMakeADonationToTheAuthor
            // 
            checkBoxMakeADonationToTheAuthor.AutoSize = true;
            checkBoxMakeADonationToTheAuthor.Enabled = false;
            checkBoxMakeADonationToTheAuthor.Location = new System.Drawing.Point(208, 66);
            checkBoxMakeADonationToTheAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxMakeADonationToTheAuthor.Name = "checkBoxMakeADonationToTheAuthor";
            checkBoxMakeADonationToTheAuthor.Size = new System.Drawing.Size(146, 19);
            checkBoxMakeADonationToTheAuthor.TabIndex = 4;
            checkBoxMakeADonationToTheAuthor.Text = "Сделать Донат автору";
            checkBoxMakeADonationToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostComment
            // 
            checkBoxPostComment.AutoSize = true;
            checkBoxPostComment.Enabled = false;
            checkBoxPostComment.Location = new System.Drawing.Point(208, 35);
            checkBoxPostComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxPostComment.Name = "checkBoxPostComment";
            checkBoxPostComment.Size = new System.Drawing.Size(155, 19);
            checkBoxPostComment.TabIndex = 3;
            checkBoxPostComment.Text = "Оставить комментарий";
            checkBoxPostComment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new System.Drawing.Point(208, 4);
            checkBoxSubscribeToTheAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxSubscribeToTheAuthor.Name = "checkBoxSubscribeToTheAuthor";
            checkBoxSubscribeToTheAuthor.Size = new System.Drawing.Size(153, 19);
            checkBoxSubscribeToTheAuthor.TabIndex = 2;
            checkBoxSubscribeToTheAuthor.Text = "Подписаться на автора";
            checkBoxSubscribeToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new System.Drawing.Point(3, 66);
            checkBoxAddToLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new System.Drawing.Size(155, 19);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLikeTheBook
            // 
            checkBoxLikeTheBook.AutoSize = true;
            checkBoxLikeTheBook.Location = new System.Drawing.Point(3, 35);
            checkBoxLikeTheBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxLikeTheBook.Name = "checkBoxLikeTheBook";
            checkBoxLikeTheBook.Size = new System.Drawing.Size(146, 19);
            checkBoxLikeTheBook.TabIndex = 1;
            checkBoxLikeTheBook.Text = "Поставить лайк книге";
            checkBoxLikeTheBook.UseVisualStyleBackColor = true;
            // 
            // numericOrderReadBook
            // 
            numericOrderReadBook.Location = new System.Drawing.Point(167, 3);
            numericOrderReadBook.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numericOrderReadBook.Name = "numericOrderReadBook";
            numericOrderReadBook.Size = new System.Drawing.Size(35, 23);
            numericOrderReadBook.TabIndex = 7;
            // 
            // numericOrderLikeBook
            // 
            numericOrderLikeBook.Location = new System.Drawing.Point(167, 34);
            numericOrderLikeBook.Name = "numericOrderLikeBook";
            numericOrderLikeBook.Size = new System.Drawing.Size(35, 23);
            numericOrderLikeBook.TabIndex = 8;
            // 
            // numericOrderAddToLibrary
            // 
            numericOrderAddToLibrary.Location = new System.Drawing.Point(167, 65);
            numericOrderAddToLibrary.Name = "numericOrderAddToLibrary";
            numericOrderAddToLibrary.Size = new System.Drawing.Size(35, 23);
            numericOrderAddToLibrary.TabIndex = 9;
            // 
            // numericOrderPostComment
            // 
            numericOrderPostComment.Location = new System.Drawing.Point(380, 34);
            numericOrderPostComment.Name = "numericOrderPostComment";
            numericOrderPostComment.Size = new System.Drawing.Size(36, 23);
            numericOrderPostComment.TabIndex = 11;
            // 
            // numericOrderDonateAuthor
            // 
            numericOrderDonateAuthor.Location = new System.Drawing.Point(380, 65);
            numericOrderDonateAuthor.Name = "numericOrderDonateAuthor";
            numericOrderDonateAuthor.Size = new System.Drawing.Size(36, 23);
            numericOrderDonateAuthor.TabIndex = 12;
            // 
            // numericOrderSubscribeToTheAuthor
            // 
            numericOrderSubscribeToTheAuthor.Location = new System.Drawing.Point(380, 3);
            numericOrderSubscribeToTheAuthor.Name = "numericOrderSubscribeToTheAuthor";
            numericOrderSubscribeToTheAuthor.Size = new System.Drawing.Size(36, 23);
            numericOrderSubscribeToTheAuthor.TabIndex = 13;
            // 
            // numericOrderBuyABook
            // 
            numericOrderBuyABook.Location = new System.Drawing.Point(595, 3);
            numericOrderBuyABook.Name = "numericOrderBuyABook";
            numericOrderBuyABook.Size = new System.Drawing.Size(41, 23);
            numericOrderBuyABook.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridViewActiveAccounts, 2, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewInactiveAccounts, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(978, 490);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewActiveAccounts
            // 
            dataGridViewActiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewActiveAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewActiveAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewActiveAccounts.Location = new System.Drawing.Point(517, 4);
            dataGridViewActiveAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewActiveAccounts.MultiSelect = false;
            dataGridViewActiveAccounts.Name = "dataGridViewActiveAccounts";
            dataGridViewActiveAccounts.RowHeadersWidth = 51;
            dataGridViewActiveAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveAccounts.Size = new System.Drawing.Size(458, 482);
            dataGridViewActiveAccounts.TabIndex = 3;
            dataGridViewActiveAccounts.RowLeave += dataGridViewActiveAccounts_RowLeave;
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
            // dataGridViewInactiveAccounts
            // 
            dataGridViewInactiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewInactiveAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInactiveAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Login, Password });
            dataGridViewInactiveAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewInactiveAccounts.Location = new System.Drawing.Point(3, 4);
            dataGridViewInactiveAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewInactiveAccounts.MultiSelect = false;
            dataGridViewInactiveAccounts.Name = "dataGridViewInactiveAccounts";
            dataGridViewInactiveAccounts.RowHeadersWidth = 51;
            dataGridViewInactiveAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInactiveAccounts.Size = new System.Drawing.Size(458, 482);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(buttonMoveInactiveAccount, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonMoveActiveAccount, 0, 3);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(467, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(44, 484);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonMoveInactiveAccount
            // 
            buttonMoveInactiveAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonMoveInactiveAccount.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonMoveInactiveAccount.Location = new System.Drawing.Point(3, 200);
            buttonMoveInactiveAccount.Name = "buttonMoveInactiveAccount";
            buttonMoveInactiveAccount.Size = new System.Drawing.Size(38, 34);
            buttonMoveInactiveAccount.TabIndex = 0;
            buttonMoveInactiveAccount.Text = ">";
            buttonMoveInactiveAccount.UseVisualStyleBackColor = true;
            buttonMoveInactiveAccount.Click += buttonMoveInactiveAccount_Click;
            // 
            // buttonMoveActiveAccount
            // 
            buttonMoveActiveAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonMoveActiveAccount.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonMoveActiveAccount.Location = new System.Drawing.Point(3, 250);
            buttonMoveActiveAccount.Name = "buttonMoveActiveAccount";
            buttonMoveActiveAccount.Size = new System.Drawing.Size(38, 34);
            buttonMoveActiveAccount.TabIndex = 1;
            buttonMoveActiveAccount.Text = "<";
            buttonMoveActiveAccount.UseVisualStyleBackColor = true;
            buttonMoveActiveAccount.Click += buttonMoveActiveAccount_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveSetupSettings, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCancel, 2, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(978, 54);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonSaveSetupSettings
            // 
            buttonSaveSetupSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            buttonSaveSetupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSaveSetupSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonSaveSetupSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonSaveSetupSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveSetupSettings.Location = new System.Drawing.Point(203, 4);
            buttonSaveSetupSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSaveSetupSettings.Name = "buttonSaveSetupSettings";
            buttonSaveSetupSettings.Size = new System.Drawing.Size(294, 46);
            buttonSaveSetupSettings.TabIndex = 9;
            buttonSaveSetupSettings.Text = "СОХРАНИТЬ ИЗМЕНЕНИЯ";
            buttonSaveSetupSettings.UseVisualStyleBackColor = false;
            buttonSaveSetupSettings.Click += buttonSaveSetupSettings_Click;
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
            buttonStartSession.Size = new System.Drawing.Size(194, 46);
            buttonStartSession.TabIndex = 7;
            buttonStartSession.Text = "ЗАПУСК СЕАНСА";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCancel.Location = new System.Drawing.Point(503, 4);
            buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(194, 46);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "ОТМЕНА";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AccountSetupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 721);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(1000, 600);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

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
    }
}