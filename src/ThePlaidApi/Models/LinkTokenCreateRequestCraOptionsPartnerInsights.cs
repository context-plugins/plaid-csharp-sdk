using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Credit Partner Insights product.
/// </summary>
public record LinkTokenCreateRequestCraOptionsPartnerInsights
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
