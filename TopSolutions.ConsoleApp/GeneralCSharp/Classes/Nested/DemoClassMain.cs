using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Nested
{
    public class DemoClassMain : ContainerClass.InnerClass.FurtherInnerClass
    {
        public static void Main()
        {
            ContainerClass container = new ();
            InnerClass SecondTierClass = new InnerClass();
            
            if (container.Equals(SecondTierClass))
            {
                Console.WriteLine("Inner is equal to outer");
            }
            //first tier class method call
            container.FirstTierMethod();
            //Second tier class method call
            SecondTierClass.SecondTierMethod();
            SecondTierClass.FirstTierMethod();//Calling first tier method from second tier instance
            //Third tier class method call
            FurtherInnerClass thirdTierClass = new();
            thirdTierClass.ThirdTierMethod();
            thirdTierClass.SecondTierMethod();//Calling second tier method from third tier instance
            //Third tier class calling first tier method    
            thirdTierClass.FirstTierMethod();
            //second tier class calling third tier method
            //SecondTierClass.ThirdTierMethod(); // This line would cause a compile-time error
            //first tier class calling second tier method
            //container.SecondTierMethod(); // This line would cause a compile-time error
        }
    }
}
