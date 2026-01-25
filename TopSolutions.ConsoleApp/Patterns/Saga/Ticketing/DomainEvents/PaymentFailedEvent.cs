using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.EventInfrastructure;

namespace TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.DomainEvents
{
    public class PaymentFailedEvent : DomainEvent
    {
        public Guid BookingId { get; set; }
        public string Reason { get; set; }
    }
}
