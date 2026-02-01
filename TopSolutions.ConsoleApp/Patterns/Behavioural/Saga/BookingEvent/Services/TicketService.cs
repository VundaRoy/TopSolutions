using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Services
{
    public class TicketService
    {
        private readonly Random _random = new Random();

        public async Task<(bool Success, string TicketId, string ErrorMessage)> ReserveTicket(Guid bookingId)
        {
            Console.WriteLine($"[TicketService] Reserving ticket for booking {bookingId}...");
            await Task.Delay(1000); // Simulate API call

            if (_random.Next(10) < 8) // 80% success rate
            {
                var ticketId = $"TKT-{Guid.NewGuid().ToString().Substring(0, 8)}";
                Console.WriteLine($"[TicketService] ✓ Ticket reserved: {ticketId}");
                return (true, ticketId, null);
            }

            Console.WriteLine("[TicketService] ✗ Ticket reservation failed: No seats available");
            return (false, null, "No seats available");
        }

        public async Task CancelReservation(string ticketId)
        {
            Console.WriteLine($"[TicketService] Cancelling reservation for ticket {ticketId}...");
            await Task.Delay(500);
            Console.WriteLine($"[TicketService] ✓ Reservation cancelled");
        }
    }
}
