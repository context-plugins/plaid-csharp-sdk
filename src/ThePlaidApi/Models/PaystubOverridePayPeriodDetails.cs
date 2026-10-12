using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the pay period.
/// </summary>
public record PaystubOverridePayPeriodDetails
{
    /// <summary>
    /// The amount of the paycheck.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check_amount")]
    public double? CheckAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distribution_breakdown")]
    public IReadOnlyList<PaystubOverrideDistributionBreakdown>? DistributionBreakdown { get; init; }

    /// <summary>
    /// The pay period end date, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format: "yyyy-mm-dd".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// Total earnings before tax/deductions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_earnings")]
    public double? GrossEarnings { get; init; }

    /// <summary>
    /// The date on which the paystub was issued, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_date")]
    public DateTimeOffset? PayDate { get; init; }

    /// <summary>
    /// The frequency at which an individual is paid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_frequency")]
    public PayPeriodDetailsPayFrequency? PayFrequency { get; init; }

    /// <summary>
    /// The date on which the paystub was issued, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format ("yyyy-mm-dd").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_day")]
    public DateTimeOffset? PayDay { get; init; }

    /// <summary>
    /// The pay period start date, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format: "yyyy-mm-dd".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
