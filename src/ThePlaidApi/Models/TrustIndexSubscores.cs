using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains sub-score metadata.
/// </summary>
public record TrustIndexSubscores
{
    /// <summary>
    /// Represents Trust Index Subscore.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_and_connection")]
    public TrustIndexSubscore? DeviceAndConnection { get; init; }

    /// <summary>
    /// Represents Trust Index Subscore.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account_insights")]
    public TrustIndexSubscore? BankAccountInsights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
