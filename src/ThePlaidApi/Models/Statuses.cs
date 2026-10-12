using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A collection of STATUS containers.
/// </summary>
public record Statuses
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("STATUS")]
    public required Status Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
