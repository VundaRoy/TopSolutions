using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        public EmployeeBusinessLogic()
        {
            _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
        public void UpdateEmployee(int id, Employee employee) 
        { 
            _IEmployeeDataAccessLogic.UpdateEmployee(id, employee);
        }
        public void NotifyEmployee(int id) 
        {  
            _IEmployeeDataAccessLogic.NotifyEmployee(id);
        }
    }
}
