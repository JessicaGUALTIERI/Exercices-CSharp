using System;
using System.ComponentModel.DataAnnotations;

namespace TP_ToDoList.Api.DTO.Requests
{
	public class CreateTodoRequest
	{
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
    }
}

