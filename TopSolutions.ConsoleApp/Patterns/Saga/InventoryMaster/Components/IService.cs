using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Saga.InventoryMaster.Components
{
    public interface IService
    {
        bool Do(OrderSagaState state);
        void Undo(OrderSagaState state);
    }
}
