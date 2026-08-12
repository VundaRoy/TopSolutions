using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace TopSolutions.ConsoleApp.Advanced.Concurrency
{
    internal class SemaphoreMain
    {
        public static void Main(string[] args)
        {
            //Create a semaphore with a maximum count of 3
            Semaphore semaphore = new(3, 3);
            //Create multiple threads to access a shared resource
            for (int i = 0; i < 10; i++)
            {
                int threadId = i;
                new Thread(() =>
                {
                    //Wait to enter the semaphore
                    semaphore.WaitOne();
                    Console.WriteLine($"Thread {threadId} entered the semaphore.");
                    //Simulate some work
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread {threadId} is leaving the semaphore.");
                    //Release the semaphore
                    semaphore.Release();
                }).Start();
            }

        }
    }

}