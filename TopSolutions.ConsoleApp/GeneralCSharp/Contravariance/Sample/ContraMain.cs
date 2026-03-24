using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Contravariance.Sample
{
    //A contravariant class sample
    //Contravariance allows you to use a less derived type than originally specified. In this example, we will define
    //a contravariant delegate and demonstrate how it can be used with base and derived classes.
    public class ContraMain
    {
        // Define a contravariant delegate
        public delegate void ContravariantDelegate<in T>(T obj);

        public static void Main()
        {
            // Create a contravariant delegate instance
            ContravariantDelegate<BaseClass> contravariantDelegate = new ContravariantDelegate<BaseClass>(BaseMethod);
            // Assign a derived class method to the contravariant delegate
            ContravariantDelegate<DerivedClass> derivedDelegate = contravariantDelegate;
            // Call the method through the derived delegate
            derivedDelegate(new DerivedClass());
            //use the base class delegate to call the method with a base class object
            contravariantDelegate(new BaseClass());
            //use the derived method directly with a derived class object
            DerivedMethod(new DerivedClass());
            derivedDelegate(new DerivedClass());


        }
        public static void BaseMethod(BaseClass obj) // This method can accept a BaseClass object, but it can also accept a DerivedClass object due to contravariance
        {
            Console.WriteLine("Base method called with: " + obj.GetType().Name);
        }
        public static void DerivedMethod(DerivedClass obj) // This method can only accept a DerivedClass object
        {           
            Console.WriteLine("Derived method called with: " + obj.GetType().Name);
        }
    }
}
