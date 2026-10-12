using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details regarding return rates.
/// </summary>
public record TransferMetricsGetReturnRates
{
    /// <summary>
    /// Details regarding return rates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_60d")]
    public TransferMetricsGetReturnRatesOverInterval? Last60D { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
