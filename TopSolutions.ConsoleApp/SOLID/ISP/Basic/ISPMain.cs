using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public class ISPMain
    {
        public static void Main(string[] args)
        {
            ExtendedOffice extendedOffice = new ExtendedOffice();
            Console.WriteLine(extendedOffice.CheckDispenser(2));
            Violator violator = new Violator();
            violator.Submit("killjoy");  // not implemented violation

        }
    }
}
