using LitPulse.Data.Database.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitPulse.Forms
{
    public partial class AccountSetupForm : Form
    {
        DatabaseService dbService = new DatabaseService();
        
        public AccountSetupForm()
        {
            InitializeComponent();

            // Загрузка аккаунтов и настроек
            LoadAccounts();
        }

        /// <summary>
        /// Загружает аккаунты из БД
        /// </summary>
        private void LoadAccounts()
        {
            var accounts = dbService.GetAllAccounts();
            // заполнение/привязка аккаунтов к DataGridView

        }

        #region Обработчики кнопок

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            // Сохранение настроек в БД
            // ..........

            this.DialogResult = DialogResult.OK;
        }

        private void buttonSaveSetupSettings_Click(object sender, EventArgs e)
        {
            // Сохранение настроке в БД
            // ..........

            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        public List<Data.Database.Models.Account> GetData()
        {
            List<Data.Database.Models.Account> accounts = new List<Data.Database.Models.Account>();

            // Заполнение списка выбранными аккаунтами
            // .......

            return accounts;
        }
    }
}
