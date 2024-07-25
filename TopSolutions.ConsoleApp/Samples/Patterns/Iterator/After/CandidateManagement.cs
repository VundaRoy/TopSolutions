using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After
{
    public class CandidateManagement : ICandidateManagement
    {
        private readonly List<Candidate> candidates;
        public CandidateManagement()
        {
            candidates = new List<Candidate>
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

        }
        public void AddCandidate(int candidateId, int electorateId, string firstName, string lastName, int partyId)
        {
            Candidate candidate = new Candidate { CandidateId = candidateId, ElectorateId = electorateId, FirstName = firstName, LastName = lastName, PartyId = partyId };
            this.candidates.Add(candidate);
        }
        public IIterator<Candidate> CreateIterator()
        {
            return new CandidateIterator(candidates);
        }
    }
}
