﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.LSP.Basic.Comply
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.Round( 4 * Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
