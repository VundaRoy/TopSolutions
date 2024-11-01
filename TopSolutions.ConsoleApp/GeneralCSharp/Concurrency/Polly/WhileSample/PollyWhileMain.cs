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
                durationOfBreak: TimeSpan.FromSeconds(10),
                onBreak: (exception, timespan) => {
                    Console.WriteLine("Circuit broken!");
                },
                onReset: () => {
                    Console.WriteLine("Circuit reset!");
                },
                onHalfOpen: () => {
                    Console.WriteLine("Circuit half-open, next call is a trial.");
                });

            while (true)
            {
                try
                {
                    circuitBreakerPolicy.Execute(() =>
                    {
                        // Your code that might throw exceptions
                       // SendRequest();
                        Console.WriteLine("Request sent successfully.");
                    });
                }
                catch (BrokenCircuitException)
                {
                    Console.WriteLine("Circuit is open; waiting before retrying...");
                     Task.Delay(TimeSpan.FromSeconds(15)); // Wait before retrying
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }


        }


    }
}
