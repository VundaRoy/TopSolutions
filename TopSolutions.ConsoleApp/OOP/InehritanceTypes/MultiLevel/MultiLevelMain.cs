using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.InehritanceTypes.Hierarchy;

namespace TopSolutions.ConsoleApp.OOP.InehritanceTypes.MultiLevel
{
    public class MultiLevelMain
    {
        static void Main(string[] args)
        {
            List<MicrosoftEmployee> microEmployees = new List<MicrosoftEmployee>();
            MultiLevelMain multiLevelMain = new MultiLevelMain();
            AmazonContractor amazonContractor = new()
            {
                IsManager = true,
                AmazonId = 12,
                Age = 28,
                contractCompanyId = "89-Metro",
                FirstName = "Terence",
                LastName = "Hill",
            };
            AmazonEmployee basicTemplateEmployee = new()
            {
                IsManager = false,
                FirstName = "Bob",
                LastName = "Dole"
            };
            //using hierarchy
            MicrosoftEmployee ms = multiLevelMain.CreateMicrosoftEmployee("Lewis","Clark","East Coast","Tech writer");
            microEmployees.Add(ms);
            ms = multiLevelMain.CreateMicrosoftEmployee("Manitoba", "Prairie", "Central", "Engineer");
            microEmployees.Add(ms);
            ms = multiLevelMain.CreateMicrosoftEmployee("Halifax", "Nova", "Acadia", "Senior Engineer");
            microEmployees.Add(ms);
            foreach (MicrosoftEmployee employee in microEmployees)
            {
                Console.WriteLine($"{employee.FirstName}");
            }
            OracleEmployee ora1 = multiLevelMain.CreateOracleEmployee("Carlos", "Guzman", "5.7");

           
        }

        OracleEmployee CreateOracleEmployee(string first, string last, string version)
        {
            return new() { FirstName = first, LastName = last, DatabaseVersion = version };
        }
        MicrosoftEmployee CreateMicrosoftEmployee(string first, string last, string division, string role) 
        { 
            return new() { FirstName = first, LastName = last, Division = division, Role = role }; 
        }
        
    }
}
