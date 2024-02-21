using System;
namespace TP_Netflux
{
	public class Episode : Content
	{
        public string ShowName { get; set; }
        public int NumberOfTheSeason { get; set; }
		public int NumberOfTheEpisode { get; set; }

        public Episode(string name, TVShow show, int durationInMinutes, int numberOfTheSeason, int numberOfTheEpisode)
        {
            Name = name;
            ShowName = show.Name;
            DurationInMinutes = durationInMinutes;
            NumberOfTheSeason = numberOfTheSeason;
            NumberOfTheEpisode = numberOfTheEpisode;
            NumberOfViews = 0;
            show.Episodes.Add(this);
        }
    }
}

