using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Samples.Patterns.Iterator.After.Contracts;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Iterator.Playlist
{
    public class PlayListMain
    {
        static void Main()
        {
            var myPlaylist = new Playlist();
            myPlaylist.AddSong(new Song("Podave Irukkaa", "SP Bala"));
            myPlaylist.AddSong(new Song("Song Song Blue", "Neil Diamond"));
            myPlaylist.AddSong(new Song("Rising Sun", "Animals"));
            myPlaylist.AddSong(new Song("Saajan Sasural", "Jagjit Singh"));
            IIterator<Song> iterator = myPlaylist.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.ReadLine();
        }
    }
}
