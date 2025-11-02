using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public abstract class CorporateStaff
    {
        //Staff properties
        string Name { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }
        //Abstract method to calculate bonus
        public abstract decimal CalculateBonus();
        //basic method to display staff info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
        }
        //virtual method to promote staff
        public virtual void Promote(string newPosition, decimal salaryIncrease)
        {
            Position = newPosition;
            Salary += salaryIncrease;
            Console.WriteLine($"{Name} has been promoted to {Position} with a new salary of {Salary}");
        }
        //virtual terminate staff method
        public virtual void Terminate()
        {
            Console.WriteLine($"{Name} has been terminated from the company.");
        }

    }
}
