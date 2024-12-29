using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.State.Vending
{
    public class NoMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + "Rs has been inserted and " + productName + " has been selected");
        }
    }
}
