using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.FluentInterfaceDesign.Airports
{
    public class FluentAirport
    {
        private Airport airport = new();
        public FluentAirport AirportId(string airportId)
        {
            airport.AirportId = airportId;
            return this;
        }
        public FluentAirport City(string city)
        {
            airport.City = city;
            return this;
        }
        public FluentAirport Country(string country)
        {
            airport.Country = country;
            return this;
        }
        public FluentAirport NumberOfRunways(int numberOfRunways)
        {
            airport.NumberOfRunways = numberOfRunways;
            return this;
        }
        public void ShowDetails()
        {

            Console.WriteLine(
                $"Airport ID: {airport.AirportId}, \n" +
                $"City: {airport.City}\n" +
                $"Country: {airport.Country}\n" +
                $"Number of Runways: {(airport.NumberOfRunways == 0 ? "no data" : airport.NumberOfRunways.ToString())}"
            );

        }
    }
}
