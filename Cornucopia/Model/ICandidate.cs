namespace Cornucopia.Model
{
    public interface ICandidate
    {
        int CandidateId { get; }
        string FirstName { get; }
        string LastName { get; }
        int PartyId { get; }

    }
}
