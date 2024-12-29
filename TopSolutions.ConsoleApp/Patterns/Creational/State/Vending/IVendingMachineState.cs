using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.State.Vending
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, string productName);
        void DispenseProduct();
    }
}
