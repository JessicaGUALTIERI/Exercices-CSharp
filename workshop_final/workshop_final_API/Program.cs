
using FastEndpoints;

namespace workshop_final_API;

public class Program
{
    public static void Main(string[] args)
    {
        var bld = WebApplication.CreateBuilder();
        bld.Services.AddFastEndpoints();

        var app = bld.Build();
        app.UseFastEndpoints();
        app.Run();
    }
}

