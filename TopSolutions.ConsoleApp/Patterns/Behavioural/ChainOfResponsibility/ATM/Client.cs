using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.ChainOfResponsibility.ATM
{
    public class Client
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("Requested Amount 4600");
            atm.Withdraw(4600);
            Console.WriteLine("\nRequested Amount 1900");
            atm.Withdraw(1900);
            Console.WriteLine("\nRequested Amount 600");
            atm.Withdraw(600);
            Console.WriteLine("\nRequested Amount 750");
            atm.Withdraw(750);
            Console.WriteLine("\nRequested Amount 710");
            atm.Withdraw(710);
            Console.Read();
        }
    }
}
