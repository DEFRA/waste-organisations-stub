using WasteOrganisationsStub;
using WasteOrganisationsStub.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();
builder.Services.AddCustomTrustStore(); // This must happen before Mongo and Http client connections
builder.ConfigureLoggingAndTracing();
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapHealthChecks("/health");
app.MapHealthChecks("/health/authorized");
app.MapEndpoints();
app.Run();