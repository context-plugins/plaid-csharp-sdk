using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional account fee and contribution information for 401k type accounts.
/// </summary>
public record InvestmentsAuthAccountDetails401K
{
    /// <summary>
    /// The ID of the 401k account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// Object containing information on account fee transactions for the 401k account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee_details")]
    public InvestmentsAuth401KFeeDetails? FeeDetails { get; init; }

    /// <summary>
    /// Object containing information on contribution transactions for the 401k account. Note that the sum fields in this object represent the total of absolute contribution values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contribution_details")]
    public InvestmentsAuth401KContributionDetails? ContributionDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
