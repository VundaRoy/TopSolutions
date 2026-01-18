using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.HomeTheater
{
    public class AudioSystem
    {
        public void TurnOn() => Console.WriteLine("Audio System Turned On");
        public void SetVolume(int level) => Console.WriteLine($"Audio System Volume Set to {level}");
    }
}
