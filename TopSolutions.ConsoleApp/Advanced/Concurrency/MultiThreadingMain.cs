using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Concurrency
{
    public class MultiThreadingMain
    {
        public static void Main(string[] args)
        {
            PrintTimeStamp("Thread started");
            // Create a new thread that runs the PrintNumbers method
            Thread thread = new Thread(PrintNumbers);
            thread.Start();
            // Main thread continues to run and prints letters
            for (char letter = 'A'; letter <= 'E'; letter++)
            {
                Console.WriteLine(letter);
                Thread.Sleep(500); // Sleep for 500 milliseconds
            }
            // Wait for the other thread to finish
            thread.Join();
            PrintTimeStamp("Thread finished");
        }

        private static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); // Sleep for 500 milliseconds
            }
        }
        private static void PrintTimeStamp(string message)
        {
            Console.WriteLine($"{message} at: {DateTime.Now}");
        }
    }
}
