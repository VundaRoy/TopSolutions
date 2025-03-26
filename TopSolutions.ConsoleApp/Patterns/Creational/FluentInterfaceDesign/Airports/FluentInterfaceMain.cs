using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.FluentInterfaceDesign.Airports
{
    public class FluentInterfaceMain
    {
        public static void Main(string[] args)
        {
            FluentAirport airport = new FluentAirport();
            airport.AirportId("MAA")
                .City("Chennai")
                .Country("India");
            airport.ShowDetails();
            airport.AirportId("SNG")
                .City("Singapore")
                .Country("Singapore");
            airport.ShowDetails();
        }
    }
}
