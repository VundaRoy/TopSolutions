using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Looping
{
    public class LoopingMain
    {
        int[] ArrayOfInts;
        public static void Main(string[] args)
        {
            LoopingMain lm = new LoopingMain();
            lm.InitArray(100000);
            //foreach
            Console.WriteLine("foreach");
            StopStart(lm.ForEachLoop);
            //for
            Console.WriteLine("for");
            StopStart(lm.ForLoop);
        }
        private static Stopwatch StopStart(Action process)
        {
            Stopwatch stopwatch = new();

            stopwatch.Start();
            process();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time for {nameof(process)} is {stopwatch.ElapsedMilliseconds} ms");
            return stopwatch;
        }
        private void ForEachLoop()
        {
            foreach(var num in ArrayOfInts)
            {
               // Console.WriteLine(num);
            }
        }
        private void ForLoop()
        {
            for(int i = 0; i < ArrayOfInts.Length; i++)
            {
                //Console.WriteLine(ArrayOfInts[i]);
            }
        }
        private void InitArray(int size)
        {
            ArrayOfInts = new int[size];
            for(int i = 0; i < size; i++)
            {
                ArrayOfInts[i] = i;
            }
        }
    }     
}
