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
            ComputerShop shop = new();
            // One line per configuration
            BuildAndPrint(shop, "Gaming Computer Specifications:", () => new GamingComputerBuilder());
            BuildAndPrint(shop, "Developer Computer Specifications:", () => new DeveloperComputerBuilder());
            BuildAndPrint(shop, "Highschool Computer Specifications:", () => new HighSchoolerComputerBuilder());
        }

        private static Computer BuildAndPrint(ComputerShop shop, string heading, Func<ComputerBuilder> builderFactory)
        {
            Console.WriteLine(heading);

            var builder = builderFactory();
            shop.ConstructComputer(builder);

            var computer = builder.GetComputer();
            computer.DisplaySpecifications();

            // If pausing is desired after each build, uncomment:
            // Console.ReadKey();

            return computer;
        }
    }
}
