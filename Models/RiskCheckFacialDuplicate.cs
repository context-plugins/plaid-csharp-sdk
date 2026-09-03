using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for the <c>facial_duplicates</c> attributes of risk check.
/// </summary>
public record RiskCheckFacialDuplicate
{
    /// <summary>
    /// ID of the associated Identity Verification attempt.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Similarity score of the match. Ranges from 0 to 100.
    /// </summary>
    [JsonPropertyName("similarity")]
    public required int Similarity { get; init; }

    /// <summary>
    /// Whether this match occurred after the session was complete. For example, this would be <c>true</c> if a later session ended up matching this one.
    /// </summary>
    [JsonPropertyName("matched_after_completed")]
    public required bool MatchedAfterCompleted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
