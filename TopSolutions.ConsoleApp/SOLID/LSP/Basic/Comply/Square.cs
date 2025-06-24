using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Comply
{
    public class Square : IShape
    {
        public double Side { get; set; }
        public double GetArea()
        {
            return Side * Side;
        }
    }
}
