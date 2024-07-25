namespace Cornucopia.Model
{
    public class Candidate : ICandidate

    {
        public int CandidateId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PartyId { get; set; }

        
    }
}
