using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details regarding authorization usage.
/// </summary>
public record TransferMetricsGetAuthorizationUsage
{
    /// <summary>
    /// The daily credit utilization formatted as a decimal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("daily_credit_utilization")]
    public string? DailyCreditUtilization { get; init; }

    /// <summary>
    /// The daily debit utilization formatted as a decimal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("daily_debit_utilization")]
    public string? DailyDebitUtilization { get; init; }

    /// <summary>
    /// The monthly credit utilization formatted as a decimal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_credit_utilization")]
    public string? MonthlyCreditUtilization { get; init; }

    /// <summary>
    /// The monthly debit utilization formatted as a decimal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_debit_utilization")]
    public string? MonthlyDebitUtilization { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
