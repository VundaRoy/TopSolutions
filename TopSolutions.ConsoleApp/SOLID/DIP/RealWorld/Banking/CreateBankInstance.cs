using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.RealWorld.Banking
{
    public class CreateBankInstance
    {
        public IBank CreateBank(string name, string description, string address)
        {
            return new Bank
            {
                Name = name,
                Description = description,
                Address = address
            };
        }
    }
}
