using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Access
{
    public class MoreAccess
    {
        public static void Main()
        {
           MoreAccess moreAccess = new MoreAccess();
             moreAccess.PrivateProtectedMethod(); // Not accessible
            moreAccess.ProtectedInternalMethod(); // Accessible within the same assembly
            moreAccess.ProtectedMethod(); // Not accessible
            moreAccess.PublicMethod(); // Accessible everywhere
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("This is a private protected method.");
        }
         protected internal void ProtectedInternalMethod() 
        { 
            Console.WriteLine("This is a protected internal method.");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
    }
    public class DerivedClass : MoreAccess
    {
        public void Test()
        {
            PrivateProtectedMethod(); // Accessible within derived class
            ProtectedInternalMethod(); // Accessible within derived class
            ProtectedMethod(); // Accessible within derived class
            PublicMethod(); // Accessible everywhere
        }
    }
    public class NonDerivedClass
    {
        public void Test()
        {
            MoreAccess ma = new MoreAccess();
            // ma.PrivateProtectedMethod(); // Not accessible
            ma.ProtectedInternalMethod(); // Accessible within the same assembly
            // ma.ProtectedMethod(); // Not accessible
            ma.PublicMethod(); // Accessible everywhere
        }
    }
}
