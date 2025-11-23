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
            subClass.ColorMeShocked(); // can be called but not overridden
            subClass.Verify();

            FinalClass finalClass = new();
            finalClass.Paint();
            finalClass.ColorMeShocked(); // cannot override because it is sealed
           
            FinalClass finalClass2 = new();
            finalClass2.ColorMeShocked();
            //calling superclass method from final class without overriding
            FinalClass finalClass3 = new();
            finalClass3.Verify();
            //subclass2 call
            SubClass2 subClass2 = new();
            subClass2.Paint();
            subClass2.ColorMeShocked(); // can be called and overridden

        }
    }
}
