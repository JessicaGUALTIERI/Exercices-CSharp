using System;
using FastEndpoints;
using TP_API_Animals.DTO.Requests;
using TP_API_Animals.DTO.Responses;
using TP_API_Animals.Models;

namespace TP_API_Animals.Endpoints
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
            var result = Animal.DeleteAnimal(request.Id);
            await SendAsync(new DeleteAnimalResponse { IsDeleted = result });
        }
    }
}

