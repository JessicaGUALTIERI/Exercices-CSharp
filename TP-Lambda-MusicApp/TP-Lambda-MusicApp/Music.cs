using System;
namespace TP_Lambda_MusicApp
{
	public class Music
	{
		public string Artist { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }
		public int Duration { get; set; }
		public int NumberOfStreams { get; set; }

		public Music(string Artist, string Title, string Genre, int Duration, int NumberOfStreams)
		{
			this.Artist = Artist;
			this.Title = Title;
			this.Genre = Genre;
			this.Duration = Duration;
			this.NumberOfStreams = NumberOfStreams;
		}
	}
}

