using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.InehritanceTypes.MultiLevel
{
    public class AmazonContractor : AmazonEmployee
    {
        public DateTime contractFromDate {  get; set; }
        public DateTime contractToDate { get; set; }
        public string contractCompanyId { get; set; }
        public string contractStatus { get; set; }
    }
}
