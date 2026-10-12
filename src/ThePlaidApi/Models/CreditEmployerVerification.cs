using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing employer data.
/// </summary>
public record CreditEmployerVerification
{
    /// <summary>
    /// Name of employer.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
