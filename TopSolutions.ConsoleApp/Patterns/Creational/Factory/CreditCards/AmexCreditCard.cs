using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    internal class AmexCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1200;
        }
        public AmexCreditCard() { }
        public string GetCardType()
        {
            return "AMEX Credit Card";
        }

        public int GetCreditLimit()
        {
            return 12000;
        }
    }
}
