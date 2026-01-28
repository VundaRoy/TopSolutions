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
            BuildAndPrint(() => new IglooHouseBuilder());
            BuildAndPrint(() => new YurtHouseBuilder());
            BuildAndPrint(() => new ChateauMansionBuilder());
        }

        private static House BuildAndPrint(Func<IHouseBuilder> builderFactory)
        {
            var engineer = new CivilEngineer(builderFactory());
            engineer.ConstructHouse();
            var house = engineer.GetHouse();
            Console.WriteLine("House built:\n" + house);
            return house;
        }

    }
}
