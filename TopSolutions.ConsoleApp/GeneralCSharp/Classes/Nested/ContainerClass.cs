using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Nested
{
    public class ContainerClass
    {
        public ContainerClass()
        {
            Console.WriteLine("I am a container class");
        }
        public class InnerClass : ContainerClass
        {
            public InnerClass()
            {
                Console.WriteLine("I am an inner class");
            }
            public class FurtherInnerClass : InnerClass
            {
                public FurtherInnerClass()
                {
                    Console.WriteLine("Innum inner irukkuthu");
                }
                public void FurtherMethod()
                {
                    Console.WriteLine("Further meth");
                }
            }
        }
    }
}
