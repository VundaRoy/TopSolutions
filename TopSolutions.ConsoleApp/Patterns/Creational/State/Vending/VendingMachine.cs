using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.State.Vending
{
    public class VendingMachine : IVendingMachineState
    {
        //Creating a variable to maintain the internal state
        public IVendingMachineState VendingMachineState { get; set; }
        //Initially the vending machine has NoMoneyState
        public VendingMachine()
        {
            VendingMachineState = new NoMoneyState();
        }
        // The Context Object allows changing the State of the object at runtime.
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            VendingMachineState.SelectProductAndInsertMoney(amount, productName);
            // Money has been inserted so Vending Machine's internal state changed to HasMoneyState
            
            if (VendingMachineState is NoMoneyState)
            {
                VendingMachineState = new HasMoneyState();
                Console.WriteLine($"VendingMachine internal state has been moved to {VendingMachineState.GetType().Name}");
            }
            else
            if (VendingMachineState is DownVendingMachineState)
            {
                Console.WriteLine("Vending machine is down");
            }
        }
        // The Context Object allows changing the State of the object at runtime.
        public void DispenseProduct()
        {
            VendingMachineState.DispenseProduct();
            // Product has been dispensed so vending Machine changed the internal state to NoMoneyState
            if (VendingMachineState is HasMoneyState)
            {
                VendingMachineState = new NoMoneyState();
                Console.WriteLine($"VendingMachine internal state has been moved to : {VendingMachineState.GetType().Name}");
            }
        }
        public void BringDownVendingMachine()
        {
            VendingMachineState = new DownVendingMachineState();
        }
    }
}
