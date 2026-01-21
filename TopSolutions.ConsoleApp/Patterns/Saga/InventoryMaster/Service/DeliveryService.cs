using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Components;

namespace TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Service
{
    public class DeliveryService : IService
    {
        public bool Do(OrderSagaState state)
        {
            Console.WriteLine($"Arranging delivery for Order ID: {state.OrderId}");
            state.DeliveryArranged = true;
            return true;
        }
        public void Undo(OrderSagaState state)
        {
            if (state.DeliveryArranged)
            {
                Console.WriteLine($"Cancelling delivery for Order ID: {state.OrderId}");
                state.DeliveryArranged = false;
            }
        }
    }
}
