using System;
using MySqlConnector;
using TP_ToDoList.Api.Database;

namespace TP_ToDoList.Api.Models
{
	public class Todo
	{
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public bool IsDone { get; set; }
		public int Id { get; set; }

		public Todo()
		{
			Date = DateTime.Now;
			IsDone = false;
		}

		public int Create()
		{
			using (var db = TodoDbConnection.GetInstance())
			{
				var query = "INSERT INTO Todo (Date, Title, IsDone) VALUES (@Date, @Title, @IsDone);";
				MySqlCommand command = new MySqlCommand(query, db);
				command.Parameters.AddWithValue("@Date", Date);
				command.Parameters.AddWithValue("@Title", Title);
				command.Parameters.AddWithValue("@IsDone", IsDone);

				Id = command.ExecuteNonQuery();
				return Id;
			}
		}
	}
}

