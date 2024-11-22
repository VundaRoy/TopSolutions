using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public abstract class ComputerBuilder
    {
        protected Computer Computer { get; private set; } = new Computer();
        public abstract void SetCPU();
        public abstract void SetRAM();
        public abstract void SetHardDrive();
        public abstract void SetManufacturer();
        public virtual void SetGraphicsCard() { } // Optional
        public virtual void SetSoundCard() { }    // Optional
        public Computer GetComputer() => Computer;
    }
}
