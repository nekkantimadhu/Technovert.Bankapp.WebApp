using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Technovert.BankApp.DataAccess.Models;

namespace Technovert.BankApp.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Bank> Banks { get; set; }
        //public DbSet<Account> Accounts { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }
    }
}
