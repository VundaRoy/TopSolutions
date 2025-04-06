using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.FirewallProxy
{
    public class RealSubject : ISubject
    {
        public void Request(string site)
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
