using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Facade.HomeTheater
{
    public class HomeTheaterFacade
    {
        private readonly AudioSystem _audioSystem;
        private readonly VideoSystem _videoSystem;
        private readonly StreamingService _streamingService;
        public HomeTheaterFacade()
        {
            _audioSystem = new AudioSystem();
            _videoSystem = new VideoSystem();
            _streamingService = new StreamingService();
        }
        public void WatchMovie(string movieName)
        {
            Console.WriteLine("Getting ready to watch a movie...");
            _videoSystem.TurnOn();
            _videoSystem.SetInput("HDMI1");
            _audioSystem.TurnOn();
            _audioSystem.SetVolume(20);
            _streamingService.Connect("Netflix");
            _streamingService.PlayContent(movieName);
            Console.WriteLine("Enjoy your movie!");
        }
    }
}
