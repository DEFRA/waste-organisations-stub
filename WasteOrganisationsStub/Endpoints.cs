using System.Diagnostics.CodeAnalysis;
using System.Net.Mime;

namespace WasteOrganisationsStub;

[ExcludeFromCodeCoverage]
public static class Endpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("organisations", () => Results.NotFound());
        app.MapGet("organisations/{id:guid}", GetOrganisation);
    }

    private static IResult GetOrganisation(Guid id)
    {
        try
        {
            return Results.Content(
                EmbeddedStubData.GetBody($"_organisations_{id}.json"),
                MediaTypeNames.Application.Json
            );
        }
        catch (InvalidOperationException)
        {
            return Results.NotFound();
        }
    }
}