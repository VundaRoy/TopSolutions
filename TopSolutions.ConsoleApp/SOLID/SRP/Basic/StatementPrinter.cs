using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.SRP.Basic
{
    public class StatementPrinter
    {
        public void Print(BankAccount account)
        {
            Console.WriteLine($"Statement for Account: {account.AccountNumber}");
            foreach (var transaction in account.Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
