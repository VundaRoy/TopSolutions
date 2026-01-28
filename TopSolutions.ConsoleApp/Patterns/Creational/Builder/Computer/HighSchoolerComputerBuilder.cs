using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public class HighSchoolerComputerBuilder : ComputerBuilder
    {
        public override void SetCPU()
        {
            Computer.CPU = "Intel i3";
        }
        public override void SetHardDrive()
        {
            Computer.HardDrive = "HDD 500 GB";
        }
        public override void SetManufacturer()
        {
            Computer.Manufacturer = "Dell Inspiron";
        }
        public override void SetMicrosoftApps()
        {
            Computer.MicrosoftApps = "MS Office Student Edition";
        }
        public override void SetRAM()
        {
            Computer.RAM = "8 GB RAM";
        }
        public override void SetSoundCard()
        {
            Computer.SoundCard = "Integrated sound card";
        }
    }
}
