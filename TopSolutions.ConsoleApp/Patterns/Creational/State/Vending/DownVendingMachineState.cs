using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.State.Vending
{
    public class DownVendingMachineState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine is down or not connecting.");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + "Rs cannot be inserted and " + productName + " is temporarily not accessible");
        }
    }
}
