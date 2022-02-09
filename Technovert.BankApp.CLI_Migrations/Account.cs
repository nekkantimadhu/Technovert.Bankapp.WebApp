using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI_Migrations
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public string AccId { get; set; }
        public string AccName { get; set; }
        public string BankId { get; set; }

        public virtual Bank Banks { get; set; }
    }
}
