using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Singleton.Basic
{
    public class SingleTonMain
    {
      public static void Main() 
      {
            OneWay one = OneWay.OneTime;
            one.DoOnewayRun();
      }

    }
}
