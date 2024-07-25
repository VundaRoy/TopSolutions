using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data
{
    public class GenerateData
    {       
        public List<Candidate> GetCandidates()
        {
            var candidates = new List<Candidate>
            {
                new Candidate { CandidateId = 1, ElectorateId = 1, FirstName = "Ross", LastName = "Wheeler", PartyId = 1 },
                new Candidate { CandidateId = 2, ElectorateId = 1, FirstName = "Brian", LastName = "De Palma", PartyId = 2 },
                new Candidate { CandidateId = 3, ElectorateId = 2, FirstName = "Lewis", LastName = "Clarke", PartyId = 3 },
                new Candidate { CandidateId = 4, ElectorateId = 2, FirstName = "Joyce", LastName = "Anthony", PartyId = 2 },
                new Candidate { CandidateId = 5, ElectorateId = 2, FirstName = "Marcus", LastName = "Cicero", PartyId = 1 },
                new Candidate { CandidateId = 6, ElectorateId = 3, FirstName = "Fouda", LastName = "Baltaghi", PartyId = 1 },
                new Candidate { CandidateId = 7, ElectorateId = 3, FirstName = "Luis", LastName = "Borges", PartyId = 2 },
                new Candidate { CandidateId = 8, ElectorateId = 3, FirstName = "Miguel", LastName = "Cervantes", PartyId = 2 },
                new Candidate { CandidateId = 9, ElectorateId = 4, FirstName = "SP", LastName = "Bala", PartyId = 2 },
                new Candidate { CandidateId = 10, ElectorateId = 5, FirstName = "Henri", LastName = "Balzac", PartyId = 2 },
                new Candidate { CandidateId = 11, ElectorateId = 6, FirstName = "Johann", LastName = "Goethe", PartyId = 2 }
            };

            return candidates;
        }
        public List<Electorate> GetElectorates()
        {
            var electorates = new List<Electorate>
            {
                new Electorate { ElectorateId = 1, Name = "Capricornia", RegisteredVoters = 22100, State = "QLD" },
                new Electorate { ElectorateId = 2, Name = "Kennedy", RegisteredVoters = 28100, State = "QLD" },
                new Electorate { ElectorateId = 3, Name = "Herbert", RegisteredVoters = 20900, State = "QLD" },
                new Electorate { ElectorateId = 4, Name = "Barton", RegisteredVoters = 35100, State = "NSW" },
                new Electorate { ElectorateId = 5, Name = "Banks", RegisteredVoters = 30100, State = "NSW" },
                new Electorate { ElectorateId = 6, Name = "Cooper", RegisteredVoters = 29600, State = "VIC" },
                new Electorate { ElectorateId = 7, Name = "Hawke", RegisteredVoters = 34100, State = "VIC" }
            };

            return electorates;
        }
        public List<Party> GetParties()
        {
            var parties = new List<Party>
            {
                new Party { PartyId = 1, Name = "Labour Party", Abbreviation = "ALP" },
                new Party { PartyId = 2, Name = "Liberal Party", Abbreviation = "LP" },
                new Party { PartyId = 3, Name = "Green Party", Abbreviation = "Greens" },
                new Party { PartyId = 4, Name = "National Party", Abbreviation = "NP" },
                new Party { PartyId = 5, Name = "Tea Party", Abbreviation = "TP" }
            };
            return parties;
        }
    }
}
