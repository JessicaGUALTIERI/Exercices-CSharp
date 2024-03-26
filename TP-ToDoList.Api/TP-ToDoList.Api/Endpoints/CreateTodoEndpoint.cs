using System;
using FastEndpoints;
using TP_ToDoList.Api.DTO.Requests;
using TP_ToDoList.Api.DTO.Responses;
using TP_ToDoList.Api.Models;

namespace TP_ToDoList.Api.Endpoints
{
	public class CreateTodoEndpoint : Endpoint<CreateTodoRequest, CreateTodoResponse>
	{
		public override void Configure()
		{
			Post("/todos");
			AllowAnonymous();
		}

		public override async Task HandleAsync(CreateTodoRequest request, CancellationToken ct)
		{
			var todo = new Todo(100)
			{
				Title = request.Title,
				Date = DateTime.Now,
				IsDone = false
			};
			var response = new CreateTodoResponse
			{
				Id = todo.Id
			};
			await SendAsync(response);
		}
	}
}

