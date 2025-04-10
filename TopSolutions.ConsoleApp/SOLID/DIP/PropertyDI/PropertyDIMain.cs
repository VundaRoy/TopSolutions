using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.PropertyDI
{
    public class PropertyDIMain
    {
        static void Main(string[] args)
        {
            //Create an Instance of Client Class i.e. EmployeeBL 
            EmployeeBL employeeBL = new EmployeeBL();
            //Inject the Dependency Object using the Public Property of the Client Class
            employeeBL.EmployeeDataObject = new EmployeeDAL();
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}
