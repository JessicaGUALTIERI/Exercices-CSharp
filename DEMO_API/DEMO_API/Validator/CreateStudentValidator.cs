using System;
using DEMO_API.DTO.Requests;
using FastEndpoints;
using FluentValidation;

namespace DEMO_API.Validator
{
	public class CreateStudentValidator : Validator<CreateStudentRequest>
	{
		public CreateStudentValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Name cannot be empty")
				.MinimumLength(2).WithMessage("Length should be at last 2 characters long");
		}
	}
}

