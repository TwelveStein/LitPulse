using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Links
    {
        public string? Link { get; set; }

        public List<int> AccountsId { get; set; }

        public Links(string link, List<int> AccountsId)
        {
            Link = link.Trim();
            this.AccountsId = AccountsId;
        }

        public Links()
        {
            
        }
    }
}
