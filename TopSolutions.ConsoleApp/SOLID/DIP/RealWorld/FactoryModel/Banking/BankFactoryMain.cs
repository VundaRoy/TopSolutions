using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public class BankFactoryMain
    {
        // This is the main entry point for the application. It demonstrates how to use the BankFactory to get a bank implementation based on user input and perform operations on it.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter bank code (WESTPAC or COMMBANK):");
            string bankCode = Console.ReadLine();
            IBank bank = BankFactory.GetBank(bankCode); //Get the bank implementation based on the bank code
            bank.ProcessPayment(100.00m);
            bank.GetTotalBalance();
        }   
    }
}
