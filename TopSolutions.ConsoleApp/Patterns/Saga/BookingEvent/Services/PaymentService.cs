using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.BookingEvent.Services
{
    public class PaymentService
    {
        private readonly Random _random = new Random();

        public async Task<(bool Success, string ErrorMessage)> ProcessPayment(Guid bookingId, decimal amount)
        {
            Console.WriteLine($"[PaymentService] Processing payment of ${amount} for booking {bookingId}...");
            await Task.Delay(1500);

            if (_random.Next(10) < 9) // 90% success rate
            {
                Console.WriteLine($"[PaymentService] ✓ Payment processed successfully");
                return (true, null);
            }

            Console.WriteLine("[PaymentService] ✗ Payment failed: Insufficient funds");
            return (false, "Insufficient funds");
        }

        public async Task RefundPayment(Guid bookingId, decimal amount)
        {
            Console.WriteLine($"[PaymentService] Refunding ${amount} for booking {bookingId}...");
            await Task.Delay(500);
            Console.WriteLine($"[PaymentService] ✓ Refund completed");
        }
    }
}
