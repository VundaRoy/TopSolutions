using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.FactoryModel.Banking
{
    public static class BankFactory
    {
        public static IBank GetBank(string bankCode)
        {
            return bankCode.ToUpper() switch
            {
                "WESTPAC" => new WestPac(),
                "COMMBANK" => new CommBank(),
                _ => throw new ArgumentException("Invalid bank code")
            };
        }
    }
}
