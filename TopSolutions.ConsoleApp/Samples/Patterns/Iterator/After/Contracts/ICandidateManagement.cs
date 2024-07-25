using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts
{
    public interface ICandidateManagement
    {
        void AddCandidate(int candidateId, int electorateId, string firstName, string lastName, int partyId);
        IIterator<Candidate> CreateIterator();
    }
}