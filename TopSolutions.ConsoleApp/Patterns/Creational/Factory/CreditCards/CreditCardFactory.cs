using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    public class CreditCardFactory
    {
       // Factory Method
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType.ToUpper())
            {
                case "AMEX":
                    return new AmexCreditCard();
                case "VISA":
                    return new VisaCreditCard();
                case "MASTER":
                    return new MasterCreditCard();
                default:
                    return new DefaultCreditCard();
            }
        }
    }
}
