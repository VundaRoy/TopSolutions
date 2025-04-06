using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.FirewallProxy
{
    public interface ISubject
    {
        void Request(string site);
    }
}
