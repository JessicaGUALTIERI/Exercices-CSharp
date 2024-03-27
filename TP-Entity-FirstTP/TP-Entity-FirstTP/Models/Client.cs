using System;
using System.ComponentModel.DataAnnotations;
using TP_Entity_FirstTP.Database;

namespace TP_Entity_FirstTP.Models
{
	public class Client
	{
		public int ClientId { get; set; }
		public string? ClientNom { get; set; }

        public void Create()
        {
            using (var db = new DatabaseContext())
            {
                db.Clients.Add(this);
                db.SaveChanges();
            }
        }
    }
}

