using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Comply
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return (.5 * Base) * Height;
        }
    }
}
