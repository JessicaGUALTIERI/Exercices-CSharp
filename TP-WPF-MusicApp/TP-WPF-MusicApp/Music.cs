using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WPF_MusicApp
{
    internal class Music
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public ulong Duration { get; set; }
        public ulong NumberOfStreams { get; set; }

        public Music(string Artist, string Title, string Genre, ulong Duration, ulong NumberOfStreams)
        {
            this.Artist = Artist;
            this.Title = Title;
            this.Genre = Genre;
            this.Duration = Duration;
            this.NumberOfStreams = NumberOfStreams;
        }
    }
}
