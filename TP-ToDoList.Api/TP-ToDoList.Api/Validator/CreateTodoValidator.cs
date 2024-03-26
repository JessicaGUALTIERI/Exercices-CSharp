using System;
using FastEndpoints;
using FluentValidation;
using TP_ToDoList.Api.DTO.Requests;

namespace TP_ToDoList.Api.Validator
{
	public class CreateTodoValidator : Validator<CreateTodoRequest>
	{
		public CreateTodoValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty()
				.WithMessage("Title is required")
				.MaximumLength(50)
				.WithMessage("Title must be shorter than 50 characters");
		}
	}
}

