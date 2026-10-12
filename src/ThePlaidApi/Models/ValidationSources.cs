using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record ValidationSources
{
    /// <summary>
    /// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
    /// </summary>
    [JsonPropertyName("VALIDATION_SOURCE")]
    public required IReadOnlyList<ValidationSource> ValidationSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
