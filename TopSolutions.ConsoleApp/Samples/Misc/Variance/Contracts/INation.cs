﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.Variance
{
    internal interface INation<in Sovereignty>
    {
        public void Defense<T>() where T : Sovereignty;
    }
}
