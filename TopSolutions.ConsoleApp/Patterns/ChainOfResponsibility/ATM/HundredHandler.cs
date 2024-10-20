using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.ChainOfResponsibility.ATM
{
    public class HundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 100 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
            //No Need to Check the Next Handler
        }
    }
}
