using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Prototype
{
    public class PrototypeClientMain
    {
        static void Main(string[] args)
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();
            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };
            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            //Create clone of temp emp4
            Employee con1 = emp4.GetClone();
            con1.Name = "Shardu";
            con1.Department = "Network";
            //emp4.ShowDetails();
            con1.ShowDetails();
            //Create contract
            Employee con2 = new ContractEmployee()
            {
                Name = "Bosque",
                Department = "New Projects",
                Type = "Contract",
                Wage = 12200

            };
            con2.ShowDetails();


            Console.Read();
        }
    }
}
