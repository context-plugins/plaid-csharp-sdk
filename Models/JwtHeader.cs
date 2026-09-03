using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A JWT Header, used for webhook validation
/// </summary>
public record JwtHeader
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("kid")]
    public required string Kid { get; init; }

    [JsonPropertyName("alg")]
    public required string Alg { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
