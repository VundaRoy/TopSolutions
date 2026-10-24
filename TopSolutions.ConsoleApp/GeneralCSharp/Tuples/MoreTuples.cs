using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Tuples
{
    internal class MoreTuples
    {
        public static void Main(string[] args)
        {
            // Creating a tuple with named elements
            var person = (Name: "John Doe", Age: 30, Country: "USA");
            // Accessing tuple elements by name
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Country: {person.Country}");
            // Creating a tuple with unnamed elements
            var coordinates = (10, 20);
            // Accessing tuple elements by position
            Console.WriteLine($"X: {coordinates.Item1}, Y: {coordinates.Item2}");
            // Deconstructing a tuple into separate variables
            var (x, y) = coordinates;
            Console.WriteLine($"Deconstructed X: {x}, Y: {y}");
            //Get salary information using a method that returns a tuple
            MoreTuples moreTuples = new MoreTuples();
            var salaryInfo = moreTuples.GetSalaryInfo(12345);
            Console.WriteLine($"Employee ID: {salaryInfo.Item1}, Salary: {salaryInfo.Item2}, Currency: {salaryInfo.Item3}");
        }
        private Tuple<int, double, string> GetSalaryInfo(int employeeId)
        {
            double salary = 75000.50;
            string currency = "USD";
            return Tuple.Create(employeeId, salary, currency);
        }
    }
}
