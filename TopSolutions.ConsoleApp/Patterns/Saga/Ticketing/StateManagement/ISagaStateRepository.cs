using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.StateManagement
{
    public interface ISagaStateRepository
    {
        Task SaveStateAsync(BookingState state);
        Task<BookingState> GetStateAsync(Guid correlationId);
        Task UpdateStateAsync(BookingState state);
    }
}
