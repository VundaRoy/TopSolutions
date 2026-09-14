using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class NAB : IBank
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with NAB");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine("Getting total balance from NAB");
        }
    }
}
