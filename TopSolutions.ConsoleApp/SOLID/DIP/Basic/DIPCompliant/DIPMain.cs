using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class DIPMain
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
            PrintEmployeeDetails(emp);
            
            employeeBusinessLogic.UpdateEmployee(1001, emp);

            Employee staff01 = new Employee { ID = 200, Department = "OP", Name = "Sentinel", Salary = 500000 };
            //emp = employeeBusinessLogic.GetEmployeeDetails(200);
            PrintEmployeeDetails(staff01);
            Console.ReadKey();
        }

        static void PrintEmployeeDetails(Employee emp) 
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }
}
