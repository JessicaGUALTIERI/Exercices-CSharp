using System;
namespace TP_Netflux
{
	public class User
	{
		public string MailAdress { get; set; }
		public string Nickname { get; set; }
		public int Watchtime { get; set; }
		public Dictionary<TVShow, int> ViewingHistory { get; set; }

		public User(string mailAdress, string nickname)
        {
            MailAdress = mailAdress;
            Nickname = nickname;
            Watchtime = 0;
			ViewingHistory = new Dictionary<TVShow, int>();
        }

        public void Watch(Content content)
		{
			Watchtime += content.DurationInMinutes;
			content.NumberOfViews++;
		}

		public void DisplayWatchtime()
		{
			Console.WriteLine(Nickname + " has been watching for " + Watchtime + " minutes of content on Netflux.");
		}

		public void Select(ISelectable content)
		{
			content.Selected(this);
		}
	}
}

