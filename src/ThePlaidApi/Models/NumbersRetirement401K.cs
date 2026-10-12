using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Identifying information for transferring holdings from a 401k account to another 401k account or IRA via the manual 401k rollover process.
/// </summary>
public record NumbersRetirement401K
{
    /// <summary>
    /// The Plaid account ID associated with the account numbers
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The plan number for the employer's 401k retirement plan
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan")]
    public string? Plan { get; init; }

    /// <summary>
    /// The full account number for the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
