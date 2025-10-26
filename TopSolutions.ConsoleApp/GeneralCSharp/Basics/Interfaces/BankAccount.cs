using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.GeneralCSharp.Basics.Interfaces.Contract;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Interfaces
{
    public class BankAccount : IBankAccount
    {
        private decimal balance;
        public BankAccount()
        {
            balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
