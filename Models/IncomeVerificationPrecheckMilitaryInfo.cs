using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about military info in the income verification precheck.
/// </summary>
public record IncomeVerificationPrecheckMilitaryInfo
{
    /// <summary>
    /// Is the user currently active duty in the US military
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_active_duty")]
    public bool? IsActiveDuty { get; init; }

    /// <summary>
    /// If the user is currently serving in the US military, the branch of the military in which they are serving
    /// Valid values: 'AIR FORCE', 'ARMY', 'COAST GUARD', 'MARINES', 'NAVY', 'UNKNOWN'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("branch")]
    public string? Branch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
