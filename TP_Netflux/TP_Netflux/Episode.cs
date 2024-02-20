﻿using System;
namespace TP_Netflux
{
	public class Episode : Content
	{
        public string ShowName { get; set; }
        public int NumberOfTheSeason { get; set; }
		public int NumberOfTheEpisode { get; set; }
		public bool IsANetfluxSerie { get; set; }

        public Episode(string name, TVShow show, int durationInMinutes, int numberOfTheSeason, int numberOfTheEpisode)
        {
            Name = name;
            ShowName = show.Name;
            DurationInMinutes = durationInMinutes;
            NumberOfTheSeason = numberOfTheSeason;
            NumberOfTheEpisode = numberOfTheEpisode;
            NumberOfViews = 0;
            AddToTVShow(show);
        }

        public override void DisplayNumberOfViews()
        {
            Console.Write("The episode of " + ShowName + " ");
            base.DisplayNumberOfViews();
        }

        public void AddToTVShow(TVShow show)
        {
            show.Episodes.Add(this);
        }
    }
}

