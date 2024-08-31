using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant.Contract;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
        public static IEmployeeOverseas GetEmployeeOverseasObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
