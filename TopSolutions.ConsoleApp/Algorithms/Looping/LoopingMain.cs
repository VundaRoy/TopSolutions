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
            lm.InitArray(100);
            //foreach
            Console.WriteLine("foreach");
            StopStart(lm.ForEachLoop);
            //for
            Console.WriteLine("for");
            StopStart(lm.ForLoop);
            //while
            Console.WriteLine("while");
            StopStart(lm.WhileLoop);
        }
        private static Stopwatch StopStart(Action process)
        {
            var methodName = process.Method.Name;
            Stopwatch stopwatch = new();

            stopwatch.Start();
            process();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time for {methodName} is {stopwatch.ElapsedMilliseconds} ms");
            return stopwatch;
        }
        private void ForEachLoop()
        {
            foreach(var num in ArrayOfInts)
            {
               Thread.Sleep(100);
            }
        }
        private void ForLoop()
        {
            for(int i = 0; i < ArrayOfInts.Length; i++)
            {
                Thread.Sleep(100);
            }
        }
        private void WhileLoop()
        {
            int i = 0;
            while (i < ArrayOfInts.Length)
            { 
                Thread.Sleep(100);
                i++;
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
