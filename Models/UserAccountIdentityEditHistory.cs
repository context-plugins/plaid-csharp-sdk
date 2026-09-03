using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Statistics tracking the number of edits made to identity fields over various time periods.
/// </summary>
public record UserAccountIdentityEditHistory
{
    /// <summary>
    /// Edit counts over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public UserAccountIdentityEditCounts? Name { get; init; }

    /// <summary>
    /// Edit counts over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public UserAccountIdentityEditCounts? Address { get; init; }

    /// <summary>
    /// Edit counts over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public UserAccountIdentityEditCounts? Email { get; init; }

    /// <summary>
    /// Edit counts over various time periods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public UserAccountIdentityEditCounts? DateOfBirth { get; init; }

    /// <summary>
    /// Official identity document edit statistics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("official_document")]
    public UserAccountIdentityOfficialDocument? OfficialDocument { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
