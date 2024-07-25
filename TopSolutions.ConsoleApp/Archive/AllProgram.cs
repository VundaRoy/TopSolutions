using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Archive
{
    internal class AllProgram
    {

        void AllMethods()
        {
            //get reports pre-Iterator

            //var eReport = new ElectoralReport();
            //eReport.GetAllReports();

            //iterator applied
            //ICandidateManagement candidateManagement = new CandidateManagement();
            //var eRep = new ElectoralReporter(candidateManagement);
            //eRep.GenerateAllReports();


            //pre-Strategy
            //CryptoCurrency cryp = new CryptoCurrency();
            //cryp.ConvvertToBitCoin(CryptoCurrency.Currencies.USD, 128);
            //cryp.ConvvertToBitCoin(CryptoCurrency.Currencies.GBP, 128);
            //cryp.ConvvertToBitCoin(CryptoCurrency.Currencies.EUR, 128);

            //Strategy
            //ICryptoStrategy cryptoStrategy = new CurrencyConverter();
            //CryptoContext context = new CryptoContext(cryptoStrategy);
            //context.CryptoInterface("USD", 128, US_RATE);
            //context.CryptoInterface("EUR", 128, EUR_RATE);

            //interface extra
            //void ConvertToEuthereum(string currency, decimal amount, decimal factor);

            //public void ConvertToEuthereum(string currency, decimal amount, decimal factor)
            //{
            //    Console.WriteLine($"{currency} {amount} is {(amount % 3) * factor} in euthereum.");
            //}
            //Context extra
            //public void CryptoEuthereumInterface(string currency, decimal amount, decimal factor)
            //{
            //    strategy.ConvertToEuthereum(currency, amount, factor);
            //}
        }
    }
}
