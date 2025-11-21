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
            Employee employee = new Employee()
            {
                Name = "John Doe",
                Salary = 50000,
                Address = "123 Main St, Anytown, USA",
                Department = "IT"
            };
            var mapper = MapperConfig.InitializeAutomapper();
            var empDTO1 = mapper.Map<EmployeeDTO>(employee);
            var empDTO2 = mapper.Map<Employee, EmployeeDTO>(employee);
            Console.WriteLine("Name: " + empDTO1.Name + ", Salary: " + empDTO1.Salary +
                ", Address: " + empDTO1.Address + ", Department: " + empDTO1.Department);
            Console.ReadLine();


        }
    }
}
