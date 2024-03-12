using System;
namespace TP_Lambda_MusicApp
{
	public class Database
	{
		public static List<Music> Musics { get; set; }

        public static void Initialize()
        {
            Musics = new List<Music> {
                new Music("Edith WHISKERS", "Home", "Folk", 3, 1802),
                new Music("Kesha", "Tik Tok", "Pop", 3, 190000),
                new Music("Britney SPEARS", "Gimme More", "Pop", 4, 200000),
                new Music("Orelsan", "Notes pour trop tard", "Rap", 7, 1802000)
            };
        }

        public static Action<string> SearchGenre = (searchQuery) =>
        {
            Console.WriteLine("Results for \"" + searchQuery + "\" :");
            foreach (Music music in Musics.Where(x => x.Genre == searchQuery))
            {
                Console.WriteLine("\t- " + music.Title + " - " + music.Artist);
            }
        };

        public static Action<string> SearchTitle = (searchQuery) =>
        {
            Console.WriteLine("Results for \"" + searchQuery + "\" :");
            foreach (Music music in Musics.Where(x => x.Title.Contains(searchQuery)))
            {
                Console.WriteLine("\t- " + music.Title + " - " + music.Artist);
            }
        };

        public static void SortByNumberOfStreams()
        {
            List<Music> MusicsSortedByNumberOfStreams = Musics.OrderByDescending(x => x.NumberOfStreams).ToList();
            foreach (Music music in MusicsSortedByNumberOfStreams)
            {
                Console.WriteLine(music.Title + " - " + music.Artist + " (" + music.NumberOfStreams + ")");
            }
        }
    }
}

