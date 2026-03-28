using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Event
{
    // The base class for all events in the saga, containing common properties like BookingId and Timestamp. Each specific event type will inherit from this class.
    public abstract class SagaEvent
    {
        public Guid BookingId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
