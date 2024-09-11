using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod
{
    public class PackAndSend : IDelivery
    {
        public string GetDeliveryDetails()
        {
            return "Pack and Send - Burwood";
        }

        public int GetHoursEstimate()
        {
            return 10;
        }

        public int GetPrice()
        {
            return 95;
        }
    }
}
