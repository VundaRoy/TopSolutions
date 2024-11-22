﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.Computer
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void SetCPU()
        {
            Computer.CPU = "High Performance CPU";
        }
        public override void SetRAM()
        {
            Computer.RAM = "16 GB DDR4";
        }
        public override void SetHardDrive()
        {
            Computer.HardDrive = "1 TB SSD";
        }
        public override void SetGraphicsCard()
        {
            Computer.GraphicsCard = "High-end Graphics Card";
        }
        public override void SetManufacturer()
        {
            Computer.Manufacturer = "Samsung";
        }
        public override void SetSoundCard()
        {
            Computer.SoundCard = "7.1 Surround Sound Card";
        }
    }
}
