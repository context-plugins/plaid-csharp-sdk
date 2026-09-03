using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserThirdPartyTokenRemoveResponse defines the response schema for <c>/user/third_party_token/remove</c>
/// </summary>
public record UserThirdPartyTokenRemoveResponse
{
    /// <summary>
    /// <c>true</c> if the third-party user token was successfully removed.
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
