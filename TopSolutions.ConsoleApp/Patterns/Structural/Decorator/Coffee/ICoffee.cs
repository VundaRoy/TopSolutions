using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Decorator.Coffee
{
    public interface ICoffee
    {
        string getDescription();
        double getCost();
    }
}
