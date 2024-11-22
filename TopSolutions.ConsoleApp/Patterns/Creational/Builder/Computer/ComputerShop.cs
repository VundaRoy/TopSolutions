using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder builder)
        {
            builder.SetCPU();
            builder.SetRAM();
            builder.SetHardDrive();
            builder.SetGraphicsCard();
            builder.SetSoundCard();
            builder.SetManufacturer();
        }
    }
}
