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
        public void FirstTierMethod()
        {
            Console.WriteLine("First tier meth");
        }
        public class InnerClass : ContainerClass
        {
            public InnerClass()
            {
                Console.WriteLine("I am an inner class");
            }
            public void SecondTierMethod()
            {
                Console.WriteLine("Second tier meth");
            }
            public class FurtherInnerClass : InnerClass
            {
                public FurtherInnerClass()
                {
                    Console.WriteLine("Innum inner irukkuthu");
                }
                public void ThirdTierMethod()
                {
                    Console.WriteLine("Third tier meth");
                }
            }
        }
    }
}
