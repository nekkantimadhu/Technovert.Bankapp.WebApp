namespace Technovert.BankApp.CLI_Migrations.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Technovert.BankApp.CLI_Migrations.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Technovert.BankApp.CLI_Migrations.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Bank bank = new Bank
            {
                BankName = "Technology",
                Accounts = new List<Account>
                {
                    new Account() {AccName = "Jack"},
                    new Account() {AccName = "Kim"},
                    new Account() {AccName = "Shen"}
                }
            };

            Account account = new Account
            {
                AccName = "Akhil Mittal",
                BankId = "1"
            };

            context.Banks.AddOrUpdate(bank);
            context.Accounts.AddOrUpdate(account);
        }
    }
}
