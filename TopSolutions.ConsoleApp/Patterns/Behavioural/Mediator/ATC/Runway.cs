using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.ATC
{
    public class Runway
    {
        public string Id { get; }
        public Runway(string id)
        {
            Id = id;
        }
    }
}
