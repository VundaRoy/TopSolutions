using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.ATC
{
    //A mediator class that manages the communication between airplanes and runways.
    //It keeps track of available runways and grants landing permissions to airplanes based on runway availability.
    public class ControlTower : IControlTower
    {
        private List<Runway> _availableRunways = new();
        public void RegisterRunway(Runway runway)
        {
            _availableRunways.Add(runway);
        }
        public bool RequestLandingPermission(Airplane airplane) // This method checks if there are any available runways and assigns one to the airplane if possible.
        {
            if (_availableRunways.Any())
            {
                var assignedRunway = _availableRunways.First();
                _availableRunways.Remove(assignedRunway);
                airplane.AssignRunway(assignedRunway);
                return true;
            }
            return false; // No available runways
        }
        public void ReleaseRunway(Runway runway)
        {
            _availableRunways.Add(runway);
        }
    }
}
