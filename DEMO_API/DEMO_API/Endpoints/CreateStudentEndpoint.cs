using System;
using DEMO_API.DTO.Requests;
using DEMO_API.DTO.Responses;
using DEMO_API.Model;
using FastEndpoints;

namespace DEMO_API.Endpoints
{
	public class CreateStudentEndpoint : Endpoint<CreateStudentRequest, CreateStudentResponse>
	{
		public override void Configure()
		{
			Post("/students");
			AllowAnonymous();
		}

		public override async Task HandleAsync(CreateStudentRequest request, CancellationToken ct)
		{
			var idResult = Student.CreateStudent(request.Name, request.Promotion);

			await SendAsync(new CreateStudentResponse { Id = idResult});
		}
	}
}

