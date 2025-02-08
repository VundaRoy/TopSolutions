using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public class Window : Component
    {
        public Window(IHomeController controller) : base(controller) { }
        public void Open()
        {
            Console.WriteLine("Window opened.");
            _controller.Notify(this, "opened");
        }
        public void Close()
        {
            Console.WriteLine("Window closed.");
            _controller.Notify(this, "closed");
        }
    }
}
