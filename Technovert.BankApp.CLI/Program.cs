using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank
            {
                BankName = "andhrabank",
                Accounts = new List<Account>
                {
                    new Account() {AccName = "Madhu"},
                    new Account() {AccName = "Srii"},
                    new Account() {AccName = "Sushmitha"}
                }
            };
            DataAccess dbHelper = new DataAccess();
            dbHelper.AddBank(bank);
            var addedBank = dbHelper.FetchBanks().FirstOrDefault();
            if (addedBank != null)
            {
                Console.WriteLine("Bank Name is: " + addedBank.BankName + Environment.NewLine);
                Console.WriteLine("Bank Accounts are: " + Environment.NewLine);

                foreach (var addedBankAccount in addedBank.Accounts)
                {
                    Console.WriteLine(addedBankAccount.AccName + Environment.NewLine);
                }

                Console.ReadLine();
            }
        }
    }
}
