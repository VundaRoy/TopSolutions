using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public class HyrbidSUV : IValidateFuel
    {
        public string GetFuelTypeBaseOnVehicleType(string vehicleType)
        {
            if (vehicleType == "SUV")
            {
                return "Premium 98";
            }
            else
            {
                return "Unleaded";
            }
        }
    }
}
