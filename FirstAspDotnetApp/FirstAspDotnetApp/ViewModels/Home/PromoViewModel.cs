using System;
namespace FirstAspDotnetApp.ViewModels.Home
{
	public class PromoViewModel
	{
		public List<string> Promos { get; set; }
		public PromoViewModel()
		{
            Promos = new List<string>()
            {
                "Dev Web 2",
                "Dev Web 1",
                "CDA C#",
                "MSRC1 23/25",
                "M2I1 23/25",
                "CDA JAVA",
                "TSSR",
                "BSRC2 22/24"
            };
        }
    }
}

