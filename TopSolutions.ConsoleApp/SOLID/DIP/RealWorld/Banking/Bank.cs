using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.Banking
{
    public class Bank : IBank
    {
        public void Transfer(string fromAccount, string toAccount, decimal amount)
        {
            // Implementation here
        }

        public string GetAccountName(string account)
        {
            // Implementation here
            return string.Empty;
        }

        public void Deposit(string account, decimal amount)
        {
            // Implementation here
        }

        public decimal GetAccountBalance(string account)
        {
            // Implementation here
            return 0;
        }

        public decimal GetBalance(string account)
        {
            // Implementation here
            return 0;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; } 
    }
}
