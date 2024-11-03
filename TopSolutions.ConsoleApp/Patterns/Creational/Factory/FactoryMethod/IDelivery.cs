using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryMethod
{
    public interface IDelivery
    {
        string GetDeliveryDetails();
        int GetPrice();
        int GetHoursEstimate();
    }
}
