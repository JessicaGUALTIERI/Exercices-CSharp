using System;
using System.ComponentModel.DataAnnotations;
using TP_Entity_FirstTP.Database;

namespace TP_Entity_FirstTP.Models
{
	public class Animal
	{
		public int AnimalId { get; set; }
		public string? AnimalEspece { get; set; }

		public void Create()
		{
            using (var db = new DatabaseContext())
            {
                db.Animals.Add(this);
                db.SaveChanges();
            }
        }
	}
}

