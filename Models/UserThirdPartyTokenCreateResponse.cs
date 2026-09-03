using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// UserThirdPartyTokenCreateResponse defines the response schema for <c>/user/third_party_token/create</c>
/// </summary>
public record UserThirdPartyTokenCreateResponse
{
    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// The third-party user token associated with the requested User data.
    /// </summary>
    [JsonPropertyName("third_party_user_token")]
    public required string ThirdPartyUserToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
