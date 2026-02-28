namespace LitPulse.Forms
{
    partial class ProxySettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxySettingsForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelAllAccounts = new Label();
            dataGridViewInactiveAccounts = new DataGridView();
            Host = new DataGridViewTextBoxColumn();
            Port = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSaveSetupSettings = new Button();
            buttonCancel = new Button();
            checkBoxProxyIsActive = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonImportProxyList = new Button();
            buttonAddProxy = new Button();
            buttonRemoveProxy = new Button();
            buttonClearProxyList = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel1.Size = new Size(712, 553);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 85);
            tableLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(706, 253);
            tableLayoutPanel2.TabIndex = 0;
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
            tableLayoutPanel5.Size = new Size(700, 245);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // labelAllAccounts
            // 
            labelAllAccounts.AutoSize = true;
            labelAllAccounts.Dock = DockStyle.Fill;
            labelAllAccounts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelAllAccounts.Location = new Point(3, 0);
            labelAllAccounts.Name = "labelAllAccounts";
            labelAllAccounts.Size = new Size(694, 40);
            labelAllAccounts.TabIndex = 0;
            labelAllAccounts.Text = "Список прокси";
            labelAllAccounts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewInactiveAccounts
            // 
            dataGridViewInactiveAccounts.AllowUserToOrderColumns = true;
            dataGridViewInactiveAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInactiveAccounts.Columns.AddRange(new DataGridViewColumn[] { Host, Port, Username, Password });
            dataGridViewInactiveAccounts.Dock = DockStyle.Fill;
            dataGridViewInactiveAccounts.Location = new Point(3, 47);
            dataGridViewInactiveAccounts.Margin = new Padding(3, 7, 3, 7);
            dataGridViewInactiveAccounts.MultiSelect = false;
            dataGridViewInactiveAccounts.Name = "dataGridViewInactiveAccounts";
            dataGridViewInactiveAccounts.RowHeadersWidth = 51;
            dataGridViewInactiveAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInactiveAccounts.Size = new Size(694, 191);
            dataGridViewInactiveAccounts.TabIndex = 2;
            // 
            // Host
            // 
            Host.DataPropertyName = "Host";
            Host.HeaderText = "Host";
            Host.MinimumWidth = 6;
            Host.Name = "Host";
            Host.ReadOnly = true;
            Host.Width = 150;
            // 
            // Port
            // 
            Port.DataPropertyName = "Port";
            Port.HeaderText = "Port";
            Port.MinimumWidth = 6;
            Port.Name = "Port";
            Port.ReadOnly = true;
            Port.Width = 150;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 150;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 150;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(buttonSaveSetupSettings, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel4.Controls.Add(checkBoxProxyIsActive, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 5);
            tableLayoutPanel4.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(706, 70);
            tableLayoutPanel4.TabIndex = 1;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // buttonSaveSetupSettings
            // 
            buttonSaveSetupSettings.BackColor = SystemColors.ButtonFace;
            buttonSaveSetupSettings.Dock = DockStyle.Fill;
            buttonSaveSetupSettings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveSetupSettings.ForeColor = SystemColors.ControlText;
            buttonSaveSetupSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveSetupSettings.Location = new Point(3, 7);
            buttonSaveSetupSettings.Margin = new Padding(3, 7, 3, 7);
            buttonSaveSetupSettings.Name = "buttonSaveSetupSettings";
            buttonSaveSetupSettings.Size = new Size(244, 56);
            buttonSaveSetupSettings.TabIndex = 9;
            buttonSaveSetupSettings.Text = "СОХРАНИТЬ ИЗМЕНЕНИЯ";
            buttonSaveSetupSettings.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ButtonFace;
            buttonCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(253, 7);
            buttonCancel.Margin = new Padding(3, 7, 3, 7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(244, 56);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "ОТМЕНА";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // checkBoxProxyIsActive
            // 
            checkBoxProxyIsActive.AutoSize = true;
            checkBoxProxyIsActive.Dock = DockStyle.Fill;
            checkBoxProxyIsActive.Location = new Point(503, 3);
            checkBoxProxyIsActive.Name = "checkBoxProxyIsActive";
            checkBoxProxyIsActive.Size = new Size(200, 64);
            checkBoxProxyIsActive.TabIndex = 10;
            checkBoxProxyIsActive.Text = "Использовать прокси";
            checkBoxProxyIsActive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 346);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(706, 204);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonImportProxyList);
            flowLayoutPanel2.Controls.Add(buttonAddProxy);
            flowLayoutPanel2.Controls.Add(buttonRemoveProxy);
            flowLayoutPanel2.Controls.Add(buttonClearProxyList);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 5);
            flowLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(700, 65);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // buttonImportProxyList
            // 
            buttonImportProxyList.Dock = DockStyle.Top;
            buttonImportProxyList.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonImportProxyList.Image = Properties.Resources.uploadIcon;
            buttonImportProxyList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImportProxyList.Location = new Point(10, 5);
            buttonImportProxyList.Margin = new Padding(10, 5, 5, 5);
            buttonImportProxyList.Name = "buttonImportProxyList";
            buttonImportProxyList.Size = new Size(300, 55);
            buttonImportProxyList.TabIndex = 0;
            buttonImportProxyList.Text = "Импорт списка прокси";
            buttonImportProxyList.UseVisualStyleBackColor = true;
            // 
            // buttonAddProxy
            // 
            buttonAddProxy.Image = Properties.Resources.AddIcon;
            buttonAddProxy.Location = new Point(318, 5);
            buttonAddProxy.Margin = new Padding(3, 5, 3, 5);
            buttonAddProxy.Name = "buttonAddProxy";
            buttonAddProxy.Size = new Size(55, 55);
            buttonAddProxy.TabIndex = 1;
            buttonAddProxy.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProxy
            // 
            buttonRemoveProxy.Image = Properties.Resources.RemoveIcon_Full;
            buttonRemoveProxy.Location = new Point(379, 5);
            buttonRemoveProxy.Margin = new Padding(3, 5, 3, 5);
            buttonRemoveProxy.Name = "buttonRemoveProxy";
            buttonRemoveProxy.Size = new Size(55, 55);
            buttonRemoveProxy.TabIndex = 2;
            buttonRemoveProxy.UseVisualStyleBackColor = true;
            // 
            // buttonClearProxyList
            // 
            buttonClearProxyList.BackColor = Color.Red;
            buttonClearProxyList.Dock = DockStyle.Fill;
            buttonClearProxyList.Image = Properties.Resources.ClearIcon_White;
            buttonClearProxyList.Location = new Point(440, 5);
            buttonClearProxyList.Margin = new Padding(3, 5, 3, 5);
            buttonClearProxyList.Name = "buttonClearProxyList";
            buttonClearProxyList.Size = new Size(55, 55);
            buttonClearProxyList.TabIndex = 9;
            buttonClearProxyList.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(richTextBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(700, 123);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 20);
            label1.TabIndex = 10;
            label1.Text = "Формат прокси: host:port:login:password";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.Location = new Point(3, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 90);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Важно!!! В открытых ботом окнах браузера НЕ открывать замеры скорости интернета!!! При замере израсходуется весь трафик прокси!!!";
            // 
            // ProxySettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 553);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(730, 600);
            Name = "ProxySettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки прокси";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInactiveAccounts).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelAllAccounts;
        private DataGridView dataGridViewInactiveAccounts;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonSaveSetupSettings;
        private Button buttonCancel;
        private DataGridViewTextBoxColumn Host;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private CheckBox checkBoxProxyIsActive;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonImportProxyList;
        private Button buttonAddProxy;
        private Button buttonRemoveProxy;
        private Button buttonClearProxyList;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}