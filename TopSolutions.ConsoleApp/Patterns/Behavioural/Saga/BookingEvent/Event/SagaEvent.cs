using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.BookingEvent.Event
{
    public abstract class SagaEvent
    {
        public Guid BookingId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
