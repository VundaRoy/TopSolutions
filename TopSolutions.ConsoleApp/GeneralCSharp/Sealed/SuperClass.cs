using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Sealed
{
    public class SuperClass
    {        
        public virtual void Paint()
        {
            Console.WriteLine("Super paint");
        }
        public virtual void ColorMeShocked()
        {
            Console.WriteLine("Shocked look super");
        }
        public void Verify()
        {
            Console.WriteLine("Certified correct");
        }
    }
}
