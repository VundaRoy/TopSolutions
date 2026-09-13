using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class BankFactoryMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter bank code (WESTPAC or COMMBANK):");
            string bankCode = Console.ReadLine();
            IBank bank = BankFactory.GetBank(bankCode);
            bank.ProcessPayment(100.00m);
            bank.GetTotalBalance();
        }   
    }
}
