using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.SOLID.DIP.ConstructorInjection;

namespace TopSolutions.ConsoleApp.SOLID.OCP.Basic
{
    public class TranslateGuwen : Translate
    {
        public override string GetMeaning(string word)
        {
            return base.GetMeaning(word + " 孔子曰");
        }
    }
}
