using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Primera.Strategy.Contracts;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera.Strategy
{
    public class CryptoContext
    {
        ICryptoStrategy strategy;
        public enum Currencies
        {
            USD,
            GBP,
            EUR
        }
        public CryptoContext(ICryptoStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void CryptoInterface(string currency, decimal amount, decimal factor)
        {
            strategy.ConvertToBitcoin(currency,amount,factor);
        }
        public void CryptoEuthereumInterface(string currency, decimal amount, decimal factor)
        {
            strategy.ConvertToEuthereum(currency, amount, factor);
        }
    }
}
