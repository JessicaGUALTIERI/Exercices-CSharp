using System;
using FastEndpoints;
using TP_ToDoList.Api.DTO.Requests;
using TP_ToDoList.Api.DTO.Responses;
using TP_ToDoList.Api.Models;

namespace TP_ToDoList.Api.Endpoints
{
	public class TodoGetEndpoint : Endpoint<GetTodoByIdRequest, GetTodoByIdResponse>
    {
        public override void Configure()
        {
            Get("/todos/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetTodoByIdRequest request, CancellationToken ct)
        {
            var todo = new GetTodoByIdResponse
            {
                Title = "Faire les courses",
                Date = DateTime.Now,
                IsDone = false,
                Id = request.Id
            };
            await SendAsync(todo);
        }
    }
}

