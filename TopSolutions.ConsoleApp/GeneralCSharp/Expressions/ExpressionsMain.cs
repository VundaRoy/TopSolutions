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
            Employee employee = new("Nuvvu", "IlaaCheyali");
            Console.WriteLine(employee.GetFullName());
            employee.DisplayName();
            Console.WriteLine($"The first name has {employee.GetFirstNameLength()} characters");
            Console.WriteLine($"The last name has {employee.GetLastNameLength()} characters");
        }
    }
}
