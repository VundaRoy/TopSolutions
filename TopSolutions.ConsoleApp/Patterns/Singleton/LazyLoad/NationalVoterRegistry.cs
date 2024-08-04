using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Singleton.LazyLoad
{
    public class NationalVoterRegistry : VoterBase
    {
        public NationalVoterRegistry() { }
        public void Register() 
        {
            registerVoter.PrintVoter("oldham");
        }
    }
}
