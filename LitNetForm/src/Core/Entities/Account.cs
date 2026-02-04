using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }

        public bool LitNet { get; set; } = false;
        
        public bool LitMarket{ get; set; } = false;
        
        public bool IsActive { get; private set; } = true;

        // ef core ctor
        private Account() { }
        
        public Account(string login, string password, bool litNet, bool litMarket, AccountSettings accountSettings)
        {
            Login = login;
            Password = password;
            LitNet = litNet;
            LitMarket = litMarket;
            AccountSettings = accountSettings;
        }
        
        // Навигационное свойство
        public AccountSettings AccountSettings { get; set; }
        
        //Вспомогательное свойство
        [NotMapped]
        public bool IsModified { get; private set; } = false;

        /// <summary>
        /// Изменяет основную информацию об аккаунте
        /// </summary>
        public void UpdateMainInformation(
            string login, 
            string password,
            bool litNet,
            bool litMarket)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return;
            
            Login = login;
            Password = password;
            LitNet = litNet;
            LitMarket = litMarket;
            
            MarkAsModified();
        }

        /// <summary>
        /// Помечает аккаунт как "модифицированный"
        /// </summary>
        public void MarkAsModified()
        {
            IsModified = true;
        }
        
        /// <summary>
        /// Помечает аккаунт как "не модифицированный"
        /// </summary>
        public void MarkAsUnmodified()
        {
            IsModified = false;
        }

        /// <summary>
        /// Изменяет статус активности аккаунта
        /// </summary>
        public void ChangeActivityStatus()
        {
            IsActive = !IsActive;
        }
    }
}
