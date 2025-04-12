using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.House
{
    public class TemplateHouseMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type : g = green, c = concrete, w = wooden");
            string houseType = Console.ReadLine();
            DetermineHouseType(houseType);
        }

        static void DetermineHouseType(string houseType)
        {
            HouseTemplate houseTemplate;
            switch (houseType)
            {
                case "w":
                    houseTemplate = new WoodenHouse();
                    houseTemplate.BuildHouse();
                    break;
                case "g":
                    houseTemplate = new GreenHouse();
                    houseTemplate.BuildHouse();
                    break;
                case "c":
                    houseTemplate = new ConcreteHouse();
                    houseTemplate.BuildHouse();
                    break;
            }


        }
    }
}
