using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.PropertyDI
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        //Injecting the Dependency Object using Public Property
        public IEmployeeDAL EmployeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}
