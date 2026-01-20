using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Components
{
    public class OrderSagaState
    {
        public int OrderId { get; set; }
        public bool PaymentCompleted { get; set; }
        public bool InventoryReserved { get; set; }
    }
}
