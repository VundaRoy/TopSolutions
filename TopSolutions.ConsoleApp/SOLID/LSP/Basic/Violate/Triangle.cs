using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Violate
{
    public class Triangle : Rectangle
    {
        public override double Base
        {
            get { return base.Base; }
            set { base.Base = value/2; }
        }
        public override double Height
        {
            get { return base.Height; }
            set { base.Height = value; }
        }
    }
}
