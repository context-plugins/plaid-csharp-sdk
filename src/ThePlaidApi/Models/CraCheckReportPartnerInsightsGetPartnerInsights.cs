using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>partner_insights</c>.
/// </summary>
public record CraCheckReportPartnerInsightsGetPartnerInsights
{
    /// <summary>
    /// The versions of Prism products to evaluate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prism_versions")]
    public PrismVersions? PrismVersions { get; init; }

    /// <summary>
    /// Configuration for the FICO products used in the Partner Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fico")]
    public CraPartnerInsightsFicoInput? Fico { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
