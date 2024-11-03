using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
{
    public class BeRightBack : IDelivery
    {
        public string GetDeliveryDetails()
        {
            return "Be right back - Anywhere";
        }

        public int GetHoursEstimate()
        {
            return 9;
        }

        public int GetPrice()
        {
            return 85;
        }
    }
}
