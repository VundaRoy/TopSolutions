using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.EventInfrastructure
{
    public class DomainEvent :IEvent    
    {
        public Guid CorrelationId { get; private set; }
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
    }
}
