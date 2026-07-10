using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Algorithms.Performance.ONotation.NLog
{
    internal class NLogMain
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 100, 21, 5, 8, 11, 22, 34, 37, 90, 122, 126 };
            
            //using N Log N example for performance given an array of integers
            Console.WriteLine("Before sorting: " + string.Join(", ", numbers));
            MergeSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        }
        
        //implementing N Log N example for performance given an array of integers
        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid); //Sort the first half
                MergeSort(arr, mid + 1, right); //Sort the second half
                Merge(arr, left, mid, right); //Merge the sorted halves
            }            
        }
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            // Create temp arrays
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            // Copy data to temp arrays
            Array.Copy(arr, left, leftArray, 0, leftSize);
            Array.Copy(arr, mid + 1, rightArray, 0, rightSize);

            // Merge the temp arrays back
            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k++] = leftArray[i++];
                }
                else
                {
                    arr[k++] = rightArray[j++];
                }
            }

            // Copy remaining elements
            while (i < leftSize)
            {
                arr[k++] = leftArray[i++];
            }

            while (j < rightSize)
            {
                arr[k++] = rightArray[j++];
            }
        }
    }
}
