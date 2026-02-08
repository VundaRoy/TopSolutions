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
            //Get list of Oceania airports
            List<FluentAirport> oceaniaAirports = CreateOceaniaAirports();

            //Display details of each airport
            foreach (var airport in oceaniaAirports)
            {
                airport.ShowDetails();
                Console.WriteLine();
            }
            //Get list of Asia airports 
            List<FluentAirport> asiaAirports = CreateAsiaAirports();
            //Display details of each airport
            foreach (var airport in asiaAirports)
            {
                airport.ShowDetails();
                Console.WriteLine();
            }
        }
        //Create List of Oceania airports
        public static List<FluentAirport> CreateOceaniaAirports()
        {
            List<FluentAirport> oceaniaAirports = new List<FluentAirport>();
            FluentAirport airport1 = new FluentAirport()
                .AirportId("SYD")
                .City("Sydney")
                .Country("Australia")
                .NumberOfRunways(3);
            oceaniaAirports.Add(airport1);
            FluentAirport airport2 = new FluentAirport()
                .AirportId("AKL")
                .City("Auckland")
                .Country("New Zealand")
                .NumberOfRunways(1);
            oceaniaAirports.Add(airport2);
            FluentAirport airport3 = new FluentAirport()
                .AirportId("NOU")
                .City("Noumea")
                .Country("New Caledonia")
                .NumberOfRunways(1);
            oceaniaAirports.Add(airport3);
            FluentAirport airport4 = new FluentAirport()
                .AirportId("POM")
                .City("Port Moresby")
                .Country("Papua New Guinea");

            FluentAirport airport5 = new FluentAirport()
                .AirportId("NAN")
                .City("Nadi")
                .Country("Fiji");
            oceaniaAirports.Add(airport5);
            return oceaniaAirports;

        }
        //Generate list of airports in Asia
        public static List<FluentAirport> CreateAsiaAirports()
        {
            List<FluentAirport> asiaAirports = new List<FluentAirport>();
            FluentAirport airport1 = new FluentAirport()
                .AirportId("DEL")
                .City("Delhi")
                .Country("India")
                .NumberOfRunways(4);
            asiaAirports.Add(airport1);
            FluentAirport airport2 = new FluentAirport()
                .AirportId("BKK")
                .City("Bangkok")
                .Country("Thailand")
                .NumberOfRunways(3);
            asiaAirports.Add(airport2);
            FluentAirport airport3 = new FluentAirport()
                .AirportId("KUL")
                .City("Kuala Lumpur")
                .Country("Malaysia");
            asiaAirports.Add(airport3);
            FluentAirport airport4 = new FluentAirport()
                .AirportId("HKG")
                .City("Hong Kong")
                .Country("China");
            asiaAirports.Add(airport4);
            FluentAirport airport5 = new FluentAirport()
                .AirportId("JKT")
                .City("Jakarta")
                .Country("Indonesia");
            asiaAirports.Add(airport5);
            return asiaAirports;

        }
    }
}
