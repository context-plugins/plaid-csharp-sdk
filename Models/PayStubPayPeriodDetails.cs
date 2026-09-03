using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the pay period.
/// </summary>
public record PayStubPayPeriodDetails
{
    /// <summary>
    /// The amount of the paycheck.
    /// </summary>
    [JsonPropertyName("pay_amount")]
    public required double? PayAmount { get; init; }

    [JsonPropertyName("distribution_breakdown")]
    public required IReadOnlyList<PayStubDistributionBreakdown> DistributionBreakdown { get; init; }

    /// <summary>
    /// The date on which the pay period ended, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("end_date")]
    public required DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// Total earnings before tax/deductions.
    /// </summary>
    [JsonPropertyName("gross_earnings")]
    public required double? GrossEarnings { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the net pay. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The date on which the pay stub was issued, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("pay_date")]
    public required DateTimeOffset? PayDate { get; init; }

    /// <summary>
    /// The frequency at which an individual is paid.
    /// </summary>
    [JsonPropertyName("pay_frequency")]
    public required string? PayFrequency { get; init; }

    /// <summary>
    /// The explicit pay basis on the paystub (if present).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_basis")]
    public CreditPayStubPayBasisType? PayBasis { get; init; }

    /// <summary>
    /// The date on which the pay period started, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the net pay. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
