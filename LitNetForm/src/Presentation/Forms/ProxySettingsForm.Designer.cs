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
            dataGridViewProxys = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonImportProxyList = new Button();
            buttonDeleteProxy = new Button();
            buttonClearProxyList = new Button();
            checkBoxProxyIsActive = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            Host = new DataGridViewTextBoxColumn();
            Port = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Server = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProxys).BeginInit();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.Size = new Size(882, 503);
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
            tableLayoutPanel2.Location = new Point(3, 6);
            tableLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(876, 334);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(labelAllAccounts, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridViewProxys, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 4);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(870, 326);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // labelAllAccounts
            // 
            labelAllAccounts.AutoSize = true;
            labelAllAccounts.Dock = DockStyle.Fill;
            labelAllAccounts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelAllAccounts.Location = new Point(3, 0);
            labelAllAccounts.Name = "labelAllAccounts";
            labelAllAccounts.Size = new Size(864, 40);
            labelAllAccounts.TabIndex = 0;
            labelAllAccounts.Text = "Список прокси";
            labelAllAccounts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewProxys
            // 
            dataGridViewProxys.AllowUserToAddRows = false;
            dataGridViewProxys.AllowUserToDeleteRows = false;
            dataGridViewProxys.AllowUserToOrderColumns = true;
            dataGridViewProxys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProxys.Columns.AddRange(new DataGridViewColumn[] { Host, Port, Username, Password, Server });
            dataGridViewProxys.Dock = DockStyle.Fill;
            dataGridViewProxys.Location = new Point(3, 47);
            dataGridViewProxys.Margin = new Padding(3, 7, 3, 7);
            dataGridViewProxys.MultiSelect = false;
            dataGridViewProxys.Name = "dataGridViewProxys";
            dataGridViewProxys.ReadOnly = true;
            dataGridViewProxys.RowHeadersWidth = 51;
            dataGridViewProxys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProxys.Size = new Size(864, 272);
            dataGridViewProxys.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 348);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(876, 152);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonImportProxyList);
            flowLayoutPanel2.Controls.Add(buttonDeleteProxy);
            flowLayoutPanel2.Controls.Add(buttonClearProxyList);
            flowLayoutPanel2.Controls.Add(checkBoxProxyIsActive);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 5);
            flowLayoutPanel2.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(870, 65);
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
            buttonImportProxyList.Click += buttonImportProxyList_Click;
            // 
            // buttonDeleteProxy
            // 
            buttonDeleteProxy.Dock = DockStyle.Fill;
            buttonDeleteProxy.Image = Properties.Resources.RemoveIcon_Full;
            buttonDeleteProxy.Location = new Point(318, 5);
            buttonDeleteProxy.Margin = new Padding(3, 5, 3, 5);
            buttonDeleteProxy.Name = "buttonDeleteProxy";
            buttonDeleteProxy.Size = new Size(55, 55);
            buttonDeleteProxy.TabIndex = 11;
            buttonDeleteProxy.UseVisualStyleBackColor = true;
            buttonDeleteProxy.Click += buttonDeleteProxy_Click;
            // 
            // buttonClearProxyList
            // 
            buttonClearProxyList.BackColor = Color.Red;
            buttonClearProxyList.Dock = DockStyle.Fill;
            buttonClearProxyList.Image = Properties.Resources.ClearIcon_White;
            buttonClearProxyList.Location = new Point(379, 5);
            buttonClearProxyList.Margin = new Padding(3, 5, 3, 5);
            buttonClearProxyList.Name = "buttonClearProxyList";
            buttonClearProxyList.Size = new Size(55, 55);
            buttonClearProxyList.TabIndex = 9;
            buttonClearProxyList.UseVisualStyleBackColor = false;
            buttonClearProxyList.Click += buttonClearProxyList_Click;
            // 
            // checkBoxProxyIsActive
            // 
            checkBoxProxyIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxProxyIsActive.AutoSize = true;
            checkBoxProxyIsActive.Location = new Point(440, 3);
            checkBoxProxyIsActive.Name = "checkBoxProxyIsActive";
            checkBoxProxyIsActive.Size = new Size(183, 59);
            checkBoxProxyIsActive.TabIndex = 10;
            checkBoxProxyIsActive.Text = "Использовать прокси";
            checkBoxProxyIsActive.UseVisualStyleBackColor = true;
            checkBoxProxyIsActive.CheckedChanged += checkBoxProxyIsActive_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(richTextBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(870, 71);
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
            richTextBox1.Location = new Point(295, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(530, 60);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Важно!!! В открытых ботом окнах браузера НЕ открывать замеры скорости интернета!!! При замере израсходуется весь трафик прокси!!!";
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
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 150;
            // 
            // Server
            // 
            Server.DataPropertyName = "Server";
            Server.HeaderText = "Server";
            Server.MinimumWidth = 6;
            Server.Name = "Server";
            Server.ReadOnly = true;
            Server.Width = 200;
            // 
            // ProxySettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 550);
            Name = "ProxySettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки прокси";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProxys).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelAllAccounts;
        private DataGridView dataGridViewProxys;
        private CheckBox checkBoxProxyIsActive;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonImportProxyList;
        private Button buttonClearProxyList;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button buttonDeleteProxy;
        private DataGridViewTextBoxColumn Host;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Server;
    }
}