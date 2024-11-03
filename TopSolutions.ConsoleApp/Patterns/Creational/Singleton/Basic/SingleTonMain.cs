using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.Basic
{
    public class SingleTonMain
    {
        public static readonly OneWay one = OneWay.OneTime;
        public static void Main()
        {

            one.DoOnewayRun();
            RunAny();
        }

        public static void RunAny()
        {
            one.DoOnewayRun("and a couple of guys");
        }

    }
}
