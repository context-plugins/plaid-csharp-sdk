using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing details that can be found on the paystub.
/// </summary>
public record PaystubDetails
{
    /// <summary>
    /// Beginning date of the pay period on the paystub in the 'YYYY-MM-DD' format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_period_start_date")]
    public DateTimeOffset? PayPeriodStartDate { get; init; }

    /// <summary>
    /// Ending date of the pay period on the paystub in the 'YYYY-MM-DD' format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_period_end_date")]
    public DateTimeOffset? PayPeriodEndDate { get; init; }

    /// <summary>
    /// Pay date on the paystub in the 'YYYY-MM-DD' format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_date")]
    public DateTimeOffset? PayDate { get; init; }

    /// <summary>
    /// The name of the payroll provider that generated the paystub, e.g. ADP
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paystub_provider")]
    public string? PaystubProvider { get; init; }

    /// <summary>
    /// The frequency at which the employee is paid. Possible values: <c>MONTHLY</c>, <c>BI-WEEKLY</c>, <c>WEEKLY</c>, <c>SEMI-MONTHLY</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_frequency")]
    public PaystubPayFrequency? PayFrequency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
