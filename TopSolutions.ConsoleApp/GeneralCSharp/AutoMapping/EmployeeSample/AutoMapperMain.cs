using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.AutoMapping.EmployeeSample
{
    public class AutoMapperMain
    {
        public static void Main()
        {
            //create and populate employee object
            AutoMapperMain aum = new AutoMapperMain();
            Employee employee = aum.CreateEmployee("John Doe", 50000, "123 Main St", "IT");
            Employee employee2 = aum.CreateEmployee("Jane Smith", 60000, "456 Oak Ave", "HR");
            Employee employee3 = aum.CreateEmployee("Mike Johnson", 55000, "789 Pine Rd", "Finance");

            //initialize automapper

            MapToDTO(employee);
            MapToDTO(employee3);
            MapToDTO(employee2);

        }

        private static void MapToDTO(Employee employee)
        {
            var mapper = MapperConfig.InitializeAutomapper();
            var empDTO1 = mapper.Map<EmployeeDTO>(employee);
            var empDTO2 = mapper.Map<Employee, EmployeeDTO>(employee);
            Console.WriteLine("Name: " + empDTO1.Name + ", Salary: " + empDTO1.Salary +
                ", Address: " + empDTO1.Address + ", Department: " + empDTO1.Department);
            //Get empDTO2 details
            Console.WriteLine("Name: " + empDTO2.Name + ", Salary: " + empDTO2.Salary +
                ", Address: " + empDTO2.Address + ", Department: " + empDTO2.Department);
            Console.ReadLine();
        }

        public Employee CreateEmployee(string name, int salary, string address, string department)
        {
            return new Employee()
            {
                Name = name,
                Salary = salary,
                Address = address,
                Department = department
            };

        }
        
    }
}
