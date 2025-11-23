using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Sealed
{
    public class SubClass2 : SuperClass
    {
        //override method from superclass
        public override void Paint()
        {
            Console.WriteLine("Paint method overridden in SubClass2");
        }
        //override colorMeShocked method from superclass
        public override void ColorMeShocked()
        {  
            //base.ColorMeShocked(); //calling base class method
            Console.WriteLine("ColorMeShocked method overridden in SubClass2");
        }
    }
}
