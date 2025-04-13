using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.AbstractFactory
{
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}
