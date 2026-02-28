using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public interface IValidateFuel
    {
        public string GetFuelTypeBaseOnVehicleType(string vehicleType);
    }
}
