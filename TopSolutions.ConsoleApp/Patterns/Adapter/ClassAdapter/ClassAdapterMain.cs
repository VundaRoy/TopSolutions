using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Adapter.ClassAdapter;

//Client 
//The Client is Incompatible with ThirdPartyBillingSystem 
public class ClassAdapterMain
{
    static void Main(string[] args)
    {
        //Storing the Employees Data in a String Array
        string[,] employeesArray = new string[5, 4]
        {
            {"101","Juan Jaime","SE","10000"},
            {"102","Anabelle Cosgrove","SE","20000"},
            {"103","Satyanand Dev","SSE","30000"},
            {"104","Pamela Oswald","SE","40000"},
            {"105","Sara Maxwell","SSE","50000"}
        };
        //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
        Console.WriteLine("HR system passes employee string array to Adapter\n");
        ITarget target = new EmployeeAdapter();
        target.ProcessCompanySalary(employeesArray);
        Console.Read();
    }
}
