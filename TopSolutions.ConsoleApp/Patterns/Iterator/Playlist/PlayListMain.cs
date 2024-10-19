using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;

namespace TopSolutions.ConsoleApp.Patterns.Iterator.Playlist
{
    public class PlayListMain
    {
        static void Main()
        {
            var myPlaylist = new Playlist();
            myPlaylist.AddSong(new Song("Title 1", "Artist 1"));
            myPlaylist.AddSong(new Song("Title 2", "Artist 2"));
            myPlaylist.AddSong(new Song("Title 3", "Artist 3"));
            IIterator<Song> iterator = myPlaylist.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.ReadLine();
        }
    }
}
