using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record Individual
{
    /// <summary>
    /// Parent container for name that allows for choice group between parsed and unparsed containers.
    /// </summary>
    [JsonPropertyName("NAME")]
    public required Name Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
