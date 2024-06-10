using System;
using FastEndpoints;
using workshop_final_API.DTO.Requests;
using workshop_final_API.DTO.Responses;
using workshop_final_API.Repositories;

namespace workshop_final_API.Endpoints
{
	public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
	{
        public override void Configure()
        {
            Post("/users");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateUserRequest request, CancellationToken ct)
        {
            int idResult = UserRepository.CreateUser(request.Mail, request.Password);
            await SendAsync(new CreateUserResponse { Id = idResult });
        }
    }
}

