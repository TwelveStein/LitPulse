namespace LitNetForm.Forms
{
    partial class SettingsForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonSaveSettings = new Button();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBoxAddToLibrary = new CheckBox();
            checkBoxLikeTheBook = new CheckBox();
            checkBoxSubscribeToTheAuthor = new CheckBox();
            checkBoxPostComment = new CheckBox();
            checkBoxMakeADonationToTheAuthor = new CheckBox();
            checkBoxBuyABook = new CheckBox();
            tabPage5 = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            richTextBoxProfile = new RichTextBox();
            label6 = new Label();
            comboBoxReadProfiles = new ComboBox();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            numericUpDownMinMaxPauseAfterScrolling = new NumericUpDown();
            numericUpDownMinMaxScrollDuration = new NumericUpDown();
            numericUpDownMinMaxScrollStep = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownChanceOfRegression = new NumericUpDown();
            tabPage6 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPage5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxPauseAfterScrolling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxScrollDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxScrollStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChanceOfRegression).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(688, 373);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonSaveSettings, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 326);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(682, 44);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(344, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(335, 38);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.DialogResult = DialogResult.OK;
            buttonSaveSettings.Dock = DockStyle.Fill;
            buttonSaveSettings.Location = new Point(3, 3);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(335, 38);
            buttonSaveSettings.TabIndex = 0;
            buttonSaveSettings.Text = "Сохранить";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(682, 317);
            tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(flowLayoutPanel1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(674, 284);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Настройки запуска";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBoxAddToLibrary);
            flowLayoutPanel1.Controls.Add(checkBoxLikeTheBook);
            flowLayoutPanel1.Controls.Add(checkBoxSubscribeToTheAuthor);
            flowLayoutPanel1.Controls.Add(checkBoxPostComment);
            flowLayoutPanel1.Controls.Add(checkBoxMakeADonationToTheAuthor);
            flowLayoutPanel1.Controls.Add(checkBoxBuyABook);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 278);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // checkBoxAddToLibrary
            // 
            checkBoxAddToLibrary.AutoSize = true;
            checkBoxAddToLibrary.Location = new Point(3, 3);
            checkBoxAddToLibrary.Name = "checkBoxAddToLibrary";
            checkBoxAddToLibrary.Size = new Size(195, 24);
            checkBoxAddToLibrary.TabIndex = 0;
            checkBoxAddToLibrary.Text = "Добавить в библиотеку";
            checkBoxAddToLibrary.UseVisualStyleBackColor = true;
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
            // 
            // checkBoxSubscribeToTheAuthor
            // 
            checkBoxSubscribeToTheAuthor.AutoSize = true;
            checkBoxSubscribeToTheAuthor.Location = new Point(3, 63);
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
            checkBoxPostComment.Location = new Point(3, 93);
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
            checkBoxMakeADonationToTheAuthor.Location = new Point(3, 123);
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
            checkBoxBuyABook.Location = new Point(3, 153);
            checkBoxBuyABook.Name = "checkBoxBuyABook";
            checkBoxBuyABook.Size = new Size(200, 24);
            checkBoxBuyABook.TabIndex = 5;
            checkBoxBuyABook.Text = "Купить книгу из читалки";
            checkBoxBuyABook.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(flowLayoutPanel2);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(674, 284);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Профили";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(668, 278);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxProfile);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxReadProfiles);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 271);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // richTextBoxProfile
            // 
            richTextBoxProfile.BackColor = SystemColors.Control;
            richTextBoxProfile.BorderStyle = BorderStyle.None;
            richTextBoxProfile.Dock = DockStyle.Fill;
            richTextBoxProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxProfile.Location = new Point(3, 91);
            richTextBoxProfile.Name = "richTextBoxProfile";
            richTextBoxProfile.Size = new Size(275, 177);
            richTextBoxProfile.TabIndex = 9;
            richTextBoxProfile.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 71);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 8;
            label6.Text = "Описание профиля:";
            // 
            // comboBoxReadProfiles
            // 
            comboBoxReadProfiles.Dock = DockStyle.Top;
            comboBoxReadProfiles.FormattingEnabled = true;
            comboBoxReadProfiles.Items.AddRange(new object[] { "Быстрое чтение", "Глубокое чтение", "Уставшее чтение" });
            comboBoxReadProfiles.Location = new Point(3, 43);
            comboBoxReadProfiles.Name = "comboBoxReadProfiles";
            comboBoxReadProfiles.Size = new Size(275, 28);
            comboBoxReadProfiles.TabIndex = 7;
            comboBoxReadProfiles.SelectedIndexChanged += comboBoxReadProfiles_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 23);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 6;
            label5.Text = "Профили чтения";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.2F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8F));
            tableLayoutPanel3.Controls.Add(numericUpDownMinMaxPauseAfterScrolling, 1, 3);
            tableLayoutPanel3.Controls.Add(numericUpDownMinMaxScrollDuration, 1, 2);
            tableLayoutPanel3.Controls.Add(numericUpDownMinMaxScrollStep, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(numericUpDownChanceOfRegression, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(290, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(375, 271);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // numericUpDownMinMaxPauseAfterScrolling
            // 
            numericUpDownMinMaxPauseAfterScrolling.Dock = DockStyle.Fill;
            numericUpDownMinMaxPauseAfterScrolling.Location = new Point(299, 108);
            numericUpDownMinMaxPauseAfterScrolling.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownMinMaxPauseAfterScrolling.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownMinMaxPauseAfterScrolling.Name = "numericUpDownMinMaxPauseAfterScrolling";
            numericUpDownMinMaxPauseAfterScrolling.Size = new Size(73, 27);
            numericUpDownMinMaxPauseAfterScrolling.TabIndex = 18;
            numericUpDownMinMaxPauseAfterScrolling.Value = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownMinMaxPauseAfterScrolling.Leave += numericUpDownProfileSetttings_Leave;
            // 
            // numericUpDownMinMaxScrollDuration
            // 
            numericUpDownMinMaxScrollDuration.Dock = DockStyle.Fill;
            numericUpDownMinMaxScrollDuration.Location = new Point(299, 73);
            numericUpDownMinMaxScrollDuration.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownMinMaxScrollDuration.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownMinMaxScrollDuration.Name = "numericUpDownMinMaxScrollDuration";
            numericUpDownMinMaxScrollDuration.Size = new Size(73, 27);
            numericUpDownMinMaxScrollDuration.TabIndex = 17;
            numericUpDownMinMaxScrollDuration.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownMinMaxScrollDuration.Leave += numericUpDownProfileSetttings_Leave;
            // 
            // numericUpDownMinMaxScrollStep
            // 
            numericUpDownMinMaxScrollStep.Dock = DockStyle.Fill;
            numericUpDownMinMaxScrollStep.Location = new Point(299, 38);
            numericUpDownMinMaxScrollStep.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            numericUpDownMinMaxScrollStep.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownMinMaxScrollStep.Name = "numericUpDownMinMaxScrollStep";
            numericUpDownMinMaxScrollStep.Size = new Size(73, 27);
            numericUpDownMinMaxScrollStep.TabIndex = 16;
            numericUpDownMinMaxScrollStep.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownMinMaxScrollStep.Leave += numericUpDownProfileSetttings_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(290, 35);
            label4.TabIndex = 6;
            label4.Text = "Мин/макс пауза после прокрутки (мс)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(290, 35);
            label3.TabIndex = 4;
            label3.Text = "Мин/макс длительность прокрутки (мс)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(290, 35);
            label2.TabIndex = 2;
            label2.Text = "Мин/макс шаг прокрутки (px)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 35);
            label1.TabIndex = 0;
            label1.Text = "Шанс регрессии (%)";
            // 
            // numericUpDownChanceOfRegression
            // 
            numericUpDownChanceOfRegression.Dock = DockStyle.Fill;
            numericUpDownChanceOfRegression.Location = new Point(299, 3);
            numericUpDownChanceOfRegression.Name = "numericUpDownChanceOfRegression";
            numericUpDownChanceOfRegression.Size = new Size(73, 27);
            numericUpDownChanceOfRegression.TabIndex = 15;
            numericUpDownChanceOfRegression.Leave += numericUpDownProfileSetttings_Leave;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(674, 284);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Запуск";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 373);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(600, 420);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabPage5.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxPauseAfterScrolling).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxScrollDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinMaxScrollStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChanceOfRegression).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCancel;
        private Button buttonSaveSettings;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxAddToLibrary;
        private CheckBox checkBoxLikeTheBook;
        private CheckBox checkBoxSubscribeToTheAuthor;
        private CheckBox checkBoxPostComment;
        private CheckBox checkBoxMakeADonationToTheAuthor;
        private CheckBox checkBoxBuyABook;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxProfile;
        private Label label6;
        private ComboBox comboBoxReadProfiles;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownChanceOfRegression;
        private NumericUpDown numericUpDownMinMaxPauseAfterScrolling;
        private NumericUpDown numericUpDownMinMaxScrollDuration;
        private NumericUpDown numericUpDownMinMaxScrollStep;
    }
}