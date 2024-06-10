using System;
using FastEndpoints;
using workshop_final_API.DTO.Requests;
using workshop_final_API.DTO.Responses;
using workshop_final_API.Repositories;

namespace workshop_final_API.Endpoints
{
	public class DeleteUserEndpoint : Endpoint<DeleteUserRequest, DeleteUserResponse>
	{
        public override void Configure()
        {
            Delete("/users/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DeleteUserRequest request, CancellationToken ct)
        {
            bool result = UserRepository.DeleteUser(request.Id);
            await SendAsync(new DeleteUserResponse { IsDeleted = result });
        }
    }
}

