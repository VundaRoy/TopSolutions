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
            checkout.setStrategy(new PayPalPayment()); // Change strategy at runtime
            checkout.ProcessOrder(200);
            //direct debit
            checkout.setStrategy(new DirectDebitPayment());
            checkout.ProcessOrder(300);
            //Use google wallet
            checkout.setStrategy(new GoogleWalletPayment());
            //Verify Google account before processing payment
            GoogleWalletPayment.VerifyGoogleAccount();
            checkout.ProcessOrder(400);

        }

    }
}
