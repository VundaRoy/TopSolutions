using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.Banking
{
    public class Bank : IBank
    {
        public void Transfer(string fromAccount, string toAccount, decimal amount)
        {
            Amount += amount;
            Console.WriteLine($"Transferred {amount} from account {fromAccount} to account {toAccount}. New balance: {Amount}");
        }

        public string GetAccountName(string account)
        {
            // Implementation here
            return Name;
        }

        public void Deposit(string account, decimal amount)
        {
            Amount += amount;
        }

        public decimal GetAccountBalance(string account)
        {
            // Implementation here
            return Amount;
        }

        public decimal GetBalance(string account)
        {
            // Implementation here
            return Amount;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; } 
        public decimal Amount { get; set; }
    }
}
