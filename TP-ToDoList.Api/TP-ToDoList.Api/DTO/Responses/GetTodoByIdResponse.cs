using System;
namespace TP_ToDoList.Api.DTO.Responses
{
	public class GetTodoByIdResponse
	{
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsDone { get; set; }
        public int Id { get; set; }
    }
}