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
            //Prototype Pattern Demonstration
            var contractorStruct = new EmployeeStruct()
            {
                Name = "John",
                Department = "Finance",
                Type = "Contract",
                Wage = 15000
            };
            var contractor = GetEmployee(contractorStruct.Type, contractorStruct);
            contractor.ShowDetails();

            var permanentStruct = new EmployeeStruct()
            {
                Name = "Alice",
                Department = "IT",
                Type = "Permanent",
                Salary = 120000
            };
            var permanent = GetEmployee(permanentStruct.Type, permanentStruct);
            permanent.ShowDetails();

            var temporaryStruct = new EmployeeStruct()
            {
                Name = "Bob",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 80000
            };
            var temporary = GetEmployee(temporaryStruct.Type, temporaryStruct);
            temporary.ShowDetails();
            Console.WriteLine("--------------------------------------------------");

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

        //Create Employee based on Employee type passed in parameter
        public static Employee GetEmployee(string empType, EmployeeStruct employeeStruct)
        {
            switch (empType)
            {
                case "Permanent":
                    return new PermanentEmployee() { Department = employeeStruct.Department, Name = employeeStruct.Name, Salary = employeeStruct.Salary};
                case "Temporary":
                    return new TemporaryEmployee() { Department = employeeStruct.Department, Name = employeeStruct.Name, FixedAmount = employeeStruct.FixedAmount};
                case "Contract":
                    return new ContractEmployee() { Department = employeeStruct.Department, Name = employeeStruct.Name, Wage = employeeStruct.Wage};
                default:
                    throw new ArgumentException("Invalid employee type");
            }
        }
        public struct EmployeeStruct
        {
            public string Name;
            public string Department;
            public string Type;
            public int Salary;
            public int FixedAmount;
            public int Wage;
        }
    }
}
