using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Components;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Saga.InventoryMaster.Orchestrator
{
    public class OrderOrchestrator
    {
        private readonly List<IService> _services = new();
        private readonly List<IService> _completedServices = new();

        public void AddService(IService service) => _services.Add(service);
        public void Execute(OrderSagaState state)
        {
            foreach (var service in _services)
            {
                if (service.Do(state))
                {
                    _completedServices.Add(service);
                }
                else
                {
                    Console.WriteLine("Service failed, initiating compensation...");
                    Rollback(state);
                    return;
                }
            }
            Console.WriteLine("All services completed successfully.");
        }
        private void Rollback(OrderSagaState state)
        {
            foreach (var service in Enumerable.Reverse(_completedServices))
            {
                service.Undo(state);
            }
            Console.WriteLine("Compensation completed.");
        }
    }
}
