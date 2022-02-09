using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using Technovert.BankApp.WebAPI.Exceptions;

namespace Technovert.BankApp.WebAPI.Data
{
    public class TechnovertBankAppWebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TechnovertBankAppWebAPIContext() : base("name=TechnovertBankAppWebAPIContext")
        {
        }
       /* public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }*/

        public System.Data.Entity.DbSet<Technovert.BankApp.WebAPI.Models.Bank> Banks { get; set; }
    }
}
