using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad.FurtherLazyLoading
{
    public class RegisterCandidate
    {
        // Lazy loading implementation
        private static readonly Lazy<RegisterCandidate> _instance =
            new Lazy<RegisterCandidate>(() => new RegisterCandidate());
        private RegisterCandidate() {
            // Private constructor to prevent instantiation
            //create Candidate
            Candidate candidate = new Candidate
            {
                CandidateID = "CAND123",
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1980, 5, 15),
                PoliticalParty = "Independent"
            };
            // Simulate registration process
            Console.WriteLine($"Candidate {candidate.FirstName} {candidate.LastName} registered successfully.");

        }
        public static RegisterCandidate Instance
        {
            get
            {
                return _instance.Value;  // Return the singleton instance
            }
        }
    }
}
