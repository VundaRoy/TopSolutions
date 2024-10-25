using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Composite.Sample
{
    public class CompositeClientMain
    {
        static void Main(string[] args)
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. Component.
            // Component means the class that implements the Component abstract class
            // In our example Leaf and Composite classes implement the Component abstract class
            //Creating Leaf Objects or you can say child objects
            Component Pranaya = new Leaf("Pranaya", 22000);
            Component Rohit = new Leaf("Rohit", 33000);
            Component Anurag = new Leaf("Anurag", 42000);
            Component Priyanka = new Leaf("Priyanka", 52000);
            Component Sambit = new Leaf("Sambit", 28000);
            Component Kausalya = new Leaf("Kausalya", 58000);
            Component Karthik = new Leaf("Karthik", 48000);
            Component Govardhan = new Leaf("Govardhan", 41000);
            //Creating Composite Objects
            Composite ITDepartment = new Composite("ITDepartment");
            Composite HRDepartment = new Composite("HRDepartment");
            Composite Directors = new Composite("Directors");
            Composite Company = new Composite("Company");
            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding Pranaya, Rohit, and Anurag to ITDepartment Composite Object
            ITDepartment.AddComponent(Pranaya);
            ITDepartment.AddComponent(Rohit);
            ITDepartment.AddComponent(Anurag);
            //Adding Priyanka and Sambit in HRDepartment Composite Object
            HRDepartment.AddComponent(Priyanka);
            HRDepartment.AddComponent(Sambit);
            //Adding ITDepartment and HRDepartment inside Company Composite Object
            Directors.AddComponent(Kausalya);
            Directors.AddComponent(Karthik);
            Directors.AddComponent(Govardhan);

            Company.AddComponent(ITDepartment);
            Company.AddComponent(HRDepartment);
            Company.AddComponent(Directors);
            Console.WriteLine("All Employees of the Company");
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine($"Total Salary of the Company: {Company.GetSalary()}");
            //To display Salaries and Employees of the IT Department
            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {ITDepartment.GetSalary()}");
            //To display Salaries and Employees of the HR Department
            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetSalary()}");
            //Directors
            Console.WriteLine("\nDirectors of company");
            Console.WriteLine($"Total Salary of Directors: {Directors.GetSalary()}");
            //To display Salaries and Employees of HR Department
            Console.WriteLine("\nSalary of Employee Pranaya:");
            Pranaya.GetSalary();
            Console.WriteLine($"\nSalary of Employee Anurag: ");
            Anurag.GetSalary();
            Console.Read();
        }
    }
}
