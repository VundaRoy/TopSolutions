using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad.FurtherLazyLoading
{
    public class Candidate
    {
        public string CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PoliticalParty { get; set; }
    }
}
