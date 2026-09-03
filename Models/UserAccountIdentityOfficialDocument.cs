using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Official identity document edit statistics.
/// </summary>
public record UserAccountIdentityOfficialDocument
{
    /// <summary>
    /// Edit counts over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn")]
    public UserAccountIdentityEditCounts? Ssn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
