using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.InheritanceAbstract
{
    public class StateVoter : VoterManager
    {
        public Voter GetVoter(int Id, string statePolicy)
        {
            var t = base.GetVoter(Id);
            Console.WriteLine("This is a state election");
            return t;
        }
    }
}
