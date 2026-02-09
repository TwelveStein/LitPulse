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
            comboBoxReadProfile = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            buttonMoveInactiveAccount = new System.Windows.Forms.Button();
            buttonMoveActiveAccount = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            labelAllAccounts = new System.Windows.Forms.Label();
            dataGridViewInactiveAccounts = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            dataGridViewActiveAccounts = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            buttonSaveSetupSettings = new System.Windows.Forms.Button();
            buttonStartSession = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
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
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1184, 961);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanelSettings);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 746);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1178, 210);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonImportAccounts);
            flowLayoutPanel2.Controls.Add(buttonAddAccount);
            flowLayoutPanel2.Controls.Add(buttonRemoveAccount);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(1107, 67);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonImportAccounts
            // 
            buttonImportAccounts.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonImportAccounts.Image = global::LitPulse.Properties.Resources.uploadIcon;
            buttonImportAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonImportAccounts.Location = new System.Drawing.Point(3, 4);
            buttonImportAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonImportAccounts.Name = "buttonImportAccounts";
            buttonImportAccounts.Size = new System.Drawing.Size(267, 59);
            buttonImportAccounts.TabIndex = 0;
            buttonImportAccounts.Text = "Импорт аккаунтов";
            buttonImportAccounts.UseVisualStyleBackColor = true;
            buttonImportAccounts.Click += buttonImportAccounts_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Image = global::LitPulse.Properties.Resources.AddIcon;
            buttonAddAccount.Location = new System.Drawing.Point(276, 4);
            buttonAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new System.Drawing.Size(66, 59);
            buttonAddAccount.TabIndex = 1;
            toolTip1.SetToolTip(buttonAddAccount, "Добавить новый аккаунт (Аккаунт сразу добавляется в \"Выбранные аккаунты\")");
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // buttonRemoveAccount
            // 
            buttonRemoveAccount.Image = global::LitPulse.Properties.Resources.RemoveIcon_Full;
            buttonRemoveAccount.Location = new System.Drawing.Point(348, 4);
            buttonRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonRemoveAccount.Name = "buttonRemoveAccount";
            buttonRemoveAccount.Size = new System.Drawing.Size(64, 59);
            buttonRemoveAccount.TabIndex = 2;
            toolTip1.SetToolTip(buttonRemoveAccount, "Удалить аккаунт из БД (из таблицы \"Все аккаунты\")");
            buttonRemoveAccount.UseVisualStyleBackColor = true;
            buttonRemoveAccount.Click += buttonRemoveAccount_Click;
            // 
            // tableLayoutPanelSettings
            // 
            tableLayoutPanelSettings.ColumnCount = 6;
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
            tableLayoutPanelSettings.Location = new System.Drawing.Point(3, 79);
            tableLayoutPanelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            tableLayoutPanelSettings.RowCount = 3;
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanelSettings.Size = new System.Drawing.Size(1107, 125);
            tableLayoutPanelSettings.TabIndex = 7;
            // 
            // checkBoxReadBook
            // 
            checkBoxReadBook.AutoSize = true;
            checkBoxReadBook.Location = new System.Drawing.Point(3, 5);
            checkBoxReadBook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            checkBoxBuyABook.Location = new System.Drawing.Point(523, 5);
            checkBoxBuyABook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            checkBoxMakeADonationToTheAuthor.Location = new System.Drawing.Point(263, 87);
            checkBoxMakeADonationToTheAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            checkBoxPostComment.Location = new System.Drawing.Point(263, 46);
            checkBoxPostComment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            checkBoxPostComment.Name = "checkBoxPostComment";
            checkBoxPostComment.Size = new System.Drawing.Size(155, 19);
            checkBoxPostComment.TabIndex = 3;
            checkBoxPostComment.Text = "Оставить комментарий";
            checkBoxPostComment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new System.Drawing.Point(263, 5);
            checkBoxSubscribeToTheAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            checkBoxSubscribeToTheAuthor.Name = "checkBoxSubscribeToTheAuthor";
            checkBoxSubscribeToTheAuthor.Size = new System.Drawing.Size(153, 19);
            checkBoxSubscribeToTheAuthor.TabIndex = 2;
            checkBoxSubscribeToTheAuthor.Text = "Подписаться на автора";
            checkBoxSubscribeToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new System.Drawing.Point(3, 87);
            checkBoxAddToLibrary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new System.Drawing.Size(155, 19);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLikeTheBook
            // 
            checkBoxLikeTheBook.AutoSize = true;
            checkBoxLikeTheBook.Location = new System.Drawing.Point(3, 46);
            checkBoxLikeTheBook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            checkBoxLikeTheBook.Name = "checkBoxLikeTheBook";
            checkBoxLikeTheBook.Size = new System.Drawing.Size(146, 19);
            checkBoxLikeTheBook.TabIndex = 1;
            checkBoxLikeTheBook.Text = "Поставить лайк книге";
            checkBoxLikeTheBook.UseVisualStyleBackColor = true;
            // 
            // numericOrderReadBook
            // 
            numericOrderReadBook.Location = new System.Drawing.Point(213, 4);
            numericOrderReadBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderReadBook.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numericOrderReadBook.Name = "numericOrderReadBook";
            numericOrderReadBook.Size = new System.Drawing.Size(40, 23);
            numericOrderReadBook.TabIndex = 7;
            // 
            // numericOrderLikeBook
            // 
            numericOrderLikeBook.Location = new System.Drawing.Point(213, 45);
            numericOrderLikeBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderLikeBook.Name = "numericOrderLikeBook";
            numericOrderLikeBook.Size = new System.Drawing.Size(40, 23);
            numericOrderLikeBook.TabIndex = 8;
            // 
            // numericOrderAddToLibrary
            // 
            numericOrderAddToLibrary.Location = new System.Drawing.Point(213, 86);
            numericOrderAddToLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderAddToLibrary.Name = "numericOrderAddToLibrary";
            numericOrderAddToLibrary.Size = new System.Drawing.Size(40, 23);
            numericOrderAddToLibrary.TabIndex = 9;
            // 
            // numericOrderPostComment
            // 
            numericOrderPostComment.Location = new System.Drawing.Point(473, 45);
            numericOrderPostComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderPostComment.Name = "numericOrderPostComment";
            numericOrderPostComment.Size = new System.Drawing.Size(41, 23);
            numericOrderPostComment.TabIndex = 11;
            // 
            // numericOrderDonateAuthor
            // 
            numericOrderDonateAuthor.Location = new System.Drawing.Point(473, 86);
            numericOrderDonateAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderDonateAuthor.Name = "numericOrderDonateAuthor";
            numericOrderDonateAuthor.Size = new System.Drawing.Size(41, 23);
            numericOrderDonateAuthor.TabIndex = 12;
            // 
            // numericOrderSubscribeToTheAuthor
            // 
            numericOrderSubscribeToTheAuthor.Location = new System.Drawing.Point(473, 4);
            numericOrderSubscribeToTheAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderSubscribeToTheAuthor.Name = "numericOrderSubscribeToTheAuthor";
            numericOrderSubscribeToTheAuthor.Size = new System.Drawing.Size(41, 23);
            numericOrderSubscribeToTheAuthor.TabIndex = 13;
            // 
            // numericOrderBuyABook
            // 
            numericOrderBuyABook.Location = new System.Drawing.Point(733, 4);
            numericOrderBuyABook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericOrderBuyABook.Name = "numericOrderBuyABook";
            numericOrderBuyABook.Size = new System.Drawing.Size(47, 23);
            numericOrderBuyABook.TabIndex = 14;
            // 
            // comboBoxReadProfile
            // 
            comboBoxReadProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comboBoxReadProfile.FormattingEnabled = true;
            comboBoxReadProfile.Items.AddRange(new object[] { "Глубокое чтение", "Быстрое чтение", "Уставшее чтение" });
            comboBoxReadProfile.Location = new System.Drawing.Point(733, 50);
            comboBoxReadProfile.Name = "comboBoxReadProfile";
            comboBoxReadProfile.Size = new System.Drawing.Size(201, 23);
            comboBoxReadProfile.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.Location = new System.Drawing.Point(523, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 27);
            label2.TabIndex = 16;
            label2.Text = "Режим чтения:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 84);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1178, 653);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(buttonMoveInactiveAccount, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonMoveActiveAccount, 0, 3);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(563, 4);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(51, 645);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonMoveInactiveAccount
            // 
            buttonMoveInactiveAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonMoveInactiveAccount.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonMoveInactiveAccount.Location = new System.Drawing.Point(3, 267);
            buttonMoveInactiveAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonMoveInactiveAccount.Name = "buttonMoveInactiveAccount";
            buttonMoveInactiveAccount.Size = new System.Drawing.Size(45, 45);
            buttonMoveInactiveAccount.TabIndex = 0;
            buttonMoveInactiveAccount.Text = ">";
            buttonMoveInactiveAccount.UseVisualStyleBackColor = true;
            buttonMoveInactiveAccount.Click += buttonMoveInactiveAccount_Click;
            // 
            // buttonMoveActiveAccount
            // 
            buttonMoveActiveAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonMoveActiveAccount.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonMoveActiveAccount.Location = new System.Drawing.Point(3, 333);
            buttonMoveActiveAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonMoveActiveAccount.Name = "buttonMoveActiveAccount";
            buttonMoveActiveAccount.Size = new System.Drawing.Size(45, 45);
            buttonMoveActiveAccount.TabIndex = 1;
            buttonMoveActiveAccount.Text = "<";
            buttonMoveActiveAccount.UseVisualStyleBackColor = true;
            buttonMoveActiveAccount.Click += buttonMoveActiveAccount_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(labelAllAccounts, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridViewInactiveAccounts, 0, 1);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(554, 647);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // labelAllAccounts
            // 
            labelAllAccounts.AutoSize = true;
            labelAllAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            labelAllAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelAllAccounts.Location = new System.Drawing.Point(3, 0);
            labelAllAccounts.Name = "labelAllAccounts";
            labelAllAccounts.Size = new System.Drawing.Size(548, 30);
            labelAllAccounts.TabIndex = 0;
            labelAllAccounts.Text = "Все аккаунты";
            labelAllAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewInactiveAccounts
            // 
            dataGridViewInactiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewInactiveAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInactiveAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Login, Password });
            dataGridViewInactiveAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewInactiveAccounts.Location = new System.Drawing.Point(3, 35);
            dataGridViewInactiveAccounts.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewInactiveAccounts.MultiSelect = false;
            dataGridViewInactiveAccounts.Name = "dataGridViewInactiveAccounts";
            dataGridViewInactiveAccounts.RowHeadersWidth = 51;
            dataGridViewInactiveAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInactiveAccounts.Size = new System.Drawing.Size(548, 607);
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
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(dataGridViewActiveAccounts, 0, 1);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(620, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new System.Drawing.Size(555, 647);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(549, 30);
            label1.TabIndex = 1;
            label1.Text = "Выбранные аккаунты";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewActiveAccounts
            // 
            dataGridViewActiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewActiveAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewActiveAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewActiveAccounts.Location = new System.Drawing.Point(3, 35);
            dataGridViewActiveAccounts.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewActiveAccounts.MultiSelect = false;
            dataGridViewActiveAccounts.Name = "dataGridViewActiveAccounts";
            dataGridViewActiveAccounts.RowHeadersWidth = 51;
            dataGridViewActiveAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveAccounts.Size = new System.Drawing.Size(549, 607);
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
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveSetupSettings, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCancel, 2, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1178, 72);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonSaveSetupSettings
            // 
            buttonSaveSetupSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            buttonSaveSetupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSaveSetupSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            buttonSaveSetupSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonSaveSetupSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveSetupSettings.Location = new System.Drawing.Point(232, 5);
            buttonSaveSetupSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            buttonSaveSetupSettings.Name = "buttonSaveSetupSettings";
            buttonSaveSetupSettings.Size = new System.Drawing.Size(337, 62);
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
            buttonStartSession.Location = new System.Drawing.Point(3, 5);
            buttonStartSession.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new System.Drawing.Size(223, 62);
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
            buttonCancel.Location = new System.Drawing.Point(575, 5);
            buttonCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(222, 61);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "ОТМЕНА";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AccountSetupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 961);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(1200, 800);
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