using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Analyzed documents for the associated hit
/// </summary>
public record EntityScreeningHitDocumentsItems
{
    /// <summary>
    /// Summary object reflecting the match result of the associated data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analysis")]
    public MatchSummary? Analysis { get; init; }

    /// <summary>
    /// An official document, usually issued by a governing body or institution, with an associated identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public EntityDocument? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
