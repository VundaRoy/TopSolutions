using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Unsafe
{
    internal class UnsafeMain
    {
        public static void Main(string[] args)
        {
            // Create an array of integers
            int[] numbers = { 1, 2, 3, 4, 5,22, 102, 278,1234, 2343 };
            numbers = GetUnsafeValues(numbers);
            // Print the modified array
            Console.WriteLine("Modified array:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static int[] GetUnsafeValues(int[] numbers)
        {
            // Use unsafe code to manipulate the array
            unsafe
            {
                fixed (int* p = numbers) // Pin the array in memory
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        // Increment each number by 1 using pointer arithmetic
                        *(p + i) += 1;
                    }
                }
            }

            return numbers;
        }
    }
}
