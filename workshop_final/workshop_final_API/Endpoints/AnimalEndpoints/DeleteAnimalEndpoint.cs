using System;
using FastEndpoints;
using workshop_final_API.DTO.Requests.AnimalRequests;
using workshop_final_API.DTO.Requests.UserRequests;
using workshop_final_API.Repositories;

namespace workshop_final_API.DTO.Responses.AnimalResponses
{
	public class DeleteAnimalEndpoint : Endpoint<DeleteAnimalRequest, DeleteAnimalResponse>
	{
        public override void Configure()
        {
            Delete("/animals/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DeleteAnimalRequest request, CancellationToken ct)
        {
            bool result = AnimalRepository.DeleteAnimal(request.Id);
            await SendAsync(new DeleteAnimalResponse { IsDeleted = result });
        }
    }
}

