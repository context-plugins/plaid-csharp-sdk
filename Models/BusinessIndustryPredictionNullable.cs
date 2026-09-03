using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Nullable industry prediction details.
/// </summary>
public record BusinessIndustryPredictionNullable
{
    /// <summary>
    /// NAICS code for the predicted business industry.
    /// </summary>
    [JsonPropertyName("code")]
    public required int Code { get; init; }

    /// <summary>
    /// The business industry classification of the predicted NAICS code.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
