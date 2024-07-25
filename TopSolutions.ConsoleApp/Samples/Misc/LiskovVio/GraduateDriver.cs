using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.LiskovVio
{
    public class GraduateDriver : Driver
    {
        public void LogHours(string driverName, string hours)
        {
            Console.WriteLine(driverName +" drives for " + hours);
        }
    }
}
