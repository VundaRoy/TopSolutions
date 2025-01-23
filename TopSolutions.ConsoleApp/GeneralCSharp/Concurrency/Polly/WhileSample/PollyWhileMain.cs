using NPOI.OpenXmlFormats.Spreadsheet;
using Polly;
using Polly.CircuitBreaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Polly.WhileSample
{
    public class PollyWhileMain
    {
        public static void Main(string[] args)
        {
            var circuitBreakerPolicy = Policy
                .Handle<Exception>()
                .CircuitBreaker(
                exceptionsAllowedBeforeBreaking: 3,
                durationOfBreak: TimeSpan.FromSeconds(2),
                onBreak: (exception, timespan) =>
                {
                    Console.WriteLine("Circuit broken!");
                },
                onReset: () =>
                {
                    Console.WriteLine("Circuit reset!");
                },
                onHalfOpen: () =>
                {
                    Console.WriteLine("Circuit half-open, next call is a trial.");
                });
            int count = 0;
            while (true)
            {
                try
                {
                    circuitBreakerPolicy.Execute(() =>
                    {
                        // Your code that might throw exceptions
                        SendRequest(ref count);
                        Console.WriteLine("Request sent successfully.");
                    });
                }
                catch (BrokenCircuitException)
                {
                    Console.WriteLine("Circuit is open; waiting before retrying...");
                    Task.Delay(TimeSpan.FromSeconds(10)); // Wait before retrying
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }


        }
        static void SendRequest(ref int count)
        {
            Console.WriteLine("Sending something...");
            Task.Delay(TimeSpan.FromSeconds(1));
            if (count > 10)
            {
                throw new NotImplementedException();
                Console.WriteLine("yay!");
            }
            Console.WriteLine("Ending round " + count);
            count++;
        }

    }
}
