using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Object containing information on account fee transactions for the 401k account.
/// </summary>
public record InvestmentsAuth401KFeeDetails
{
    /// <summary>
    /// Number of account fee transactions on this account, for the past 12 months.
    /// </summary>
    [JsonPropertyName("account_fee_count_12m")]
    public required int AccountFeeCount12M { get; init; }

    /// <summary>
    /// Sum of account fee transactions on this account, for the past 12 months.
    /// </summary>
    [JsonPropertyName("account_fee_amount_12m")]
    public required double AccountFeeAmount12M { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
