using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class NAB : IBank
    {
        public decimal Balance { get; private set; }
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with NAB");
            Balance -= amount;
            Console.WriteLine($"Payment of {amount} processed successfully. Please check your account for the updated balance.");
            Console.WriteLine("please note that NAB policy only allows payments to be processed between 9am and 5pm. " +
                "If you are trying to process a payment outside of these hours, please try again during business hours.");
        }

        public void GetTotalBalance()
        {
            Console.WriteLine($"Getting total balance from NAB. ${Balance}");
        }
    }
}
