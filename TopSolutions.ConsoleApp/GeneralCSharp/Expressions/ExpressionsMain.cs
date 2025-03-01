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
            Employee employee = new("Foren", "Sentu");
            Console.WriteLine(employee.GetFullName());
            employee.DisplayName();
        }
    }
}
