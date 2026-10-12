using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Detailed information for the bank employment.
/// </summary>
public record CreditBankEmployment
{
    /// <summary>
    /// A unique identifier for the bank employment.
    /// </summary>
    [JsonPropertyName("bank_employment_id")]
    public required string BankEmploymentId { get; init; }

    /// <summary>
    /// Plaid's unique identifier for the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Object containing employer data.
    /// </summary>
    [JsonPropertyName("employer")]
    public required CreditBankEmployer Employer { get; init; }

    /// <summary>
    /// The date of the most recent deposit from this employer.
    /// </summary>
    [JsonPropertyName("latest_deposit_date")]
    public required DateTimeOffset LatestDepositDate { get; init; }

    /// <summary>
    /// The date of the earliest deposit from this employer from within the period of the days requested.
    /// </summary>
    [JsonPropertyName("earliest_deposit_date")]
    public required DateTimeOffset EarliestDepositDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
