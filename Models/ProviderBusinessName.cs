using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Name associated with a business
/// </summary>
public record ProviderBusinessName
{
    /// <summary>
    /// Indicates whether this is the primary name for the business.
    /// </summary>
    [JsonPropertyName("is_primary")]
    public required bool IsPrimary { get; init; }

    /// <summary>
    /// The name of the business. Must have at least one character and a maximum length of 500 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
