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
            int[] array = new int[] { 555,1234,5,112334,55,334,3,4,1,999,1233,95 };
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
