using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Boxing
{
    public class BoxingMain
    {
        static void Main(string[] args)
        {
            int x = 100;
            object y = x;//boxing
            int z = (int)y;//unboxing
        }
    }
}
