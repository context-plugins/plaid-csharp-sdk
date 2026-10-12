using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>options</c>.
/// </summary>
public record CraCheckReportCashflowInsightsGetOptions
{
    /// <summary>
    /// The version of cashflow attributes. Required if using Cash Flow Insights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes_version")]
    public CashflowAttributesVersion? AttributesVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
