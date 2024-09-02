using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Sealed
{
    public class SubClass : SuperClass
    {
        public override void Paint()
        {
            base.Paint();
            Console.WriteLine("Sub paint");
        }
        public sealed override void ColorMeShocked()
        {
            base.ColorMeShocked();
            Console.WriteLine("Sealed subclass says sub shocked...");
        }
    }
}
