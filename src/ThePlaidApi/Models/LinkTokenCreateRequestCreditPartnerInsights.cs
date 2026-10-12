using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Credit Partner Insights product.
/// </summary>
public record LinkTokenCreateRequestCreditPartnerInsights
{
    /// <summary>
    /// The maximum integer number of days of history to compute Credit Partner Insights. Defaults to 180 if not specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
