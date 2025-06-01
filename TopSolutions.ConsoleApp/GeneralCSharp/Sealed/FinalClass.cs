using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Sealed
{
    public class FinalClass : SubClass
    {
        public  void Paint()
        {
            base.Paint();
            Console.WriteLine("Finally the paint");
        }

        //cannot override because it is sealed
        //public override void ColorMeShocked()
        //{
        //}
    }
}
