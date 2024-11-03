using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad
{
    public class VoterBase
    {
        public static readonly RegisterVoter registerVoter = RegisterVoter.Instance;

    }
}
