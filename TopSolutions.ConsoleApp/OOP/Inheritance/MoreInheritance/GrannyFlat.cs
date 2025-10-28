using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MoreInheritance
{
    public class GrannyFlat : House
    {
        public GrannyFlat(int numberOfRooms, string address, double area)
            : base(numberOfRooms, address, area)
        {
        }
        public void HostGrandchildren()
        {
            Console.WriteLine("Hosting grandchildren in the granny flat.");
        }
    }
}
