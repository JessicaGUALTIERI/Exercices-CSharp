using System;
namespace TP_Dates
{
	public class Dates
	{
		public int Jour { get; set; }
		public int Mois { get; set; }
		public int Annee { get; set; }
		public string[] DateArray { get; set; }

		public void AffectDatesParts(string date)
		{
			DateArray = date.Split("-");
			Jour = Convert.ToInt32(DateArray[0]);
			Mois = Convert.ToInt32(DateArray[1]);
			Annee = Convert.ToInt32(DateArray[2]);
		}

		public void DisplayDate()
		{
			Console.WriteLine("La date est : " + DateArray[0] + "-" + DateArray[1] + "-" + DateArray[2]);
		}
	}
}

