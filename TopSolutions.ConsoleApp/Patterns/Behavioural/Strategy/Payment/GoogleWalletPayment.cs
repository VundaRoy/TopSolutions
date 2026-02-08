using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Strategy.Payment
{
    public class GoogleWalletPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Google Wallet.");
        }    
        public static void VerifyGoogleAccount() // Specific method for Google Wallet
        {
            Console.WriteLine("Verifying Google account...");
        }
    }
}
