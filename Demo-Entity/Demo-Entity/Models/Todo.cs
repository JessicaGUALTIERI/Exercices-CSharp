using System;
using System.ComponentModel.DataAnnotations;
using Demo_Entity.Models;

namespace Demo_Entity
{
	public class Todo
	{
		[Key]
		public int Id { get; set; }
		public string? Title { get; set; }
		public DateTime Date { get; set; }
		public bool IsDone { get; set; }
		public virtual Status? Status { get; set; }

		public void Create()
		{
			using (var context = new TodoDbContext())
			{
				context.Todos.Add(this);
				context.SaveChanges();
			}
		}
	}
}

