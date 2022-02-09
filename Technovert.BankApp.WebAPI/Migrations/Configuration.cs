namespace Technovert.BankApp.WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Technovert.BankApp.WebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Technovert.BankApp.WebAPI.Data.TechnovertBankAppWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Technovert.BankApp.WebAPI.Data.TechnovertBankAppWebAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Banks.AddOrUpdate(p => p.BankId,
                new Bank { BankName = "Allen" },
                new Bank { BankName = "Kim" },
                new Bank { BankName = "Jane" }
            );
        }
    }
}
