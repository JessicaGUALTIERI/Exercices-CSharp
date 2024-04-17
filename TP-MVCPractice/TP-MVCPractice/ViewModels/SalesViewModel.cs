using System;
using TP_MVCPractice.Models;

namespace TP_MVCPractice.ViewModels
{
	public class SalesViewModel
	{
		public int SelectedCategoryId { get; set; }
		public IEnumerable<Category> Categories { get; set; } = new List<Category>();
		public int SelectedProductId { get; set; }
		public int QuantityToSell { get; set; }
	}
}

