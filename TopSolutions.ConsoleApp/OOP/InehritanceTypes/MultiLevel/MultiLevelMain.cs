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
            MicrosoftEmployee ms = new()
            {
                FirstName = "Brent",
                LastName = "Sommers",
                Division = "Redmond",
                Role = "Evangelist"
            };
            OracleEmployee oracleEmployee = new()
            {
                FirstName = "Juzman",
                LastName = "Arolla",
                DatabaseVersion = "6.7"
            };
        }
    }
}
