using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Sorting
{
    public class SortTimer
    {
        public Stopwatch MeasureTime(Action<int[]> sortFunction, int[] arr)
        {
            int[] arrCopy = (int[])arr.Clone(); // Clone the array to avoid modifying the original
            Stopwatch stopwatch = new();
            stopwatch.Start();
            sortFunction(arrCopy);
            stopwatch.Stop();
            return stopwatch;
        }
        public Stopwatch MeasureTime(Action<int[], int, int> sortFunction, int[] arr, int left, int right)
        {
            int[] arrCopy = (int[])arr.Clone(); // Clone the array to avoid modifying the original
            Stopwatch stopwatch = new();
            stopwatch.Start();
            sortFunction(arrCopy, left, right);
            stopwatch.Stop();
            return stopwatch;
        }
    }
}
