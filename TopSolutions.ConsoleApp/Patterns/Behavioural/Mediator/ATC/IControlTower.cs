using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.ATC
{
    public interface IControlTower
    {
        void RegisterRunway(Runway runway);
        bool RequestLandingPermission(Airplane airplane);
        void ReleaseRunway(Runway runway);
    }
}
