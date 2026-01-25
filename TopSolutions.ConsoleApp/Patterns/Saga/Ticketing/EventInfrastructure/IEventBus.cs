using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.EventInfrastructure
{
    public interface IEventBus
    {
        Task PublishAsync<T>(T @event) where T : IEvent;
        Task SubscribeAsync<T>(Func<T, Task> handler) where T : IEvent;
    }
}
