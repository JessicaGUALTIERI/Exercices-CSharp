using System;
namespace Workshop_MVC_Project.Models
{
	public class TaskModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsCompleted { get; set; }
		public DateOnly DueDate { get; set; }
	}
}

