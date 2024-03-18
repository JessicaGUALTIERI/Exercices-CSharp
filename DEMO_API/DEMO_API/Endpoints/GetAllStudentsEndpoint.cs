using System;
using DEMO_API.Model;
using FastEndpoints;

namespace DEMO_API.Endpoints
{
	public class GetAllStudentsEndpoint : EndpointWithoutRequest
	{
        public override void Configure()
        {
            Get("/students");
            AllowAnonymous(); // Ici, on vérifie le type/rôle de l'utilisateur
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Jessica", Promotion = new Promotion { Name = "CDA" } },
                new Student { Id = 1, Name = "Mathias", Promotion = new Promotion { Name = "CDA" } },
                new Student { Id = 1, Name = "Cyril", Promotion = new Promotion { Name = "CDA" } }
            };

            await SendAsync(students);
        }
    }
}

