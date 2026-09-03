using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// BeaconAccountRiskEvaluateResponse defines the response schema for <c>/beacon/account_risk/v1/evaluate</c>
/// </summary>
public record BeaconAccountRiskEvaluateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The accounts for which a risk evaluation has been requested.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<BeaconAccountRiskEvaluateAccount> Accounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
