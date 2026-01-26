using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Saga.BookingEvent.Orchestrator;
using TopSolutions.ConsoleApp.Patterns.Saga.BookingEvent.Services;

namespace TopSolutions.ConsoleApp.Patterns.Saga.BookingEvent
{
    public class BookingMain
    {
        public static async Task Main()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║         TICKET BOOKING SAGA PATTERN DEMO                 ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝\n");

            var ticketService = new TicketService();
            var paymentService = new PaymentService();
            var notificationService = new NotificationService();

            // Run multiple booking attempts to demonstrate both success and compensation
            var bookings = new[]
            {
            ("Alice Johnson", 150.00m),
            ("Bob Smith", 200.00m),
            ("Carol Williams", 175.00m)
        };

            foreach (var (customer, amount) in bookings)
            {
                var saga = new TicketBookingSaga(ticketService, paymentService, notificationService);
                var success = await saga.ExecuteAsync(customer, amount);

                Console.WriteLine($"Final Result: {(success ? "SUCCESS ✓" : "FAILED ✗")}\n");
                await Task.Delay(1000);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
