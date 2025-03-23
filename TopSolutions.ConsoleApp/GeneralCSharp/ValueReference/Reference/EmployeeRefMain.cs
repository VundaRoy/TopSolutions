using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.ValueReference.Reference
{
    public class Employee
    {
        public string Name { get; set; }
    }
    public class EmployeeRefMain
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Sergio";
            Employee emp2 = new Employee();
            emp2 = emp;
            emp2.Name = "Milo";

            Console.WriteLine($"emp is {emp.Name}");
            Console.WriteLine($"emp2 is {emp2.Name}");

        }
    }
}
