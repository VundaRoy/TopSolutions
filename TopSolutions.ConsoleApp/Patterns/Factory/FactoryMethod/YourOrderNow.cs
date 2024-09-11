using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Factory.FactoryMethod
{
    public class YourOrderNow : IDelivery
    {
        public string GetDeliveryDetails()
        {
            return "Your order now - Paramatta";
        }

        public int GetHoursEstimate()
        {
            return 7;
        }

        public int GetPrice()
        {
            return 85;
        }
    }
}
