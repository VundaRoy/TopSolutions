using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Primera.Strategy.Contracts;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera.Strategy
{
    public class CurrencyConverter : ICryptoStrategy
    {
        public void ConvertToBitcoin(string currency,decimal amount, decimal factor)
        {
            Console.WriteLine($"{currency} {amount} is {amount * factor} in bitcoins.");
        }

        public void ConvertToEuthereum(string currency, decimal amount, decimal factor)
        {
            Console.WriteLine($"{currency} {amount} is {(amount % 3) * factor} in euthereum.");
        }
    }
}
