using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Sample
{
    // The Base Component Abstract class declares the common operations for both Leaf and Composite objects.
    public abstract class Component
    {
        //This Property is used to store the Component Name
        public string Name { get; }
        public string Address { get; }

        //Initializing the Name Property using Class Parameterized Constructor
        public Component(string name, string address)
        {
            Name = name;
            Address = address;
        }
        //The following GetSalary method is going to be overridden in both Leaf and Composite classes
        public abstract int GetSalary();
    }
}
