using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After
{
    public class ElectoralReporter
    {
        private readonly ICandidateManagement candidate;
        public ElectoralReporter(ICandidateManagement candidate)
        {
            this.candidate = candidate;
        }
        public void GenerateAllReports()
        {
            IIterator<Candidate> candidateIterator = candidate.CreateIterator();
            Console.WriteLine("===== Candidates List ======");
            PrintCandidates(candidateIterator);

        }
        public void PrintCandidates(IIterator<Candidate> iterator)
        {
            while (iterator.HasNext())
            {
                Candidate candidate = iterator.Next();
                Console.WriteLine($"{candidate.FirstName} {candidate.LastName}");
               
               
                Console.WriteLine();
            }
        }
       
        public void GetPreviousCandidate( int candidateId)
        {
            IIterator<Candidate> candidateIterator = candidate.CreateIterator();
            var currentCandidate = candidateIterator.Current(candidateId);
            var candidatePrev = candidateIterator.Previous(candidateId);
            Console.WriteLine($"The candidate before {currentCandidate.FirstName} {currentCandidate.LastName} is: {candidatePrev.FirstName} {candidatePrev.LastName}");
            
        }
    }
}
