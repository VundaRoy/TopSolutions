using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MoreInheritance
{
    public class LivingMain
    {
        public static void Main()
        {
            IDwelling myApartment = new Apartment(3, "123 Main St, Apt 4B", 850.0);
            IDwelling myHouse = new House(5, "456 Oak St", 2000.0);
            IDwelling myTownHouse = new TownHouse(4, "789 Pine St", 1500.0);
            GrannyFlat myGrannyFlat = new GrannyFlat(2, "456 Oak St, Granny Flat", 600.0);
            List<IDwelling> dwellings = new List<IDwelling> { myApartment, myHouse, myTownHouse };
            foreach (var dwelling in dwellings)
            {
                dwelling.Enter();
                Console.WriteLine($"Address: {dwelling.GetAddress()}");
                Console.WriteLine($"Number of Rooms: {dwelling.NumberOfRooms}");
                Console.WriteLine($"Area: {dwelling.CalculateArea()} sq ft");
                dwelling.Exit();
                Console.WriteLine();
            }
        }
    }
}
