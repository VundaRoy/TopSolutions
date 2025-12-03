using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.ChainOfResponsibility.ATM
{
    public class OneThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 1000 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 1000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " One Thousand notes are dispatched by OneThousandHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " One Thousand note is dispatched by OneThousandHandler");
                }
            }
            //Then check the Pending amount
            long pendingAmountToBeProcessed = requestedAmount % 1000;
            //If Pending amount is greater than 0, then call the next handler to handle the request
            if (pendingAmountToBeProcessed > 0)
            {
                //For OneThousandHandler, the next handler is FiveHundredHandler  
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
