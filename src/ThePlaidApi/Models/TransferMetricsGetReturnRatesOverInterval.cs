using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details regarding return rates.
/// </summary>
public record TransferMetricsGetReturnRatesOverInterval
{
    /// <summary>
    /// The overall return rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overall_return_rate")]
    public string? OverallReturnRate { get; init; }

    /// <summary>
    /// The unauthorized return rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unauthorized_return_rate")]
    public string? UnauthorizedReturnRate { get; init; }

    /// <summary>
    /// The administrative return rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_return_rate")]
    public string? AdministrativeReturnRate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
