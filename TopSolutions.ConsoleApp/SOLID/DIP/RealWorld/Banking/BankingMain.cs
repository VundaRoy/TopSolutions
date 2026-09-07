using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.Banking
{
    //Demonstrate the Dependency Inversion Principle (DIP) in a banking application
    public class BankingMain
    {
        List<IBank> BankList;
        public static void Main(string[] args)
        {
            // Create a bank instance
            BankingMain bankingMain = new BankingMain();
            bankingMain.CreateListofBanks();
            //Dependency Inversion Principle (DIP) applied here
            //Using DIP to transfer amount to a WestPac account
            CreateBankInstance bankFactory = new CreateBankInstance();
            IBank westPacBank = bankFactory.CreateBank("WestPac", "NSW premier bank", "123 Bennett ave, Sydney NSW 2000");
            westPacBank.Deposit("123456", 1000);
            westPacBank.Transfer("123456", "654321", 500);
            string accountName = westPacBank.GetAccountName("123456");
            Console.WriteLine($"Account Name: {accountName}");
            //show the account balance after transfer
            Console.WriteLine($"Account Balance: {westPacBank.GetAccountBalance("123456")}");

        }
        public void CreateListofBanks()
        {
            BankList = new List<IBank>();
            CreateBankInstance bankFactory = new CreateBankInstance();
            BankList.Add(bankFactory.CreateBank("WestPac", "NSW premier bank", "123 Bennett ave, Sydney NSW 2000"));
            BankList.Add(bankFactory.CreateBank("Commonwealth Bank", "Australian premier bank", "15 Moorebank ave Newtown NSW 2042"));
            BankList.Add(bankFactory.CreateBank("ANZ", "Australia New Zealand Bank", "145 George Street, Sydney NSW 2000"));
            BankList.Add(bankFactory.CreateBank("NAB", "National Australia Bank", "123 Collins Street, Melbourne VIC 3000"));
            foreach (var bank in BankList)
            {
                Console.WriteLine($"Bank Name: {bank.Name}, Description: {bank.Description}, Address: {bank.Address}");
            }
        }
    }
}
