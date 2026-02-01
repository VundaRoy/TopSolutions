using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Components;
using TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Orchestrator;
using TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Service;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster
{
    public class InventoryMain
    {
        public static void Main()
        {
            var orderState = new OrderSagaState { OrderId = 1 };
            var orchestrator = new OrderOrchestrator();
            orchestrator.AddService(new InventoryService());
            orchestrator.AddService(new PaymentService()); //this one will fail
            orchestrator.AddService(new DeliveryService());
            orchestrator.Execute(orderState);
        }
    }
}
