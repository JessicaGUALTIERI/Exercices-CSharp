using System;
namespace TP_MVCPractice.Models
{
	public class Transaction
	{
		public int Id { get; set; }
		public DateTime TimeStamp { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; } = "";
		public double Price { get; set; }
		public int QuantityBefore { get; set; }
		public int QuantitySold { get; set; }
		public string CashierName { get; set; } = "";
	}
}

