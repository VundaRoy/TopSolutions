using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.House
{
    public class HouseMain
    {
        public static void Main()
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);
            engineer.ConstructHouse();
            House house = engineer.GetHouse();
            Console.WriteLine("House built:\n" + house);
        }
    }
}
