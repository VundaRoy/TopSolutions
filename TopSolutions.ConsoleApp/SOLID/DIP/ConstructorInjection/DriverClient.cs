using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.ConstructorInjection
{
    public class DriverClient
    {
        public static void Main(string[] args)
        {
            ICar ford = new Ford();
            Driver driver = new Driver(ford);
            driver.RunCar();
        }
    }
}
