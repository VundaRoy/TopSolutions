using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class DIPMain
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new();
            Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
            PrintEmployeeDetails(emp);
            
            employeeBusinessLogic.UpdateEmployee(1001, emp);
            employeeBusinessLogic.NotifyEmployee(1001);
            Employee staff01 = new Employee { ID = 200, Department = "OP", Name = "Sentinel", Salary = 500000 };
            //emp = employeeBusinessLogic.GetEmployeeDetails(200);
            PrintEmployeeDetails(staff01);
            Console.ReadKey();
            //overseas

            Console.WriteLine("Employee from UAE is " + employeeBusinessLogic.ValidateOverseasEmployee("UAE"));
            Console.WriteLine("Employee from UK with pay of $60000 is $" + employeeBusinessLogic.GetOverseasEmployeePay(1001, "UK", 60000.00));
            Console.WriteLine("Whereas employee from Canada with pay of $60000 is $" + employeeBusinessLogic.GetOverseasEmployeePay(1001, "Canada", 60000.00));
            //Register a Barbudan
            employeeBusinessLogic.RegisterStudentWithConsulate(2002, Countries.Barbuda.ToString());
            employeeBusinessLogic.NotifyEmployee(2002);
        }
        
        static void PrintEmployeeDetails(Employee emp) 
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
        public enum Countries
        {
            [Description("Aruba")]
            Aruba = 1,
            [Description("Barbuda")]
            Barbuda = 2,
            [Description("Curacao")]
            Curacao = 3,
            [Description("Grenada")]
            Grenada = 4
        }
    }
}
