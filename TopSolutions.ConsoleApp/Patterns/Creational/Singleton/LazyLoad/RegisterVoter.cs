using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad
{
    public class RegisterVoter
    {
        private static readonly Lazy<RegisterVoter> _lazyInstance = new Lazy<RegisterVoter>(() => new RegisterVoter());
        private string _voterName;

        private RegisterVoter()
        {
            _voterName = "New Person";
        }
        public static RegisterVoter Instance => _lazyInstance.Value;

        public void PrintVoter(string voterName)
        {
            Console.WriteLine("Voter is " + voterName);
        }
    }
}
