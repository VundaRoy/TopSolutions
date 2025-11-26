using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.CreditCards
{
    public class CreditMain
    {
        public static void Main()
        {
            // Create Visa Credit Card
            ICreditCard visaCard = CreditCardFactory.GetCreditCard("VISA");
            Console.WriteLine("Card Type: " + visaCard.GetCardType());
            Console.WriteLine("Credit Limit: " + visaCard.GetCreditLimit());
            Console.WriteLine("Annual Charge: " + visaCard.GetAnnualCharge());
            Console.WriteLine();
            // Create MasterCard Credit Card
            ICreditCard masterCard = CreditCardFactory.GetCreditCard("MASTER");
            Console.WriteLine("Card Type: " + masterCard.GetCardType());
            Console.WriteLine("Credit Limit: " + masterCard.GetCreditLimit());
            Console.WriteLine("Annual Charge: " + masterCard.GetAnnualCharge());
            Console.WriteLine();
            //Create Amex credit card
            ICreditCard amexCard = CreditCardFactory.GetCreditCard("AMEX");
            Console.WriteLine("Card Type: " + amexCard.GetCardType());
            Console.WriteLine("Credit Limit: " + amexCard.GetCreditLimit());
            Console.WriteLine("Annual Charge: " + amexCard.GetAnnualCharge());
            Console.WriteLine();
        }
    }
}
