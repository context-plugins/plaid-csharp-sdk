using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing data from a paystub.
/// </summary>
public record PaystubOverride
{
    /// <summary>
    /// The employer on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employer")]
    public PaystubOverrideEmployer? Employer { get; init; }

    /// <summary>
    /// The employee on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee")]
    public PaystubOverrideEmployee? Employee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_breakdown")]
    public IReadOnlyList<IncomeBreakdown>? IncomeBreakdown { get; init; }

    /// <summary>
    /// An object representing information about the net pay amount on the paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_pay")]
    public PaystubOverrideNetPay? NetPay { get; init; }

    /// <summary>
    /// An object with the deduction information found on a paystub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deductions")]
    public PaystubOverrideDeductions? Deductions { get; init; }

    /// <summary>
    /// An object representing both a breakdown of earnings on a paystub and the total earnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earnings")]
    public PaystubOverrideEarnings? Earnings { get; init; }

    /// <summary>
    /// Details about the pay period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_period_details")]
    public PaystubOverridePayPeriodDetails? PayPeriodDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
