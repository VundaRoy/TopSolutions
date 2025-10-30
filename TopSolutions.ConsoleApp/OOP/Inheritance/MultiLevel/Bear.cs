using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class Bear : ICarniformia
    {
        public void Eat()
        {
            Console.WriteLine("Bear is eating");
        }
        public void EatMeat()
        {
            Console.WriteLine("Bear is eating fish");
        }
        public void HasNonRetractileClaw()
        {
            Console.WriteLine("Bear has non-retractile claws");
        }
        public void Hunt()
        {
            Console.WriteLine("Bear is hunting");
        }
        public void NurseYoung()
        {
            Console.WriteLine("Bear is nursing its young"); 
        }
        public void Omnivory()
        {
            Console.WriteLine("Bear is omnivorous");

        }
        public void Sleep()
        {
            Console.WriteLine("Bear is sleeping");
        }
        public void SingleChambered()
        {
            Console.WriteLine("Bear has a single-chambered stomach");
        }
        public void Walk()
        {
            Console.WriteLine("Bear is walking");
        }

        public void MakeSound()
        {
            Console.WriteLine("Heavy noise");
        }
    }
}
