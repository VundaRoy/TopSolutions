using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.RadioChannels
{
    public class RadioStation
    {
        private List<Channel> _channels = new List<Channel>();
        public void AddChannel(Channel channel)
        {
            _channels.Add(channel);
        }
        public IIterator<Channel> GetIterator()
        {
            return new RadioIterator(_channels);
        }
    }
}
