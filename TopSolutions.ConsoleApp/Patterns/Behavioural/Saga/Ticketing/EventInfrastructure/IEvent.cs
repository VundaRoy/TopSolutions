using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.EventInfrastructure
{
    public interface IEvent
    {
        Guid CorrelationId{ get; }
        DateTime Timestamp { get; }
    }
}
