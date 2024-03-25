using System;
using DEMO_API.DTO.Requests;
using DEMO_API.Model;
using FastEndpoints;

namespace DEMO_API.Endpoints
{
	public class GetStudentByIdEndpoint : Endpoint<GetStudentByIdRequest>
	{
        public override void Configure()
        {
            Get("/students/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetStudentByIdRequest request, CancellationToken ct)
        {
            var students = Student.GetStudentById(request.Id);

            await SendAsync(students);
        }
    }
}

