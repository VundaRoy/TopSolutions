using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public class PoliticalMain
    {
        public static void Main()
        {
            PoliticalParty totalitarianParty = new TotalitarianParty
            {
                Name = "People's Democratic Socialist Party",
                Leader = "Grobonov Alexei",
                FoundedYear = 1950
            };
            PoliticalParty anarchistParty = new AnarchistParty
            {
                Name = "Unrevolutionary Party",
                Leader = "Karl Hans Gruber",
                FoundedYear = 1975
            };
            PoliticalParty religousFundamentalistParty = new ReligousFundamentalistParty
            {
                Name = "Order of Christ and Dominion",
                Leader = "Rev Merlim Bright",
                FoundedYear = 1985
            };
            List<PoliticalParty> parties = new List<PoliticalParty>
            {
                totalitarianParty,
                anarchistParty,
                religousFundamentalistParty
            };
            foreach (var party in parties)
            {
                Console.WriteLine($"Party: {party.Name}, Leader: {party.Leader}, Founded: {party.FoundedYear}");
                party.Campaign();
                party.RaiseFunds();
                party.HoldElection();
                party.FormGovernment();
                Console.WriteLine();
            }
        }
    }
}
