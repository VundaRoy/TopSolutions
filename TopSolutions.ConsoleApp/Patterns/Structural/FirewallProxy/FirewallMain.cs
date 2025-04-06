using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.FirewallProxy
{
    public class FirewallMain
    {
        public static void Main(string[] args)
        {
            ISubject proxy = new FirewallProxy();
            Console.WriteLine("Enter site : ");
            var site = Console.ReadLine();
            proxy.Request(site); 
            Console.ReadKey();
        }
    }
}
