using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Timing
{
    public class TimingMain
    {
        public static void Main()
        {
            var stopwatch = StopStart(1000);

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

            stopwatch = StopStart(3000);

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        private static Stopwatch StopStart(int sleep)
        {
            Stopwatch stopwatch = new();

            stopwatch.Start();
            Thread.Sleep(sleep);
            stopwatch.Stop();
            return stopwatch;
        }
    }
}
