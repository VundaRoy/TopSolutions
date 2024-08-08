using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.InheritanceAbstract
{
    public class FederalVoter : VoterManager
    {
        public Voter GetVoter(int Id, string partyList, string federalPolicy)
        {
            var t = base.GetVoter(Id);
            Console.WriteLine("This is a federal election");
            Console.WriteLine("Party is "+ partyList +" and policy is "+federalPolicy);
            return t;
        }
    }
}
