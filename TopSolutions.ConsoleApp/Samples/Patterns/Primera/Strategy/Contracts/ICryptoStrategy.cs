using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera.Strategy.Contracts
{
    public interface ICryptoStrategy
    {
        void ConvertToBitcoin(string currency,decimal amount, decimal factor);
        void ConvertToEuthereum(string currency, decimal amount, decimal factor);
    }
}
