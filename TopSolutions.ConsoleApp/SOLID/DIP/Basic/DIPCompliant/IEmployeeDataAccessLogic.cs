using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
        void UpdateEmployee(int id, Employee employee);
        void NotifyEmployee(int id);
    }
}
