using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class Bank : IBank
    {
        public decimal Balance { get; private set; }   
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[Bank B] API connected. Processing payment of {amount}.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"[Bank B] API connected. Retrieving total balance: {Balance}.");
        }
    }
}
