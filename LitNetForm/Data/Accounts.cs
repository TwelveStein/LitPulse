using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitNetForm.Data
{
    public class Accounts
    {
        public string? Login {  get; set; }
        public string? Password { get; set; }

        public Accounts(string login, string password)
        {
            Login = login.Trim();
            Password = password.Trim();
        }

        public override string ToString()
        {
            return $"{Login} : {Password}";
        }
    }
}
