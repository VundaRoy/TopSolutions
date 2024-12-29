using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.State.Vending
{
    public class VendingStateMain
    {
        static void Main(string[] args)
        {
            // Initially Vending Machine will be NoMoneyState
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine($"Current VendingMachine State : {vendingMachine.VendingMachineState.GetType().Name}\n");
            vendingMachine.DispenseProduct();
            vendingMachine.SelectProductAndInsertMoney(50, "Pepsi");
            // Money has been inserted so vending Machine internal state changed to HasMoneyState
            Console.WriteLine($"\nCurrent VendingMachine State : {vendingMachine.VendingMachineState.GetType().Name}\n");
            vendingMachine.SelectProductAndInsertMoney(50, "Fanta");
            vendingMachine.DispenseProduct();
            // Product has been dispensed so vending Machine internal state changed to NoMoneyState
            Console.WriteLine($"\nCurrent VendingMachine State : {vendingMachine.VendingMachineState.GetType().Name}");
            vendingMachine.BringDownVendingMachine();
            vendingMachine.SelectProductAndInsertMoney(60, "cc chips");
            Console.Read();
        }
    }
}
