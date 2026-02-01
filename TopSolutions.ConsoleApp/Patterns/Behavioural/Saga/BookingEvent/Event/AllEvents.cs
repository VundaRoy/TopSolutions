using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Event
{
    public class BookingStartedEvent : SagaEvent { public string CustomerName { get; set; } }
    public class TicketReservedEvent : SagaEvent { public string TicketId { get; set; } }
    public class TicketReservationFailedEvent : SagaEvent { public string Reason { get; set; } }
    public class PaymentProcessedEvent : SagaEvent { public decimal Amount { get; set; } }
    public class PaymentFailedEvent : SagaEvent { public string Reason { get; set; } }
    public class NotificationSentEvent : SagaEvent { }
    public class BookingCompletedEvent : SagaEvent { }
    public class BookingCancelledEvent : SagaEvent { public string Reason { get; set; } }

}
