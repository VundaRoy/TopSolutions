using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Span
{
    public class SpanMain
    {
        //Span usgage example
        public SpanMain() { }  
        public void SpanExample()
        {
            //Create a span of integers
            Span<int> numbers = [1, 2, 3, 4, 5]; // Create a span of integers with 5 elements
            Console.WriteLine("Span of integers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static void Main(string[] args)
        {
            //Create an instance of SpanMain and call the SpanExample method
            SpanMain spanMain = new SpanMain();
            spanMain.SpanExample();

        }
    }
}
