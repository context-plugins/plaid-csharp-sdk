using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Represents a calculated Trust Index Score.
/// </summary>
public record TrustIndex
{
    /// <summary>
    /// The overall trust index score.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    /// <summary>
    /// The versioned name of the Trust Index model used for scoring.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Contains sub-score metadata.
    /// </summary>
    [JsonPropertyName("subscores")]
    public required TrustIndexSubscores? Subscores { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
