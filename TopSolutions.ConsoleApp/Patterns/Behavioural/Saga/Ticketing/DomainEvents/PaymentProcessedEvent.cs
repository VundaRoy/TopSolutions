using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.EventInfrastructure;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.DomainEvents
{
    public class PaymentProcessedEvent : DomainEvent
    {
        public Guid BookingId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
