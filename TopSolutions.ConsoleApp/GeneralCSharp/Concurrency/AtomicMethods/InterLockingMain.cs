using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.AtomicMethods
{
    public class InterLockingMain
    {
        //inter locking example
        public static void Main(string[] args)
        {
            //race condition example with multiple tasks
            int counter = 0;
            int numberOfTasks = 10;
            int incrementsPerTask = 1000;
            Task[] tasks = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++) // Create multiple tasks.
            {
                tasks[i] = Task.Run(() => // Each task increments the counter
                {
                    for (int j = 0; j < incrementsPerTask; j++) // Increment counter atomically.
                    {
                        System.Threading.Interlocked.Increment(ref counter); // Atomic increment. Race condition avoided.
                    }
                });
            }
            Task.WaitAll(tasks); // Wait for all tasks to complete
            Console.WriteLine($"Final counter value: {counter}");  // Expected: 10000

        }
    }
}
