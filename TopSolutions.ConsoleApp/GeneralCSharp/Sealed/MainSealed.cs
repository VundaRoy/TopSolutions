using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Sealed
{
    public class MainSealed
    {
        static void Main(string[] args)
        {
            SubClass subClass = new SubClass();
            subClass.Paint();
            subClass.ColorMeShocked();

            FinalClass finalClass = new();
            finalClass.Paint();
            finalClass.ColorMeShocked();
        }
    }
}
