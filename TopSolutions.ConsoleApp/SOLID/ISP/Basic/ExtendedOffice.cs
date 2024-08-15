using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.ISP.Basic
{
    public class ExtendedOffice : ICoffeeDispenser, IPrinter, IDishWasher
    {
        public string CheckDispenser(int DispenserId)
        {
            return "Coffee is " + DispenserId;

        }

        public void CheckInk()
        {
            Console.WriteLine("Checking ink");
        }

        public string CheckStatus(int PrinterId)
        {
            return "Printer is " + PrinterId + " and ready";
        }

        public void FeedPaper(int numberOfPapers)
        {
            Console.WriteLine("Paper fed");
        }

        public void MakeCoffee(int CoffeeId)
        {
            Console.WriteLine("Making coffee");
        }

        public void PutDetergent(int quantity)
        {
            Console.WriteLine("Placed detergent and ready to wash");
        }

        public void WashDishes()
        {
            Console.WriteLine("Washing now .. please wait");
        }
    }
}
