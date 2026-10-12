using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// WebhookVerificationKeyGetResponse defines the response schema for <c>/webhook_verification_key/get</c>
/// </summary>
public record WebhookVerificationKeyGetResponse
{
    /// <summary>
    /// A JSON Web Key (JWK) that can be used in conjunction with <see href="https://jwt.io/#libraries-io">JWT libraries</see> to verify Plaid webhooks
    /// </summary>
    [JsonPropertyName("key")]
    public required JwkPublicKey Key { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
