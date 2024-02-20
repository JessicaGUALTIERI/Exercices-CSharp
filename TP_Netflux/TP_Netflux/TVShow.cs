using System;
namespace TP_Netflux
{
	public class TVShow
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
	}
}

