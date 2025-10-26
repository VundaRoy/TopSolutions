using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.GeneralCSharp.Basics.Interfaces.Contract;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Basics.Interfaces
{
    public class InterfaceMain
    {
        public static void Main()
        {
            IBankAccount myAccount = new BankAccount();
            myAccount.Deposit(500);
            Console.WriteLine($"Balance after deposit: {myAccount.GetBalance()}");
            myAccount.Withdraw(200);
            Console.WriteLine($"Balance after withdrawal: {myAccount.GetBalance()}");
            myAccount.Deposit(2000);
            Console.WriteLine($"Balance after deposit: {myAccount.GetBalance()}");
            Console.WriteLine($"Final Balance: {myAccount.GetBalance()}");
        }
    }
}
