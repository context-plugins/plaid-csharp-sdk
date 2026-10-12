using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the Monitoring Insights for the given Item
/// </summary>
public record MonitoringInsights
{
    /// <summary>
    /// An object representing the income subcategory of the report
    /// </summary>
    [JsonPropertyName("income")]
    public required MonitoringIncomeInsights Income { get; init; }

    /// <summary>
    /// An object representing the loan exposure subcategory of the report
    /// </summary>
    [JsonPropertyName("loans")]
    public required MonitoringLoanInsights Loans { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
