using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.AbstractFactory
{
    public interface ICar
    {
        // The 'AbstractProductB' interface
        // Each distinct product of the Car product family should have a base interface.
        // All variants of the Car products must implement this ICar interface.
        void GetDetails();
    }
}
