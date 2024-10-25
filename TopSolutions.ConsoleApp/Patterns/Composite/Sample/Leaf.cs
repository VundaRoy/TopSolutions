using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Composite.Sample
{
    // This is going to be our Leaf class that represents the actual end objects. 
    // A leaf Component can not have any children components.
    // The Leaf object is the Object which does the actual work
    public class Leaf : Component
    {
        //The following Property is going to hold the salary of the Employee
        public int Salary { get; }
        //While creating the Leaf Object,
        //we need to pass the Name and the Salary of the Employee
        //The Employee Name we need to pass to the Base class constructor
        //Initializing the Salary Property using the Constructor
        public Leaf(string Name, int Salary) : base(Name)
        {
            this.Salary = Salary;
        }
        //We need to override the following GetSalary method to provide the actual implementation
        public override int GetSalary()
        {
            //We are Printing the Name and Salary of the Employee and then returning the Salary
            Console.WriteLine($"\t Name: {Name} and Salary: {Salary}");
            return Salary;
        }
    }
}
