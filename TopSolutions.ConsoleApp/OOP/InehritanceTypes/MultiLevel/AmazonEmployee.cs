using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.InehritanceTypes.MultiLevel
{
    public class AmazonEmployee : Person
    {
        public int AmazonId { get; set; }
        public string Division { get; set; }
        public bool IsManager { get; set; }
        public string Region {  get; set; }
         
    }
}
