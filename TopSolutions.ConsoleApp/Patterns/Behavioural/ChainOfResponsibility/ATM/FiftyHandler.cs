using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.ChainOfResponsibility.ATM
{
    public class FiftyHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 50 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 50;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Fifty notes are dispatched by FiftyHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Fifty note is dispatched by FiftyHandler");
                }
            }
            //No Need to Check the Next Handler
        }
    }
}
