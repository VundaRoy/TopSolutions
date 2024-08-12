using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.OCP.Basic
{
    public class Translate
    {
        public virtual string GetMeaning(string word)
        {
            return word + " is default translation";
        }
    }
}

