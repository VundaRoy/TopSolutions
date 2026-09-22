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
            string bankCode = string.Empty;
            //do while not valid bank code
            do {

                Console.WriteLine("Enter bank code (WESTPAC, NAB or COMMBANK):");
                bankCode = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(bankCode) || (bankCode != "WESTPAC" && bankCode != "NAB" && bankCode != "COMMBANK"));

            IBank bank = BankFactory.GetBank(bankCode); //Get the bank implementation based on the bank code
            bank.ProcessPayment(100.00m);
            bank.ProcessDeposit(200.00m);
            bank.GetTotalBalance();
        }   
    }
}
