using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MoreInheritance
{
    public class TownHouse : IDwelling
    {
        public int NumberOfRooms { get; set; }
        public string Address { get; set; }
        public double Area { get; set; }
        public TownHouse(int numberOfRooms, string address, double area)
        {
            NumberOfRooms = numberOfRooms;
            Address = address;
            Area = area;
        }
        public void Enter()
        {
            Console.WriteLine("Entering the townhouse.");
        }
        public void Exit()
        {
            Console.WriteLine("Exiting the townhouse.");
        }
        public double CalculateArea()
        {
            return Area;
        }
        public string GetAddress()
        {
            return Address;
        }
    }
}
