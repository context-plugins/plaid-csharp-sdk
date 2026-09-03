using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// SandboxPublicTokenCreateResponse defines the response schema for <c>/sandbox/public_token/create</c>
/// </summary>
public record SandboxPublicTokenCreateResponse
{
    /// <summary>
    /// A public token that can be exchanged for an access token using <c>/item/public_token/exchange</c>
    /// </summary>
    [JsonPropertyName("public_token")]
    public required string PublicToken { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
