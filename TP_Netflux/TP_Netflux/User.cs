﻿using System;
namespace TP_Netflux
{
	public class User
	{
		public string MailAdress { get; set; }
		public string Nickname { get; set; }
		public int Watchtime { get; set; }

        public User(string mailAdress, string nickname)
        {
            MailAdress = mailAdress;
            Nickname = nickname;
            Watchtime = 0;
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
	}
}

