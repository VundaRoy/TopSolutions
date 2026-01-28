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
            //build Igloo
            CivilEngineer engineer;
            House house;
            IglooBuilder(out engineer, out house);
            //build Yurt
            YurtBuilder(out engineer, out house);
            //build Chateau Mansion
            ChateauMansionBuilder(out engineer, out house);

        }

        private static void ChateauMansionBuilder(out CivilEngineer engineer, out House house)
        {
            IHouseBuilder chateauBuilder = new ChateauMansionBuilder();
            engineer = new CivilEngineer(chateauBuilder);
            engineer.ConstructHouse();
            house = engineer.GetHouse();
            Console.WriteLine("House built:\n" + house);
        }

        private static void YurtBuilder(out CivilEngineer engineer, out House house)
        {
            IHouseBuilder yurtBuilder = new YurtHouseBuilder();
            engineer = new CivilEngineer(yurtBuilder);
            engineer.ConstructHouse();
            house = engineer.GetHouse();
            Console.WriteLine("House built:\n" + house);
        }

        private static void IglooBuilder(out CivilEngineer engineer, out House house)
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            engineer = new CivilEngineer(iglooBuilder);
            engineer.ConstructHouse();
            house = engineer.GetHouse();
            Console.WriteLine("House built:\n" + house);
        }
    }
}
