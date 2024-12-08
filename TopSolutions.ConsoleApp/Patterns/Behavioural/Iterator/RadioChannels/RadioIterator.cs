using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.RadioChannels
{
    public class RadioIterator : IIterator<Channel>
    {
        private List<Channel> _channels;
        private int _position = 0;
        public RadioIterator(List<Channel> channels)
        {
            _channels = channels;
        }
        public bool HasNext()
        {
            return _position < _channels.Count;
        }
        public Channel Next()
        {
            if (HasNext())
            {
                return _channels[_position++];
            }
            return null;
        }
        public bool HasPrevious()
        {
            return _position > 0;
        }
        public Channel Previous()
        {
            if (HasPrevious())
            {
                return _channels[--_position];
            }
            return null;
        }
    }
}
