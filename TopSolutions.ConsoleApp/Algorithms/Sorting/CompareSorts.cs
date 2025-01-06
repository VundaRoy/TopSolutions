using System;
using System.Collections.Generic;
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
            SortingAlgos sortAlgos = new SortingAlgos();
            var res = sortAlgos.SelectionSort(array);
            Console.WriteLine($"Elapsed Time for selection sort is {res.Elapsed.TotalSeconds} ms");
            res = sortAlgos.Bubble(array);
            Console.WriteLine($"Elapsed Time for bubble sort is { res.Elapsed.TotalSeconds } ms");
        }
    }
}
