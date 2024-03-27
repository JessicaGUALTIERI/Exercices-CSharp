using System;
using System.ComponentModel.DataAnnotations;

namespace TP_Entity_FirstTP.Models
{
	public class Reservation
	{
		public int ReservationId { get; set; }
		public virtual Animal? ReservationAnimal { get; set; }
		public virtual Client? ReservationClient { get; set; }
	}
}

