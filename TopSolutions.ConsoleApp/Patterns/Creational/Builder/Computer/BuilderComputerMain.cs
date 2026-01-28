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
            GamerComputer(shop);
            DeveloperComputer(shop);
            HighSchoolComputer(shop);

        }

        private static void HighSchoolComputer(ComputerShop shop)
        {
            //Highschool computer
            Console.WriteLine("Highschool Computer Specifications:");
            ComputerBuilder hsPC = new HighSchoolerComputerBuilder();
            shop.ConstructComputer(hsPC);
            Computer comp3 = hsPC.GetComputer();
            comp3.DisplaySpecifications();
            Console.ReadKey();
        }

        private static void DeveloperComputer(ComputerShop shop)
        {
            //Developer computer
            Console.WriteLine("Developer Computer Specifications:");
            ComputerBuilder devPC = new DeveloperComputerBuilder();
            shop.ConstructComputer(devPC);
            Computer comp2 = devPC.GetComputer();
            comp2.DisplaySpecifications();
            Console.ReadKey();
        }

        private static void GamerComputer(ComputerShop shop)
        {
            //Gaming computer
            Console.WriteLine("Gaming Computer Specifications:");
            ComputerBuilder builder = new GamingComputerBuilder();
            shop.ConstructComputer(builder);
            Computer computer = builder.GetComputer();
            computer.DisplaySpecifications();
        }
    }
}
