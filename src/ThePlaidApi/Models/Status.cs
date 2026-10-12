using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
public record Status
{
    /// <summary>
    /// Status Code.
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public required string? StatusCode { get; init; }

    /// <summary>
    /// Status Description.
    /// </summary>
    [JsonPropertyName("StatusDescription")]
    public required string? StatusDescription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
