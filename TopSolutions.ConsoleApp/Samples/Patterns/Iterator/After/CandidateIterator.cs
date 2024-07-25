using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After
{
    public class CandidateIterator : IIterator<Candidate>
    {
        readonly List<Candidate> candidates;
        public CandidateIterator(List<Candidate> candidates) => this.candidates = candidates;
        int position = 0;
        public bool HasNext()
        {
            if (position >= candidates.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Candidate Next()
        {
            Candidate candidate = candidates[position];
            position += 1;
            return candidate;
        }
        public Candidate Previous(int position)
        {
            Candidate candidate = candidates[position];
            if (position > 0)
            { 
              candidate = candidates[--position];            
            }
            return candidate;
        }

        public Candidate Current(int position)
        {
            Candidate candidate = candidates[position];            
            return candidate;
        }
    }
}
