using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Expressions
{
    public class ExpressionsMain
    {
        static void Main(string[] args) 
        {
            Employee employee = new("Yuni", "Ta");
            employee.GetFullName();
        }
    }
}
