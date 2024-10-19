using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Iterator.Playlist
{
    //Concrete Song Class
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
        public override string ToString() => $"{Title} by {Artist}";
    }
}
