using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Services
{
    public class NotificationService
    {
        public async Task SendConfirmation(Guid bookingId, string customerName)
        {
            Console.WriteLine($"[NotificationService] Sending confirmation to {customerName}...");
            await Task.Delay(500);
            Console.WriteLine($"[NotificationService] ✓ Confirmation email sent");
        }

        public async Task SendCancellation(Guid bookingId, string customerName, string reason)
        {
            Console.WriteLine($"[NotificationService] Sending cancellation notice to {customerName}...");
            await Task.Delay(500);
            Console.WriteLine($"[NotificationService] ✓ Cancellation email sent. Reason: {reason}");
        }
    }
}
