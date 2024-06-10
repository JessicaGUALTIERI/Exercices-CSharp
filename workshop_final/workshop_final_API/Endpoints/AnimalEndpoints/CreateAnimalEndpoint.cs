using System;
using FastEndpoints;
using workshop_final_API.DTO.Requests.AnimalRequests;
using workshop_final_API.DTO.Responses.AnimalResponses;
using workshop_final_API.Repositories;

namespace workshop_final_API.Endpoints.AnimalEndpoints
{
	public class CreateAnimalEndpoint : Endpoint<CreateAnimalRequest, CreateAnimalResponse>
	{
        public override void Configure()
        {
            Post("/animals");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateAnimalRequest request, CancellationToken ct)
        {
            int idResult = AnimalRepository.CreateAnimal(request.Name, request.Specie);
            await SendAsync(new CreateAnimalResponse { Id = idResult });
        }
    }
}

