using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents Trust Index Subscore.
/// </summary>
public record TrustIndexSubscore
{
    /// <summary>
    /// The subscore score.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
