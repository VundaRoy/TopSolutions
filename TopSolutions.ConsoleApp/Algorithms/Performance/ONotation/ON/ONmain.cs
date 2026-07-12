using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Algorithms.Performance.ONotation.ON
{
    public class ONmain
    {
        //simple O(n) logic for performance given an array of integers
        public static void Main(string[] args)
        {
            int[] numbers = { 100, 21, 5, 8, 11, 22, 34, 37, 90, 122, 126 };
            // Find the maximum value in the array using O(n) logic
            Console.WriteLine("The array is: " + string.Join(", ", numbers));
            Console.WriteLine("The maximum value in the array is: " + FindMax(numbers));
        }

        private static int FindMax(int[] numbers)
        {
            // Implementing O(n) logic for performance given an array of integers
            int max = numbers[0];
            // Loop through the array to find the maximum value
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        
        }

    }
    
}
