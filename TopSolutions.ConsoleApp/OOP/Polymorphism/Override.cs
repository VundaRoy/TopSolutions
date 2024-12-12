﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Polymorphism
{
    
    public class Source
    {
        public virtual void PrintSourceOfTruth(string variable)
        {
            Console.WriteLine($"The primary source of truth is {variable} ");
        }
        internal virtual void PrintTargetOfTruth(string variable) 
        { 
            Console.WriteLine("Protected "+ variable); 
        }
    }
    public class Override : Source
    {
        public override void PrintSourceOfTruth(string variable)
        {
            base.PrintSourceOfTruth(variable);
            Console.WriteLine($"The secondary truth is also a {variable}");
        }
        internal override void PrintTargetOfTruth(string variable)
        {
            base.PrintTargetOfTruth(variable);
            Console.WriteLine("Plus more of "+ variable);
        }
    }
    public class MainOverride
    {
        public static void Main(string[] args)
        {
            Override source = new();
            source.PrintSourceOfTruth("Torah");

            Source myTruth = new Override();
            myTruth.PrintSourceOfTruth("New testament");
            Source source1 = new Source();
            source1.PrintSourceOfTruth("Avesta");
            Source source2 = new Override();
            source2.PrintTargetOfTruth("which one");
        }
    }
}
