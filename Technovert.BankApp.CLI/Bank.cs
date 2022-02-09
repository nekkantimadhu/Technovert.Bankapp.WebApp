using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI
{
    [Table("Banks")]
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }

    }
}
