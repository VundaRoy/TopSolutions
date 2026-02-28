using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.ValidateFuel
{
    public class FuelService
    {
        private readonly IValidateFuel _validateFuel;
        public FuelService(IValidateFuel validateFuel)
        {
            _validateFuel = validateFuel;
        }
        public string GetFuelTypeBaseOnVehicleType(string vehicleType)
        {
            return _validateFuel.GetFuelTypeBaseOnVehicleType(vehicleType);
        }
    }
}
