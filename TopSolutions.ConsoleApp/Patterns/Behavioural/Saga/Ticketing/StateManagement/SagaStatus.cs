using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.Ticketing.StateManagement
{
    public enum SagaStatus
    {
        Started,
        CustomerValidated,
        PaymentProcessed,
        InventoryReserved,
        Completed,
        Failed,
        Compensating
    }
}
