using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    public class DefaultCreditCard : ICreditCard    
    {
        public DefaultCreditCard() { }
        public string GetCardType()
        {
            return "Default Credit Card";
        }
        public int GetCreditLimit()
        {
            return 5000;
        }
        public int GetAnnualCharge()
        {
            return 300;
        }
    }
}
