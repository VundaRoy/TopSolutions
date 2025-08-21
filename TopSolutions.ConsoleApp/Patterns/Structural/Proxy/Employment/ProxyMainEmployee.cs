using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Proxy.Employment
{
    public class ProxyMainEmployee
    {
        List<Employee> employees;
        static void Main(string[] args)
        {
            ProxyMainEmployee proxyEmp = new();
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            proxyEmp.CreateEmployees();
            proxyEmp.DetermineRights();
            Console.Read();
        }

        //Create employees
        private List<Employee> CreateEmployees()
        {
            employees = new List<Employee>();
            Employee emp = new("Kanavil", "Urumai", "Developer");
            employees.Add(emp);
            emp = new("Gurukul", "Rishi", "CEO");
            employees.Add(emp);
            emp = new("Manohar", "Rajan", "Manager");
            employees.Add(emp);
            return employees;

        }
        private void DetermineRights()
        {
            for(int i=0; i< employees.Count; i++)
            {
                SharedFolderProxy folder1 = new(employees[i]);
                folder1.PerformRWOperations();
            }
        }


    }
}
