using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Event;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Services;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Orchestrator
{
    public class TicketBookingSaga
    {
        private readonly TicketService _ticketService;
        private readonly PaymentService _paymentService;
        private readonly NotificationService _notificationService;
        private readonly List<SagaEvent> _events = new List<SagaEvent>();

        // State
        private string _ticketId;
        private decimal _amount;
        private string _customerName;
        private bool _paymentProcessed;

        public TicketBookingSaga(TicketService ticketService, PaymentService paymentService, NotificationService notificationService)
        {
            _ticketService = ticketService;
            _paymentService = paymentService;
            _notificationService = notificationService;
        }

        public async Task<bool> ExecuteAsync(string customerName, decimal amount)
        {
            var bookingId = Guid.NewGuid();
            _customerName = customerName;
            _amount = amount;

            Console.WriteLine($"\n{'=',60}");
            Console.WriteLine($"Starting Saga for Booking {bookingId}");
            Console.WriteLine($"Customer: {customerName}, Amount: ${amount}");
            Console.WriteLine($"{'=',60}\n");

            // Step 1: Start booking
            PublishEvent(new BookingStartedEvent { BookingId = bookingId, CustomerName = customerName });

            // Step 2: Reserve ticket
            var (ticketSuccess, ticketId, ticketError) = await _ticketService.ReserveTicket(bookingId);
            if (!ticketSuccess)
            {
                PublishEvent(new TicketReservationFailedEvent { BookingId = bookingId, Reason = ticketError });
                await CompensateAsync(bookingId);
                return false;
            }

            _ticketId = ticketId;
            PublishEvent(new TicketReservedEvent { BookingId = bookingId, TicketId = ticketId });

            // Step 3: Process payment
            var (paymentSuccess, paymentError) = await _paymentService.ProcessPayment(bookingId, amount);
            if (!paymentSuccess)
            {
                PublishEvent(new PaymentFailedEvent { BookingId = bookingId, Reason = paymentError });
                await CompensateAsync(bookingId);
                return false;
            }

            _paymentProcessed = true;
            PublishEvent(new PaymentProcessedEvent { BookingId = bookingId, Amount = amount });

            // Step 4: Send notification
            await _notificationService.SendConfirmation(bookingId, customerName);
            PublishEvent(new NotificationSentEvent { BookingId = bookingId });

            // Complete saga
            PublishEvent(new BookingCompletedEvent { BookingId = bookingId });

            Console.WriteLine($"\n{'=',60}");
            Console.WriteLine($"✓ Saga Completed Successfully for Booking {bookingId}");
            Console.WriteLine($"{'=',60}\n");

            return true;
        }

        private async Task CompensateAsync(Guid bookingId)
        {
            Console.WriteLine($"\n{'!',60}");
            Console.WriteLine("Starting Compensation (Rollback)");
            Console.WriteLine($"{'!',60}\n");

            // Compensate in reverse order
            if (_paymentProcessed)
            {
                await _paymentService.RefundPayment(bookingId, _amount);
            }

            if (_ticketId != null)
            {
                await _ticketService.CancelReservation(_ticketId);
            }

            await _notificationService.SendCancellation(bookingId, _customerName, "Booking failed");

            PublishEvent(new BookingCancelledEvent { BookingId = bookingId, Reason = "Saga compensation executed" });

            Console.WriteLine($"\n{'!',60}");
            Console.WriteLine($"✗ Saga Compensated for Booking {bookingId}");
            Console.WriteLine($"{'!',60}\n");
        }

        private void PublishEvent(SagaEvent evt)
        {
            _events.Add(evt);
            Console.WriteLine($"[Event] {evt.GetType().Name} published at {evt.Timestamp:HH:mm:ss}");
        }

        public List<SagaEvent> GetEvents() => _events;
    }
}
