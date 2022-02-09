using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Technovert.BankApp.CLI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
