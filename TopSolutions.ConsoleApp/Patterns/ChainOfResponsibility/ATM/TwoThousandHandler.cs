using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.ChainOfResponsibility.ATM
{
    public class TwoThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 2000 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 2000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand notes are dispatched by TwoThousandHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand note is dispatched by TwoThousandHandler");
                }
            }
            //Then check the Pending amount
            long pendingAmountToBeProcessed = requestedAmount % 2000;
            //If the Pending amount is greater than 0, then call the next handler to handle the request
            if (pendingAmountToBeProcessed > 0)
            {
                //For TwoThousandHandler, the next handler is FiveHundredHandler 
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
