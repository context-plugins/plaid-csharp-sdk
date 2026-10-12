using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// ItemPublicTokenCreateResponse defines the response schema for <c>/item/public_token/create</c>
/// </summary>
public record ItemPublicTokenCreateResponse
{
    /// <summary>
    /// A <c>public_token</c> for the particular Item corresponding to the specified <c>access_token</c>
    /// </summary>
    [JsonPropertyName("public_token")]
    public required string PublicToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public DateTimeOffset? Expiration { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
