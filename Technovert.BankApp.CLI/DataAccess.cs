using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI
{
    public class DataAccess
    {
        readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Bank> FetchBanks()
        {
            return _dbContext.Banks.ToList();
        }

        public List<Account> FetchAccounts()
        {
            return _dbContext.Accounts.ToList();
        }

        public string AddBank(Bank bank)
        {
                       
            _dbContext.Banks.Add(bank);
            _dbContext.SaveChanges();
            return bank.BankName;
        }

        public string AddAccount(Account account)
        {
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
            return account.AccName;
        }
    }
}
