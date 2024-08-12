using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.Basic
{
    public class TranslateGreek : Translate
    {
        public override string GetMeaning(string word)
        {
            return base.GetMeaning(word + " is yasus");
        }
    }
}
