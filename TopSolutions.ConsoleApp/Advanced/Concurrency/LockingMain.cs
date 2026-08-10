using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Concurrency
{
    public class LockingMain
    {
        //Locking sample with multiple threads
        public static void Main(string[] args)
        {
            //Create a shared resource
            int sharedResource = 0;
            //Create a lock object
            object lockObject = new object();
            //Create multiple threads to access the shared resource
            for (int i = 0; i < 10; i++)
            {
                int threadId = i;
                new System.Threading.Thread(() =>
                {
                    //Lock the shared resource
                    lock (lockObject)
                    {
                        //Increment the shared resource
                        sharedResource++;
                        Console.WriteLine($"Thread {threadId} incremented shared resource to {sharedResource}");
                    }
                }).Start();
            }
        }
    }
}
