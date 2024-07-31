using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Factory.Simple.Contract;

namespace TopSolutions.ConsoleApp.Patterns.Factory.Simple.FactoryClass
{
    public class CookFactory 
    {
        public static ICook GetCookType(string cookType)
        {
            ICook cook = new Cook();
            if (cookType == "Asian")
            {
                cook = new CookAsian();
            }
            else if(cookType == "Latin")
            {
                cook = new CookLatin();
            }
            return cook;
        }
    }
}
