using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant.Contract;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class EmployeeDataAccessLogic : IEmployeeDataAccessLogic, IEmployeeOverseas
    {
        public bool ForeignValidation(string country)
        {
            if (country == "UK" || country =="Canada")
            {
                return true;
            }
            return false;
        }

        public Employee GetEmployeeDetails(int id)
        {
            //In real time get the employee details from database
            //but here we have hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }

        public void NotifyEmployee(int id)
        {
            Console.WriteLine("Sent to employee " + id);
        }

        public double ProcessForeignPay(int EmployeeID, string country, double pay)
        {
            if (country == "UK")
                return pay * 1.5;
            else
                return pay * 1.2;
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            Console.WriteLine("The updated employee with id of " + id + " has a name of " +employee.Name);
        }
    }
}
