using System;
namespace TP_Dates
{
	public class Dates
	{
		public string Jour { get; set; }
		public string Mois { get; set; }
		public string Annee { get; set; }
		public string[] DateArray { get; set; }

		public void AffectDatesParts(string date)
		{
			DateArray = date.Split("-");
			Jour = DateArray[0];
			Mois = DateArray[1];
			Annee = DateArray[2];
		}
	}
}

