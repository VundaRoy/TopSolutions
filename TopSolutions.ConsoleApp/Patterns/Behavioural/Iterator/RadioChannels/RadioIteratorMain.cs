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
            RadioStation newsStations = CreateNewsChannelsList();
            IIterator<Channel> iterator1 = newsStations.GetIterator();
            GoForward(iterator1);
            GoBackward(iterator1);
            RadioStation hipHopStations = CreateHipHopChannelsList();
            IIterator<Channel> iterator2 = hipHopStations.GetIterator();
            GoForward(iterator2);
            GoBackward(iterator2);
            //Classic hits
            RadioStation classicHits = CreateClassicHitsList();
            IIterator<Channel> iterator3 = classicHits.GetIterator();
            GoForward(iterator3);
            GoBackward(iterator3);

            Console.ReadKey();
        }

        private static RadioStation CreateHipHopChannelsList()
        {
            RadioStation hipHopStations = new ();
            hipHopStations.AddChannel(new Channel(95.6, "Papi Mami"));
            hipHopStations.AddChannel(new Channel(99.8, "Yo Bro FM"));
            hipHopStations.AddChannel(new Channel(102.3, "Jayzee channel"));
            return hipHopStations;
        }
        private static RadioStation CreateNewsChannelsList()
        {
            RadioStation newsChannels = new ();
            newsChannels.AddChannel(new Channel(101.5, "CBS"));
            newsChannels.AddChannel(new Channel(105.3, "NBC"));
            newsChannels.AddChannel(new Channel(109.3, "ABC"));
            return newsChannels;
        }
        private static RadioStation CreateClassicHitsList()
        {
            RadioStation classicHist  = new RadioStation();
            classicHist.AddChannel(new Channel(107.2, "4RO"));
            classicHist.AddChannel(new Channel(102.8, "JAZ6"));
            return classicHist;
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
