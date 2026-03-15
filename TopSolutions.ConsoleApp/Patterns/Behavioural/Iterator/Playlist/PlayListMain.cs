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
            myPlaylist.AddSong(new Song("Mere Dholna", "Shreya Ghoshal"));
            IIterator<Song> iterator = myPlaylist.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            //Get list of English songs
            var englishSongs = new PlayListMain().GetListOfEnglishSongs(myPlaylist);
            Console.WriteLine("List of English songs:");
            IIterator<Song> englishSongsIterator = englishSongs.CreateIterator();
            while (englishSongsIterator.HasNext())
            {
                Console.WriteLine(englishSongsIterator.Next());
            }
            Console.ReadLine();
        }
        public Playlist GetListOfEnglishSongs(Playlist playlist)
        {
            var englishSongs = new Playlist();
            IIterator<Song> iterator = playlist.CreateIterator();
            while (iterator.HasNext())
            {
                var song = iterator.Next();
                if (song.Artist != "SP Bala" && song.Artist != "Jagjit Singh" && song.Artist != "Shreya Ghoshal")
                {
                    englishSongs.AddSong(song);
                }
            }
            return englishSongs;
        }
    }
}
