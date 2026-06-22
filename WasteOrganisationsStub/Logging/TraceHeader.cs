using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WasteOrganisationsStub.Logging;

[ExcludeFromCodeCoverage]
public class TraceHeader
{
    [ConfigurationKeyName("TraceHeader")]
    [Required]
    public required string Name { get; set; }
}
