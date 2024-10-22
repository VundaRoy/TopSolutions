using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Adapter.Basic
{
    //Client 
    //The Client is Incompatible with ThirdPartyBillingSystem 
    public class AdapterMain
    {
        static void Main(string[] args)
        {
            //Storing the Employees Data in a String Array
            string[,] employeesArray = new string[5, 4]
            {
                {"101","Juan Alvarez","SE","10000"},
                {"102","Anabelle Smith","SE","20000"},
                {"103","Satyanand Dev","SSE","30000"},
                {"104","Pamela Igovich","SE","40000"},
                {"105","Sara Max","SSE","50000"}
            };
            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
