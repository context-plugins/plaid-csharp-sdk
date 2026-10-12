using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Cashflow Insights product.
/// </summary>
public record LinkTokenCreateRequestCraOptionsCashflowInsights
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
