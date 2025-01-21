using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Sorting
{
    public class CompareSorts
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 30, 41, 5, 6, 7, 8, 9,101,112,1002,111,152,112,101,16,18,11,1522,1599,1255,11,105,114,163,32,56,668,95 };
            SortingAlgos sortAlgos = new();
            SortTimer sortTimer = new();

            Stopwatch bubbleTime = sortTimer.MeasureTime(sortAlgos.Bubble, array);
            Console.WriteLine($"Elapsed Time for bubble sort is {bubbleTime.Elapsed.TotalSeconds} ms");
            Stopwatch selectSort = sortTimer.MeasureTime(sortAlgos.SelectionSort, array);
            Console.WriteLine($"Elapsed Time for selection sort is {selectSort.Elapsed.TotalSeconds} ms");
            Stopwatch quickSort = sortTimer.MeasureTime(sortAlgos.QuickSort, array, 2,4);
            Console.WriteLine($"Elepsed time for quicksort is {quickSort.Elapsed.TotalSeconds} ms");
            Stopwatch partition = sortTimer.MeasureTime(sortAlgos.QuickSort, array, 1, 1);
            Console.WriteLine($"Elepsed time for partition is {partition.Elapsed.TotalSeconds} ms");

        }
    }
}
