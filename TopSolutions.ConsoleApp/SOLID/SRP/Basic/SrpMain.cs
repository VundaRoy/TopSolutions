using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.SRP.Basic
{
    public class SrpMain
    {
        public static void Main()
        {
            BankAccount johnsAccount = new BankAccount(123456);
            johnsAccount.Deposit(500);
            johnsAccount.Withdraw(100);
            StatementPrinter printer = new StatementPrinter();
            printer.Print(johnsAccount);

            Console.ReadKey();
        }
    }
}
