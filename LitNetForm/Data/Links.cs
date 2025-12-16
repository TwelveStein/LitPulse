using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitNetForm.Data
{
    public class Links
    {
        public string? Link { get; set; }
    
        public Links(string link)
        {
            Link = link.Trim();
        }   
    }
}