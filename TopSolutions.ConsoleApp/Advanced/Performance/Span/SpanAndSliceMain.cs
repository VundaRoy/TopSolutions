using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Span
{
    public class SpanAndSliceMain
    {
        //Usage example of Span and Slice
        public static void Main(string[] args)
        {
            //Create a span of integers
            Span<int> numbers = [1, 2, 3, 4, 5]; // Create a span of integers with 5 elements
            Console.WriteLine("Span of integers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Slice the span to get the first 3 elements
            Span<int> slicedNumbers = numbers.Slice(0, 3);
            Console.WriteLine("Sliced span of integers:");
            foreach (var number in slicedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
