using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Locking
{
    public class LockingMain
    {
        static string[] fijianCount = new string[] { "dua (F)", "rua", "tolu", "va", "lima" };
        static string[] malayCount = new string[] { "satu", "dua", "tiga", "empat", "lima" };
        static string[] maoriCount = new string[] { "tahi", "rua", "toru", "wha", "rima" };
        //Locking example in C# 
        private static readonly object _lockObject = new ();
        public static void Main(string[] args)
        {
            //locking example with multiple threads
            Thread t1 = new(AccessSharedResource);
            Thread t2 = new (AccessSharedResource);
            Thread t3 = new (AccessSharedResource);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
        //Method to access a shared resource with locking
        public static void AccessSharedResource()
        {
            Console.WriteLine($"Task is waiting to access the shared resource - {fijianCount[0]}...");
            lock (_lockObject)
            {
                Console.WriteLine($"Task is waiting to access the shared resource - {malayCount[1]}...");
                // Simulate work with the shared resource
                Task.Delay(1000).Wait();
                Console.WriteLine($"Task is waiting to access the shared resource -  {maoriCount[2]} .....");
            }
        }
    }
}
