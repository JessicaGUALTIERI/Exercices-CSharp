using System;
using FastEndpoints;
using TP_API_Animals.DTO.Requests;
using TP_API_Animals.Models;

namespace TP_API_Animals.Endpoints
{
	public class GetAnimalByIdEndpoint : Endpoint<GetAnimalByIdRequest>
	{
        public override void Configure()
        {
            Get("/animals/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetAnimalByIdRequest request, CancellationToken ct)
        {
            var animal = Animal.GetAnimalById(request.Id);
            await SendAsync(animal);
        }
    }
}

