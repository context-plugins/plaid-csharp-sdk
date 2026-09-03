using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the rate at which an individual is paid.
/// </summary>
public record PayrollIncomeRateOfPay
{
    /// <summary>
    /// The rate at which an employee is paid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_rate")]
    public string? PayRate { get; init; }

    /// <summary>
    /// The amount at which an employee is paid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pay_amount")]
    public double? PayAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
