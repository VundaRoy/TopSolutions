using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.Banking
{
    public interface IBank
    {
        //properties
        string Name { get; set; }
        string Description { get; set; }
        string Address { get; set; }
        void Transfer(string fromAccount, string toAccount, decimal amount);
        string GetAccountName(string account);
        void Deposit(string account, decimal amount);
        decimal GetAccountBalance(string account);
        decimal GetBalance(string account);
    }
}
