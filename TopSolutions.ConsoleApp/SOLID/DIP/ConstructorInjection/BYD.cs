using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.SOLID.DIP.ConstructorInjection
{
    internal class BYD : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
}
