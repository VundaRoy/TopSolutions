using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.HomeTheater
{
    public class StreamingService
    {
        public void Connect(string serviceName) => Console.WriteLine($"Connected to {serviceName} Streaming Service");
        public void PlayContent(string contentName) => Console.WriteLine($"Playing {contentName} on Streaming Service");
        public void StopContent() => Console.WriteLine("Stopped Streaming Content");
        public void Disconnect() => Console.WriteLine("Disconnected from Streaming Service");
    }
}
