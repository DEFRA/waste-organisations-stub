using WasteOrganisationsStub;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(logging => logging.AddConsole().AddDebug());
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapHealthChecks("/health");
app.MapHealthChecks("/health/authorized");
app.MapEndpoints();
app.Run();