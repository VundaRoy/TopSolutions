using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    internal class VisaCreditCard : ICreditCard
    {
        public VisaCreditCard() { }

        public int GetAnnualCharge()
        {
            return 800;
        }

        public string GetCardType()
        {
            return "VISA Credit Card";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }
    }
}
