using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.ChainOfResponsibility.ATM
{
    public abstract class Handler
    {
        //The NextHandler will hold the reference of the next handler
        public Handler NextHandler;
        //Initializing NextHandler reference using the class constructor
        public void SetNextHandler(Handler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle a request.
        public abstract void DispatchNote(long requestedAmount);
    }
}
