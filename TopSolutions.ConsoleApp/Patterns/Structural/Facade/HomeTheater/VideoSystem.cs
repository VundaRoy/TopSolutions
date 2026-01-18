using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.HomeTheater
{
    public class VideoSystem
    {
        public void TurnOn() => Console.WriteLine("Video System Turned On");
        public void SetInput(string input) => Console.WriteLine($"Video System Input Set to {input}");
    }
}
