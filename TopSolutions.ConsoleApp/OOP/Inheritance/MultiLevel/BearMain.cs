using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class BearMain
    {
        public static void Main(string[] args)
        {
            BlackBear blackBear = new();
            blackBear.Eat();
            blackBear.EatMeat();
            blackBear.HasNonRetractileClaw();
            blackBear.Hunt();
            blackBear.NurseYoung();
            blackBear.Omnivory();
            blackBear.Sleep();
            blackBear.SingleChambered();
            blackBear.Walk();
            blackBear.MakeSound();
            blackBear.Climbing();
            blackBear.Foraging();
            blackBear.Hibernation();
        }
    }
}
