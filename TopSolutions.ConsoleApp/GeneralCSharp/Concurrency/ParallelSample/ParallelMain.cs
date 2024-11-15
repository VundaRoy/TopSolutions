using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.ParallelSample
{
    public class ParallelMain
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Standard Foreach Loop Started");

            RunNormal(stopwatch);

            ResultPrint("standard", stopwatch);
            Console.ReadLine();
            stopwatch = new Stopwatch();
            RunParallel(stopwatch);

            ResultPrint("parallel", stopwatch);
            Console.ReadLine();
        }

        static void RunNormal(Stopwatch stopwatch)
        {
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            foreach (int i in integerList)
            {
                long total = DoSomeIndependentTimeConsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            };
            Console.WriteLine("Standard Foreach Loop Ended");
            stopwatch.Stop();
        }
        static void RunParallel(Stopwatch stopwatch)
        {
            Console.WriteLine("Parallel Foreach Loop Started");
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 30).ToList();
            Parallel.ForEach(integerList, i =>
            {
                long total = DoSomeIndependentTimeConsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            });
            Console.WriteLine("Parallel Foreach Loop Ended");
            stopwatch.Stop();
        }
        static long DoSomeIndependentTimeConsumingTask()
        {
            //Do Some Time Consuming Task here
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
        static void ResultPrint(string type, Stopwatch stopwatch)
        {
            Console.WriteLine($"Time Taken by {type} Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
