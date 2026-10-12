using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Analyzed phone numbers for the associated hit
/// </summary>
public record EntityScreeningHitsPhoneNumberItems
{
    /// <summary>
    /// Summary object reflecting the match result of the associated data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analysis")]
    public MatchSummary? Analysis { get; init; }

    /// <summary>
    /// Phone number information associated with the entity screening hit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public EntityScreeningHitPhoneNumbers? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
