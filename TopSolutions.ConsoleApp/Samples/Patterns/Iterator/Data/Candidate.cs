using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PartyId { get; set; }
        public int ElectorateId { get; set; }
    }
}
