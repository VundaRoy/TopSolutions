using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Strategy.Payment
{
    public class PaymentMain
    {
        public static void Main()
        {
            Checkout checkout = new Checkout(new CreditCardPayment()); // Default strategy
            checkout.ProcessOrder(100);
            checkout.SetStrategy(new PayPalPayment()); // Change strategy at runtime
            checkout.ProcessOrder(200);
            //direct debit
            checkout.SetStrategy(new DirectDebitPayment());
            checkout.ProcessOrder(300);
            //Use google wallet
            checkout.SetStrategy(new GoogleWalletPayment());
            //Verify Google account before processing payment
            GoogleWalletPayment.VerifyGoogleAccount();
            checkout.ProcessOrder(400);

        }

    }
}
