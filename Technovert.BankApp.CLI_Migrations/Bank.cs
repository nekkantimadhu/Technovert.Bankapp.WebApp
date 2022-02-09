using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI_Migrations
{
    public class Bank
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
