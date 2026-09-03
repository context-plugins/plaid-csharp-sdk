using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Validation.Attributes;

namespace ThePlaidApi.Models;

/// <summary>
/// Configuration parameters for the Cashflow Report product. Currently in closed beta.
/// </summary>
public record LinkTokenCashflowReport
{
    /// <summary>
    /// Number of days of transaction history to request in the Cashflow Report product.
    /// </summary>
    [JsonPropertyName("days_requested")]
    [Minimum(1)]
    [Maximum(730)]
    public int? DaysRequested { get; init; } = 365;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
