using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.Ticketing.StateManagement
{
    public class BookingState
    {
        public Guid BookingId { get; set; }
        public Guid CorrelationId { get; set; }
        public SagaStatus Status { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BookId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public Guid? PaymentId { get; set; }
        public Dictionary<string, bool> CompensationActions { get; set; } = new();
        public string FailureReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
