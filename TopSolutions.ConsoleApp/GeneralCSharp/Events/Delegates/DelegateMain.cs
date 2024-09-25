using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Events.Delegates
{
    public class DelegateMain
    {
        public delegate void DistributeHandouts(int forms, string suburb);
        static void Main(string[] args)
        {
            DistributeHandouts dist1 = new(Pamphlet_Distribution);
            dist1(200, "Narwee");
            dist1 = new DistributeHandouts(ColdKnock_Visits);
            dist1(122, "Beverly Hills");
            GetNorthernDistricts(dist1, 600);
            dist1 = new DistributeHandouts(Pamphlet_Distribution);
            GetNorthernDistricts(dist1, 250);

        }

        public static void Pamphlet_Distribution(int  forms, string suburb)
        {
            Console.WriteLine($"About {forms} forms were distributed in {suburb}");
        }
        public static void ColdKnock_Visits(int knocks, string suburb)
        {
            Console.WriteLine($"About {knocks} household visits were done in {suburb}");
        }
        public static void GetNorthernDistricts(DistributeHandouts dist, int times)
        {
            Console.WriteLine("Calling northern districts");
            dist(times, "Brookvale");
        }
    }
}
