using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.ReferenceType
{
    public class MainReferenceType
    {
        public static void Main()
        {
            // Reference types example
            Employee emp1 = new ("John");
            Employee emp2 = emp1; // Both variables reference the same object
            Console.WriteLine("Reference type sample");
            Console.WriteLine($"Before modification: person1.Name = {emp1.Name}, person2.Name = {emp2.Name}");
            emp2.Name = "Doe"; // Modifying the object through person2
            Console.WriteLine($"After modification: person1.Name = {emp1.Name}, person2.Name = {emp2.Name}");
            //Value types example
            Console.WriteLine("Value type sample");
            int x = 10;
            int y = x; // y gets a copy of the value of x
            Console.WriteLine($"Before modification: x = {x}, y = {y}");
        }

        public class Employee
        {
            public string Name { get; set; }
            public Employee(string name)
            {
                Name = name;
            }
        }
    }
}
