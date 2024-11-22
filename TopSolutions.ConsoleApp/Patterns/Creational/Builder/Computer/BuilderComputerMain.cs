using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public class BuilderComputerMain
    {
        public static void Main()
        {
            ComputerShop shop = new ComputerShop();
            ComputerBuilder builder = new GamingComputerBuilder();
            shop.ConstructComputer(builder);
            Computer computer = builder.GetComputer();
            computer.DisplaySpecifications();
            Console.ReadKey();
        }
    }
}
