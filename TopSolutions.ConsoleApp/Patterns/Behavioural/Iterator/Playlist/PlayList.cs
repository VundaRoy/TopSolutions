using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.Playlist
{
    public class Playlist : IAggregate<Song>
    {
        private List<Song> _songs = new List<Song>();
        public void AddSong(Song song)
        {
            _songs.Add(song);
        }
        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(this);
        }
        public int Count => _songs.Count;
        public Song this[int index] => _songs[index];
    }
}
