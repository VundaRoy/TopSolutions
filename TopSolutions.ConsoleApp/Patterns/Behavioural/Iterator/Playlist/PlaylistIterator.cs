using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.Playlist
{
    internal class PlaylistIterator : IIterator<Song>
    {
        private readonly Playlist _playlist;
        private int _index = 0;
        public PlaylistIterator(Playlist playlist)
        {
            _playlist = playlist;
        }
        public bool HasNext()
        {
            return _index < _playlist.Count;
        }
        public Song Next()
        {
            return _playlist[_index++];
        }
    }
}
