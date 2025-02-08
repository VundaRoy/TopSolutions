using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Mediator.SmartHome
{
    public abstract class Component
    {
        protected IHomeController _controller;
        public Component(IHomeController controller)
        {
            _controller = controller;
        }
    }
}
