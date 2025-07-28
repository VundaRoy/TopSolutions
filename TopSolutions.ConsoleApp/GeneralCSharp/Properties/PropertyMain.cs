using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Properties
{
    public class PropertyMain
    {
        public static void Main(string[] args)
        {
            Candidate candidate = new Candidate
            {
                CandidateId = 1,
                CandidateName = "Forbes",
                Age = 31,
                PoliticalParty = "Dem"
            };
            Console.WriteLine($"Candidate {candidate.CandidateId} is runner for {candidate.PoliticalParty}");

        }
    }
}
