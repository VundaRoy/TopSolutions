using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Template.House
{
    public abstract class HouseTemplate
    {
        // Template Method defines the sequence for building a house
        public void BuildHouse()
        {
            //Define the Steps to Build a House
            BuildFoundation(); //Step1
            BuildPillars(); //Step2
            BuildWalls(); //Step3
            BuildWindows(); //Step4
            Console.WriteLine("House is Built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}
