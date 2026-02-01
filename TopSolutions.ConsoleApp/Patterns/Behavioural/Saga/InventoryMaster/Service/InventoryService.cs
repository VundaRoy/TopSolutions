using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Components;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Service
{
    public class InventoryService : IService
    {
        public bool Do(OrderSagaState state)
        {
            Console.WriteLine($"Reserving inventory for Order ID: {state.OrderId}");
            state.InventoryReserved = true;
            return true;
        }
        public void Undo(OrderSagaState state)
        {
            if (state.InventoryReserved)
            {
                Console.WriteLine($"Releasing inventory for Order ID: {state.OrderId}");
                state.InventoryReserved = false;
            }
        }
    }
}
