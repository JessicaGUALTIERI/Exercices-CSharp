using System;
namespace TP_Netflux
{
	public class Movie : Content
	{
		public string NameOfTheDirector { get; set; }

        public Movie(string name, int durationInMinutes, string nameOfTheDirector)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            NameOfTheDirector = nameOfTheDirector;
            NumberOfViews = 0;
        }
    }
}

