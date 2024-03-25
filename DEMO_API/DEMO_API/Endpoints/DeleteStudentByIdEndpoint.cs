using System;
using DEMO_API.DTO.Requests;
using DEMO_API.DTO.Responses;
using DEMO_API.Model;
using FastEndpoints;

namespace DEMO_API.Endpoints
{
	public class DeleteStudentByIdEndpoint : Endpoint<DeleteStudentByIdRequest, DeleteStudentByIdResponse>
	{
        public override void Configure()
        {
            Delete("/students/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DeleteStudentByIdRequest request, CancellationToken ct)
        {
            var result = Student.DeleteStudent(request.Id);
            await SendAsync(new DeleteStudentByIdResponse { IsDeleted = result });
        }
    }
}

