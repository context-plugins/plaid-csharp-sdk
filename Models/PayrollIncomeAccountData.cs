using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing account level data.
/// </summary>
public record PayrollIncomeAccountData
{
    /// <summary>
    /// ID of the payroll provider account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// An object representing the rate at which an individual is paid.
    /// </summary>
    [JsonPropertyName("rate_of_pay")]
    public required PayrollIncomeRateOfPay RateOfPay { get; init; }

    /// <summary>
    /// The frequency at which an individual is paid.
    /// </summary>
    [JsonPropertyName("pay_frequency")]
    public required string? PayFrequency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
