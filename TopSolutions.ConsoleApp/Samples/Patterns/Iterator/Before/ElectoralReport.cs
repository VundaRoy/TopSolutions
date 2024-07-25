using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Data;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Iterator.Before
{
    public  class ElectoralReport
    {
        GenerateData genData;
        public ElectoralReport()
        {
            genData = new GenerateData();
        }

        public void GetAllReports()
        {
            
            Console.WriteLine("======  Candidates  ======");
            var candidates = genData.GetCandidates();
            foreach (var candidate in candidates)
            {
               Console.WriteLine(candidate.FirstName + " "+ candidate.LastName);
            }
            Console.WriteLine("======  Electorates  ======");
            var electorates = genData.GetElectorates();
            foreach(var electorate in electorates)
            {
                Console.WriteLine(electorate.Name + " " + electorate.State);
            }
            Console.WriteLine("======  Parties  ======");
            var parties = genData.GetParties();
            foreach(var party in parties)
            {
                Console.WriteLine(party.Name + " " + party.Abbreviation);
            }
        }
    }
}
