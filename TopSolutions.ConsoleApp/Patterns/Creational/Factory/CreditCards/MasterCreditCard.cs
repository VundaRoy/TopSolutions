using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    internal class MasterCreditCard : ICreditCard
    {   
        public MasterCreditCard() { }

        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "MASTER Credit Card";
        }

        public int GetCreditLimit()
        {
            return 21000;
        }
    }
}
