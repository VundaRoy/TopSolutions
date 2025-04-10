using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.PropertyDI
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
