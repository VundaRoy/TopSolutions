using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Components;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Service
{
    public class PaymentService : IService
    {
        public bool Do(OrderSagaState state)
        {
            Console.WriteLine($"Processing payment for Order ID: {state.OrderId}");
            state.PaymentCompleted = true;
            return true;
        }
        public void Undo(OrderSagaState state)
        {
            if (state.PaymentCompleted)
            {
                Console.WriteLine($"Refunding payment for Order ID: {state.OrderId}");
                state.PaymentCompleted = false;
            }
        }
    }
}
