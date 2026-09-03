using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// CreditRelayRemoveResponse defines the response schema for <c>/credit/relay/remove</c>
/// </summary>
public record CreditRelayRemoveResponse
{
    /// <summary>
    /// <c>true</c> if the relay token was successfully removed.
    /// </summary>
    [JsonPropertyName("removed")]
    public required bool Removed { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
