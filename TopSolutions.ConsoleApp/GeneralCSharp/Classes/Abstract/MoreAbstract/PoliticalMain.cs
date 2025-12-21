using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public class PoliticalMain
    {
        List<TotalitarianParty> totalitarianParties = new List<TotalitarianParty>();
        List<AnarchistParty> anarchistParties = new List<AnarchistParty>();
        List<ReligousFundamentalistParty> religousFundamentalistParties = new List<ReligousFundamentalistParty>();

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

            PoliticalMain politicalMain = new PoliticalMain();
            politicalMain.CreateTotalitarianList();
            politicalMain.CreateAnarchistList();
            politicalMain.CreateReligousFundamentalistList();
            //display totalitarian parties
            politicalMain.DisplayTotalitarianParties();

        }

        public void CreateTotalitarianList()
        {
            CreateTotalitarianParty("Democratic Peoples Party", "Valdor Slavska", 1990);
            CreateTotalitarianParty("Social Unity Party", "Mira Kovalenko", 1985);
            CreateTotalitarianParty("National Front Party", "Igor Petrov", 2000);
            CreateTotalitarianParty("Parcham Party", "Najibullah", 1977);
            CreateTotalitarianParty("khalq Party", "Khalilullah Khalili", 1965);
        }
        public void CreateAnarchistList()
        {
            CreateAnarchistParty("Freedom Coalition", "Lena Morozova", 1995);
            CreateAnarchistParty("Liberty Alliance", "Dmitri Sokolov", 2005);
            CreateAnarchistParty("People's Liberation Front", "Anna Ivanova", 2010);
        }
        public void CreateReligousFundamentalistList()
        {
            CreateReligousFundamentalistParty("Holy Light Movement", "Father Alexei", 1980);
            CreateReligousFundamentalistParty("Sacred Path Society", "Sister Maria", 1990);
            CreateReligousFundamentalistParty("Divine Truth Fellowship", "Reverend John", 2000);
            CreateReligousFundamentalistParty("Jamiat Ulema-e-Islam", "Maulana Fazlur Rehman", 1945);
            CreateReligousFundamentalistParty("Jamaat-e-Islami", "Siraj-ul-Haq", 1941);
            CreateReligousFundamentalistParty("Tehreek-e-Labbaik Pakistan", "Khadim Hussain Rizvi", 2015);
        }
        public void CreateTotalitarianParty(string name, string leader, int foundedYear)
        {
            var party = new TotalitarianParty
            {
                Name = name,
                Leader = leader,
                FoundedYear = foundedYear
            };
            totalitarianParties.Add(party);
        }
        public void CreateAnarchistParty(string name, string leader, int foundedYear)
        {
            var party = new AnarchistParty
            {
                Name = name,
                Leader = leader,
                FoundedYear = foundedYear
            };
            anarchistParties.Add(party);
        }
        public void CreateReligousFundamentalistParty(string name, string leader, int foundedYear)
        {
            var party = new ReligousFundamentalistParty
            {
                Name = name,
                Leader = leader,
                FoundedYear = foundedYear
            };
            religousFundamentalistParties.Add(party);
        }
        public void DisplayTotalitarianParties()
        {
            Console.WriteLine("Totalitarian Parties:");
            foreach (var party in totalitarianParties)
            {
                Console.WriteLine($"Party: {party.Name}, Leader: {party.Leader}, Founded: {party.FoundedYear}");
            }
        }
    }
}
