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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBoxReadBook = new CheckBox();
            checkBoxLikeTheBook = new CheckBox();
            checkBoxAddToLibrary = new CheckBox();
            checkBoxSubscribeToTheAuthor = new CheckBox();
            checkBoxPostComment = new CheckBox();
            checkBoxMakeADonationToTheAuthor = new CheckBox();
            checkBoxBuyABook = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewActiveAccounts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewAccounts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSaveSetupSettings = new Button();
            buttonStartSession = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(982, 553);
            tableLayoutPanel1.TabIndex = 0;
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
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 457);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(976, 92);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // checkBoxReadBook
            // 
            checkBoxReadBook.AutoSize = true;
            checkBoxReadBook.Location = new Point(3, 4);
            checkBoxReadBook.Margin = new Padding(3, 4, 3, 4);
            checkBoxReadBook.Name = "checkBoxReadBook";
            checkBoxReadBook.Size = new Size(120, 24);
            checkBoxReadBook.TabIndex = 6;
            checkBoxReadBook.Text = "Читать книгу";
            checkBoxReadBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxLikeTheBook
            // 
            checkBoxLikeTheBook.AutoSize = true;
            checkBoxLikeTheBook.Location = new Point(3, 36);
            checkBoxLikeTheBook.Margin = new Padding(3, 4, 3, 4);
            checkBoxLikeTheBook.Name = "checkBoxLikeTheBook";
            checkBoxLikeTheBook.Size = new Size(182, 24);
            checkBoxLikeTheBook.TabIndex = 1;
            checkBoxLikeTheBook.Text = "Поставить лайк книге";
            checkBoxLikeTheBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new Point(191, 4);
            checkBoxAddToLibrary.Margin = new Padding(3, 4, 3, 4);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new Size(195, 24);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new Point(191, 36);
            checkBoxSubscribeToTheAuthor.Margin = new Padding(3, 4, 3, 4);
            checkBoxSubscribeToTheAuthor.Name = "checkBoxSubscribeToTheAuthor";
            checkBoxSubscribeToTheAuthor.Size = new Size(194, 24);
            checkBoxSubscribeToTheAuthor.TabIndex = 2;
            checkBoxSubscribeToTheAuthor.Text = "Подписаться на автора";
            checkBoxSubscribeToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostComment
            // 
            checkBoxPostComment.AutoSize = true;
            checkBoxPostComment.Enabled = false;
            checkBoxPostComment.Location = new Point(392, 4);
            checkBoxPostComment.Margin = new Padding(3, 4, 3, 4);
            checkBoxPostComment.Name = "checkBoxPostComment";
            checkBoxPostComment.Size = new Size(194, 24);
            checkBoxPostComment.TabIndex = 3;
            checkBoxPostComment.Text = "Оставить комментарий";
            checkBoxPostComment.UseVisualStyleBackColor = true;
            // 
            // checkBoxMakeADonationToTheAuthor
            // 
            checkBoxMakeADonationToTheAuthor.AutoSize = true;
            checkBoxMakeADonationToTheAuthor.Enabled = false;
            checkBoxMakeADonationToTheAuthor.Location = new Point(392, 36);
            checkBoxMakeADonationToTheAuthor.Margin = new Padding(3, 4, 3, 4);
            checkBoxMakeADonationToTheAuthor.Name = "checkBoxMakeADonationToTheAuthor";
            checkBoxMakeADonationToTheAuthor.Size = new Size(183, 24);
            checkBoxMakeADonationToTheAuthor.TabIndex = 4;
            checkBoxMakeADonationToTheAuthor.Text = "Сделать Донат автору";
            checkBoxMakeADonationToTheAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuyABook
            // 
            checkBoxBuyABook.AutoSize = true;
            checkBoxBuyABook.Enabled = false;
            checkBoxBuyABook.Location = new Point(592, 4);
            checkBoxBuyABook.Margin = new Padding(3, 4, 3, 4);
            checkBoxBuyABook.Name = "checkBoxBuyABook";
            checkBoxBuyABook.Size = new Size(200, 24);
            checkBoxBuyABook.TabIndex = 5;
            checkBoxBuyABook.Text = "Купить книгу из читалки";
            checkBoxBuyABook.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridViewActiveAccounts, 2, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewAccounts, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(976, 387);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewActiveAccounts
            // 
            dataGridViewActiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewActiveAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveAccounts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewActiveAccounts.Dock = DockStyle.Fill;
            dataGridViewActiveAccounts.Location = new Point(516, 4);
            dataGridViewActiveAccounts.Margin = new Padding(3, 4, 3, 4);
            dataGridViewActiveAccounts.Name = "dataGridViewActiveAccounts";
            dataGridViewActiveAccounts.RowHeadersWidth = 51;
            dataGridViewActiveAccounts.Size = new Size(457, 379);
            dataGridViewActiveAccounts.TabIndex = 3;
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
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.AllowUserToOrderColumns = true;
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Columns.AddRange(new DataGridViewColumn[] { Id, Login, Password });
            dataGridViewAccounts.Dock = DockStyle.Fill;
            dataGridViewAccounts.Location = new Point(3, 4);
            dataGridViewAccounts.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.RowHeadersWidth = 51;
            dataGridViewAccounts.Size = new Size(457, 379);
            dataGridViewAccounts.TabIndex = 2;
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
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(button1, 0, 1);
            tableLayoutPanel3.Controls.Add(button2, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(466, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(44, 381);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(3, 148);
            button1.Name = "button1";
            button1.Size = new Size(38, 34);
            button1.TabIndex = 0;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(3, 198);
            button2.Name = "button2";
            button2.Size = new Size(38, 34);
            button2.TabIndex = 1;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(buttonSaveSetupSettings, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonStartSession, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCancel, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(976, 54);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonSaveSetupSettings
            // 
            buttonSaveSetupSettings.BackColor = SystemColors.ButtonFace;
            buttonSaveSetupSettings.Dock = DockStyle.Fill;
            buttonSaveSetupSettings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveSetupSettings.ForeColor = SystemColors.ControlText;
            buttonSaveSetupSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveSetupSettings.Location = new Point(203, 4);
            buttonSaveSetupSettings.Margin = new Padding(3, 4, 3, 4);
            buttonSaveSetupSettings.Name = "buttonSaveSetupSettings";
            buttonSaveSetupSettings.Size = new Size(294, 46);
            buttonSaveSetupSettings.TabIndex = 9;
            buttonSaveSetupSettings.Text = "СОХРАНИТЬ ПАРАМЕТРЫ";
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
            buttonStartSession.Location = new Point(3, 4);
            buttonStartSession.Margin = new Padding(3, 4, 3, 4);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(194, 46);
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
            buttonCancel.Location = new Point(503, 4);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(194, 46);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "ОТМЕНА";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AccountSetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1000, 600);
            Name = "AccountSetupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Параметры учетных записей";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonStartSession;
        private Button buttonSaveSetupSettings;
        private Button buttonCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxReadBook;
        private CheckBox checkBoxLikeTheBook;
        private CheckBox checkBoxAddToLibrary;
        private CheckBox checkBoxSubscribeToTheAuthor;
        private CheckBox checkBoxPostComment;
        private CheckBox checkBoxMakeADonationToTheAuthor;
        private CheckBox checkBoxBuyABook;
        private DataGridView dataGridViewAccounts;
        private DataGridView dataGridViewActiveAccounts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
    }
}