using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public class DeveloperComputerBuilder : ComputerBuilder
    {
        public override void SetCPU()
        {
            Computer.CPU = "Pentium 3 max";
        }

        public override void SetHardDrive()
        {
            Computer.HardDrive = "SSD HD 2 TB";
        }

        public override void SetManufacturer()
        {
            Computer.Manufacturer = "Pentium C-Class";
        }

        public override void SetMicrosoftApps()
        {
            Computer.MicrosoftApps = "MS Office 360";
        }

        public override void SetRAM()
        {
            Computer.RAM ="120 GB RAM";
        }
        public override void SetSoundCard()
        {
            Computer.SoundCard = "Basic sound card";
        }
    }
}
