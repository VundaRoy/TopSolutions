using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Singleton.LazyLoad
{
    public class VoterMain
    {
        static void Main()
        {
            RegisterVoter registerVoter = RegisterVoter.Instance;
            registerVoter.PrintVoter("Eko Maino");
            registerVoter.PrintVoter("Chinua Achebe");
        }
    }
}
