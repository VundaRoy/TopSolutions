using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Observer.Notification
{
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(string availability);
    }
}
