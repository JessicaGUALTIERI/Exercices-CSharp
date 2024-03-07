using System;
namespace FirstAspDotnetApp.ViewModels.Home
{
	public class IndexViewModel
	{
		public string? CompanyName { get; set; }

		public IndexViewModel(string CompanyName)
		{
			this.CompanyName = CompanyName;
		}
	}
}

