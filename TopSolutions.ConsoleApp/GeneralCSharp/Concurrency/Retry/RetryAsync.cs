using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Retry
{
    public class RetryAsync
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Retry Async Main Method Started......");
            SomeMethodAsync().GetAwaiter().GetResult();
            Console.WriteLine("Retry Async Main Method End");
        }
        //Retry async method
        public async static Task SomeMethodAsync()
        {
            int maxRetries = 3;
            int delayMilliseconds = 2000;
            int attempt = 0;
            bool success = false;
            while (attempt < maxRetries && !success)
            {
                try
                {
                    attempt++;
                    Console.WriteLine($"Attempt {attempt}...");
                    // Simulate an asynchronous operation that may fail
                    await Task.Delay(500); // Simulate work
                    if (new Random().Next(2) == 0) // Randomly fail
                    {
                        throw new Exception("Simulated failure.");
                    }
                    Console.WriteLine("Operation succeeded.");
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Operation failed: {ex.Message}");
                    if (attempt < maxRetries)
                    {
                        Console.WriteLine($"Waiting {delayMilliseconds}ms before retrying...");
                        await Task.Delay(delayMilliseconds);
                    }
                    else
                    {
                        Console.WriteLine("Max retries reached. Operation failed.");
                    }
                }
            }
        }

    }
}
