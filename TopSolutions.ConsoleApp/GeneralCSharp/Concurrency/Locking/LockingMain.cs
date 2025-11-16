using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Locking
{
    public class LockingMain
    {
        //Locking example in C# 
        private static readonly object _lockObject = new ();
        public static void Main(string[] args)
        {
            //locking example with multiple threads
            Thread t1 = new Thread(AccessSharedResource);
            Thread t2 = new Thread(AccessSharedResource);
            Thread t3 = new Thread(AccessSharedResource);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
        //Method to access a shared resource with locking
        public static void AccessSharedResource()
        {
            Console.WriteLine($"Task is waiting to access the shared resource - tua...");
            lock (_lockObject)
            {
                Console.WriteLine($"Task is waiting to access the shared resource - lua...");
                // Simulate work with the shared resource
                Task.Delay(1000).Wait();
                Console.WriteLine($"Task is waiting to access the shared resource - tolu...");
            }
        }
    }
}
