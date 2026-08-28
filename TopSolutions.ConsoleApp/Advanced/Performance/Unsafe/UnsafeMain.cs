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
            Console.WriteLine("Running unsafe methods:");
            RunUnsafeMethods();
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
        private static void RunUnsafeMethods()
        {
            //run unsafe method
            unsafe
            {
                fixed (int* p = new int[10]) // Pin a dummy array in memory
                {
                    // Call the unsafe method
                    p[0] = 1;
                    for(int i = 0; i < 10; i++)
                    {
                        UnSafeMethod1(p);
                        p[0]++;
                    }
                }
                
            }
            
        }
        private unsafe static void UnSafeMethod1(int* p)
        {
            Console.WriteLine($"An unsafe method is running. Iteration number {p[0]}");
        }
    }
}
