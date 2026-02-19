using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Plant
{
    public class Branch : IPlant
    {
        private readonly IList<IPlant> children;
        public Branch(IList<IPlant> children)
        {
            Console.WriteLine($"Branch is created with {children.Count} leaves ");
            this.children = children;
        }
        public void Eat()
        { 
              foreach(var child in children)
              {
                  child.Eat();
            }
        }
    }
}
