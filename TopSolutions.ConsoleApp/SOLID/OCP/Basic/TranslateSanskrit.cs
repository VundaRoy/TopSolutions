using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.Basic
{
    public class TranslateSanskrit : Translate
    {
        public override string GetMeaning(string word)
        {
            return base.GetMeaning(word + " अशोच्यनन्वशोचस्त्वं");
        }
    }
}
