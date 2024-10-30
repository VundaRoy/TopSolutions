using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Mediator.ATC
{
    public class Airplane
    {
        private readonly IControlTower _controlTower;
        public string FlightNumber { get; }
        public Airplane(string flightNumber, IControlTower controlTower)
        {
            FlightNumber = flightNumber;
            _controlTower = controlTower;
        }
        public void RequestLanding()
        {
            if (_controlTower.RequestLandingPermission(this))
            {
                Console.WriteLine($"Airplane {FlightNumber} is landing.");
            }
            else
            {
                Console.WriteLine($"Airplane {FlightNumber} is waiting for an available runway.");
            }
        }
        public void AssignRunway(Runway runway)
        {
            Console.WriteLine($"Airplane {FlightNumber} assigned to runway {runway.Id}.");
        }
    }
}
