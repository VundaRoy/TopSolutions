using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Nested
{
    public class DemoClassMain : ContainerClass.InnerClass.FurtherInnerClass
    {
        public DemoClassMain()
        {
            Console.WriteLine("I am a Demo class");
        }
        public static void Main()
        {
            DemoClassMain DC = new DemoClassMain();
        }
    }
}
