using System;
using FastEndpoints;
using TP_API_Animals.Models;

namespace TP_API_Animals.Endpoints
{
	public class GetAllAnimalsEndpoint : EndpointWithoutRequest
	{
        public override void Configure()
        {
            Get("/animals");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal { Id = 1, Name = "Titi", Specie = "Cat" },
                new Animal { Id = 2, Name = "Marley", Specie = "Cat" },
                new Animal { Id = 3, Name = "Carlos", Specie = "Cat" }
            };

            await SendAsync(animals);
        }
    }
}

