using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.EventInfrastructure;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.DomainEvents
{
    public class BookingInitiatedEvent : DomainEvent
    {
        public Guid BookingId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BookId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
    }
}
