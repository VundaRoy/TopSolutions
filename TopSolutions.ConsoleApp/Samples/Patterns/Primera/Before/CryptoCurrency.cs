using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera.Before
{
    public class CryptoCurrency
    {
        public CryptoCurrency()
        {

        }

        public enum Currencies
        {
            USD,
            GBP,
            EUR
        }

        const decimal US_RATE = 12;
        const decimal GBP_RATE = 10;
        const decimal EUR_RATE = 8.5M;
         
        public void ConvvertToBitCoin(Currencies curr, decimal amount)
        {
            int input = (int)curr;

            switch (input)
            {
                case 0:
                    Console.WriteLine($"USD {amount} is {amount * US_RATE} in bitcoins."  );
                    break;
                case 1:
                    Console.WriteLine($"GBP {amount} is {amount * GBP_RATE} in bitcoins");
                    break;
                case 2:
                    Console.WriteLine($"EUR {amount} is {amount * EUR_RATE} in bitcoins");
                    break;

                default:
                    break;
            }
        }



    }
}
