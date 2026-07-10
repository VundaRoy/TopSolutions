using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Algorithms.Performance.ONotation.LogN2
{
    public class LogN2Main
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 8, 11, 22, 34, 37, 90, 122, 126 };
            int target = 34;
            int index = BinarySearch(numbers, target);
            Console.WriteLine($"Found at index: {index}");
        }
        //Log N^2 example for performance given an array of integers
        private static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
