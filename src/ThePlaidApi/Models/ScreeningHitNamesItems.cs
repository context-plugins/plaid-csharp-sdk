using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Analyzed name information for the associated hit
/// </summary>
public record ScreeningHitNamesItems
{
    /// <summary>
    /// Summary object reflecting the match result of the associated data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analysis")]
    public MatchSummary? Analysis { get; init; }

    /// <summary>
    /// Name information for the associated individual watchlist hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IndividualScreeningHitNames? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
