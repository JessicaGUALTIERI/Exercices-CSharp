using System;
namespace TP_Netflux
{
	public class Movie : Content, ISelectable
	{
		public string NameOfTheDirector { get; set; }
        public static List<Movie> AllMovies { get; set; }

        public static void Initialization()
        {
            AllMovies = new List<Movie>();
        }

        public Movie(string name, int durationInMinutes, string nameOfTheDirector)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            NameOfTheDirector = nameOfTheDirector;
            NumberOfViews = 0;
            AllMovies.Add(this);
        }

        public static void DisplayAllMovies()
        {
            Console.WriteLine("Netflux contains the following movies :");
            foreach (Movie movie in AllMovies)
            {
                Console.WriteLine("\t- " + movie.Name + "(watched " + movie.NumberOfViews + " times)");
            }
        }

        public void Selected(User user)
        {
            user.Watch(this);
        }
    }
}