using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class ANZ : IBank
    {
        public decimal Balance { get; set; }
        public void ProcessPayment(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Processing payment of {amount} through ANZ.");
        }
        public void ProcessDeposit(decimal amount)
        {
         Balance += amount;
         Console.WriteLine($"Processing deposit of {amount} through ANZ.");
        }
        public void GetTotalBalance()
        {
            Console.WriteLine($"Getting total balance from ANZ. ${Balance}");            
        }
    }
}
