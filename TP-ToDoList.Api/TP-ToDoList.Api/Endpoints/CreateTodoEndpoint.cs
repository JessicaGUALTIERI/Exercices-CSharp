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
			var todo = new Todo
			{
				Title = request.Title
			};

			var id = todo.Create();

			var response = new CreateTodoResponse
			{
				Id = id
			};

			await SendAsync(response);
		}
	}
}

