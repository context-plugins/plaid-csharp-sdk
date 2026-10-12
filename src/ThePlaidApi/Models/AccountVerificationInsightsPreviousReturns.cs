using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about known ACH returns for the account and routing number.
/// </summary>
public record AccountVerificationInsightsPreviousReturns
{
    /// <summary>
    /// Indicates whether Plaid's data sources include a known administrative ACH return for this account and routing number.
    /// </summary>
    [JsonPropertyName("has_previous_administrative_return")]
    public required bool HasPreviousAdministrativeReturn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
