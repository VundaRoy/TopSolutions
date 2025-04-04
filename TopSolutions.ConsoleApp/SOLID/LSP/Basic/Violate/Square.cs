﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Violate
{
    public class Square : Rectangle
    {
        public override double Base
        {
            get { return base.Base; }
            set { base.Base = base.Height = value; }
        }
        public override double Height
        {
            get { return base.Height; }
            set { base.Base = base.Height = value; }
        }
    }
}
