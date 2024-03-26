using System;
namespace TP_ToDoList.Api.Models
{
	public class Todo
	{
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public bool IsDone { get; set; }
		public int Id { get; set; }

		public Todo(int id) // Simulation d'un id généré par la BDD
		{
			Id = id;
		}
	}
}

