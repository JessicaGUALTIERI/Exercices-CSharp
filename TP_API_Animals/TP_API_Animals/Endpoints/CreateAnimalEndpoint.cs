using System;
using FastEndpoints;
using TP_API_Animals.DTO.Requests;
using TP_API_Animals.DTO.Responses;
using TP_API_Animals.Models;

namespace TP_API_Animals.Endpoints
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
            var idResult = Animal.CreateAnimal(request.Name, request.Specie);
            await SendAsync(new CreateAnimalResponse { Id = idResult });
        }
    }
}

