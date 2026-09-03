using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Deprecated, specify <c>partner_insights.prism_versions</c> instead.
/// </summary>
public record CraCheckReportPartnerInsightsGetOptions
{
    /// <summary>
    /// Deprecated, use <c>partner_insights.prism_versions</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prism_versions")]
    public PrismVersionsDeprecated? PrismVersions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
