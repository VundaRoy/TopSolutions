using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel.Contracts
{
    public interface IFeliformia : ICarnivora
    {
        void NightVision();
        void RetractileClaws();
        void Purring();
    }
}
