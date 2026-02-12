using System;
using System.Collections.Generic;
using System.Linq;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Sample
{
    public class CompositeClientMain
    {
        static void Main(string[] args)
        {
            // --- Seed data (concise, data-driven) ---
            var employees = new[]
            {
                Emp("Pranaya",  "12 Anderi West Mumbai",         22000),
                Emp("Rohit",    "2F 223 Manikkar rd North Bhiwandi", 33000),
                Emp("Anurag",   "1112/23 Jyothish str East Pune", 42000),
                Emp("Priyanka", "Haridwar city",                  52000),
                Emp("Sambit",   "RB Patel stadium",               28000),
                Emp("Kausalya", "Secundarabad road Hyderabad",    58000),
                Emp("Karthik",  "Jhanvi street Chennai",          48000),
                Emp("Govardhan","Tumkur district Karnataka",      41000),
                Emp("Ravi",     "Gulbarga district Karnataka",    35000),
                Emp("Suresh",   "Mandya district Karnataka",    32000),
                Emp("Gopichand", "Mysore district Karnataka",    30000)
            };

            // Helper lookups
            Component E(string name) => employees.First(e => e.Name == name);

            // --- Build composites via small factory helpers ---
            var itDepartment = Dept("ITDepartment", "New Ward South",
                                      E("Pranaya"), E("Rohit"), E("Anurag"), E("Gopichand"), E("Suresh"));

            var hrDepartment = Dept("HRDepartment", "Raiwind East",
                                      E("Priyanka"), E("Sambit"), E("Ravi"));

            var directors = Dept("Directors", "Gulbarga",
                                      E("Kausalya"), E("Karthik"), E("Govardhan"));

            var company = Dept("Company", "Central Zone",
                                      itDepartment, hrDepartment, directors);

            // --- Presentation / Output (kept separate from composition) ---
            Console.WriteLine("All Employees of the Company");
            Console.WriteLine($"Total Salary of the Company: {company.GetSalary()}");

            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {itDepartment.GetSalary()}");

            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {hrDepartment.GetSalary()}");

            Console.WriteLine("\nDirectors of company");
            Console.WriteLine($"Total Salary of Directors: {directors.GetSalary()}");

            Console.WriteLine("\nSalary of Employee Pranaya:");
            Console.WriteLine(E("Pranaya").GetSalary());

            Console.WriteLine("\nSalary of Employee Anurag:");
            Console.WriteLine(E("Anurag").GetSalary());

            Console.Read();
        }

        // --- Local helpers / factories ---
        static Leaf Emp(string name, string address, int salary) =>
            new (name, address, salary);

        static Composite Dept(string name, string location, params Component[] children)
        {
            var dept = new Composite(name, location);
            dept.AddComponent(children); // params-based add
            return dept;
        }
    }
}
