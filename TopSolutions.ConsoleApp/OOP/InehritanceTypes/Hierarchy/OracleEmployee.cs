using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.InehritanceTypes.MultiLevel;

namespace TopSolutions.ConsoleApp.OOP.InehritanceTypes.Hierarchy
{
    public class OracleEmployee : Person
    {
        public int OracleEmployeeId { get; set; }
        public string RegionalLead {  get; set; }
        public bool IsAdmin { get; set; }
        public string DatabaseVersion { get; set; }
    }
}
