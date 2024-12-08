using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.RadioChannels
{
    public class RadioIteratorMain
    {
        static void Main()
        {
            RadioStation myStation = new RadioStation();
            myStation.AddChannel(new Channel(89.1, "Classic Rock"));
            myStation.AddChannel(new Channel(102.2, "Pop Hits"));
            myStation.AddChannel(new Channel(98.7, "News Channel"));
            IIterator<Channel> iterator1 = myStation.GetIterator();
            GoForward(iterator1);
            GoBackward(iterator1);

            RadioStation hipHopStations = new RadioStation();
            hipHopStations.AddChannel(new Channel(95.6, "Papi Mami"));
            hipHopStations.AddChannel(new Channel(99.8, "Yo Bro FM"));
            hipHopStations.AddChannel(new Channel(102.3, "Jayzee channel"));
            IIterator<Channel> iterator2 = hipHopStations.GetIterator();
            GoForward(iterator2);
            GoBackward(iterator2);

            Console.ReadKey();
        }

        private static void GoBackward(IIterator<Channel> iterator1)
        {
            Console.WriteLine("Backward:");
            while (iterator1.HasPrevious())
            {
                Console.WriteLine(iterator1.Previous().Name);
            }
        }

        private static void GoForward(IIterator<Channel> iterator)
        {
            Console.WriteLine("Forward:");
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next().Name);
            }
        }
    }
}
