using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.AbstractFactory
{
    public class LuxuryVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            throw new NotImplementedException();
        }

        public ICar CreateCar()
        {
            return new LuxuryCar();
        }
    }
}
