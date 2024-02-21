using System;
namespace TP_Netflux
{
	public class TVShow : ISelectable
	{
		public string Name { get; set; }
		public List<Episode> Episodes { get; set; }

		public TVShow(string name)
		{
			Name = name;
			Episodes = new List<Episode>();
		}

		public void DisplayAllEpisodes()
		{
			Console.WriteLine(Name + " contains the following episodes : ");
			foreach (Episode episode in Episodes)
			{
				Console.WriteLine("\t- " + episode.Name + "(watched " + episode.NumberOfViews + " times)");
			}
		}

		public void Selected(User user)
		{
			if (user.ViewingHistory.ContainsKey(this))
			{
				int lastEpisode = user.ViewingHistory[this];
				user.Watch(Episodes[lastEpisode]);
				user.ViewingHistory[this] =  lastEpisode + 1;
			} else
			{
				user.Watch(Episodes[0]);
				user.ViewingHistory.Add(this, 1);
			}
		}
	}
}

