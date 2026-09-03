using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Status information about the account and routing number in the Plaid network.
/// </summary>
public record VerificationInsightsNetworkStatus
{
    /// <summary>
    /// Indicates whether we found at least one matching account for the ACH account and routing number.
    /// </summary>
    [JsonPropertyName("has_numbers_match")]
    public required bool HasNumbersMatch { get; init; }

    /// <summary>
    /// Indicates if at least one matching account for the ACH account and routing number is already verified.
    /// </summary>
    [JsonPropertyName("is_numbers_match_verified")]
    public required bool IsNumbersMatchVerified { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
