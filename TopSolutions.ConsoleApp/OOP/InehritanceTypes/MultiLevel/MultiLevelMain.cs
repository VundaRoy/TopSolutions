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
            List<MicrosoftEmployee> microEmployees = new();
            MultiLevelMain multiLevelMain = new();
            _ = new AmazonContractor()
            {
                IsManager = true,
                AmazonId = 12,
                Age = 28,
                contractCompanyId = "89-Metro",
                FirstName = "Terence",
                LastName = "Hill",
            };
            _ = new AmazonEmployee()
            {
                IsManager = false,
                FirstName = "Bob",
                LastName = "Dole",
                Age = 28,
            };

            //using hierarchy
            AmazonEmployee ae = multiLevelMain.CreateAmazonEmployee("Chaim", "Wently", false, "Rochester");
            Console.WriteLine($"Amazonian {ae.FirstName} is from division {ae.Division}"); 
            MicrosoftEmployee ms = multiLevelMain.CreateMicrosoftEmployee("Lewis","Clark","East Coast","Tech writer", 45);
            microEmployees.Add(ms);
            ms = multiLevelMain.CreateMicrosoftEmployee("Manitoba", "Prairie", "Central", "Engineer", 34);
            microEmployees.Add(ms);
            ms = multiLevelMain.CreateMicrosoftEmployee("Halifax", "Nova", "Acadia", "Senior Engineer", 35);
            microEmployees.Add(ms);
            foreach (MicrosoftEmployee employee in microEmployees)
            {
                Console.WriteLine($"{employee.FirstName}");
            }
            OracleEmployee ora1 = multiLevelMain.CreateOracleEmployee("Carlos", "Guzman", "5.7", 30);
            Console.WriteLine($"Oracle employee {ora1.FirstName} is aged {ora1.Age}");
           
        }

        OracleEmployee CreateOracleEmployee(string first, string last, string version, int age)
        {
            return new() { FirstName = first, LastName = last, DatabaseVersion = version, Age = age  };
        }
        MicrosoftEmployee CreateMicrosoftEmployee(string first, string last, string division, string role, int age) 
        { 
            return new() { FirstName = first, LastName = last, Division = division, Role = role, Age = age}; 
        }
        AmazonEmployee CreateAmazonEmployee(string first, string division, bool isManager, string region)
        {
            return new() { FirstName = first, Division = division, IsManager  = isManager, Region = region };
        }
        
    }
}
