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
            WhateverCar(ford);
            //BMW
            ICar bmw = new BMW();
            WhateverCar(bmw);
            //Audi
            ICar audi = new Audi();
            WhateverCar(audi);
            //ford again
            WhateverCar(ford);
        }

        private static void WhateverCar(ICar whatever)
        {
            Driver driver = new(whatever);
            driver.RunCar();
        }
    }
}
