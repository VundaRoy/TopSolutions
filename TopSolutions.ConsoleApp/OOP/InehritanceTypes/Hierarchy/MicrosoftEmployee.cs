using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.InehritanceTypes.MultiLevel;

namespace TopSolutions.ConsoleApp.OOP.InehritanceTypes.Hierarchy
{
    public class MicrosoftEmployee :Person
    {
        public int MicrosoftEmployeeId {  get; set; }
        public string Region { get; set; }
        public string Division { get; set; }
        public string Role {  get; set; }
    }
}
