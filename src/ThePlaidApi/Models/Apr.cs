using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the APR on the account.
/// </summary>
public record Apr
{
    /// <summary>
    /// Annual Percentage Rate applied.
    /// </summary>
    [JsonPropertyName("apr_percentage")]
    public required double AprPercentage { get; init; }

    /// <summary>
    /// The type of balance to which the APR applies.
    /// </summary>
    [JsonPropertyName("apr_type")]
    public required AprType AprType { get; init; }

    /// <summary>
    /// Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.
    /// </summary>
    [JsonPropertyName("balance_subject_to_apr")]
    public required double? BalanceSubjectToApr { get; init; }

    /// <summary>
    /// Amount of money charged due to interest from last statement.
    /// </summary>
    [JsonPropertyName("interest_charge_amount")]
    public required double? InterestChargeAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
