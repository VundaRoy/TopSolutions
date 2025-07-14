using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Constructors
{
    public class ClientForConstructor 
    {
        static void Main()
        {
            ClassConstructor constructor = new();
            constructor.SomeMeth();
            //constructor.Dispose();

            constructor = null; // Eligible for GC
            GC.Collect(); // Force garbage collection
            GC.WaitForPendingFinalizers(); // Wait for finalizers to run
            Thread.Sleep(1000); // give time for finalizer to print

        }


    }
}
