using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// LinkTokenCreateResponse defines the response schema for <c>/link/token/create</c>
/// </summary>
public record LinkTokenCreateResponse
{
    /// <summary>
    /// A <c>link_token</c>, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>, which can be exchanged for an <c>access_token</c>.
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// The expiration date and time for the <c>link_token</c>, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format. By default, a <c>link_token</c> created to generate a <c>public_token</c> that will be exchanged for a new <c>access_token</c> expires after 4 hours, and a <c>link_token</c> created for an existing Item (such as when updating an existing <c>access_token</c> by launching Link in update mode) expires after 30 minutes. If using <see href="https://plaid.com/docs/link/hosted-link/">Hosted Link</see>, the <c>link_token</c> will expire at the same time as the Hosted Link URL, and you can customize the duration using the <c>hosted_link.url_lifetime_seconds</c> option in the request. If using Link Delivery (beta), the <c>link_token</c> will expire by default after 24 hours if sent via SMS and after 7 days if sent via email. If using Identity Verification, Link token expiration will not be enforced; an Identity Verification Link session can be created with an expired Link token.
    /// </summary>
    [JsonPropertyName("expiration")]
    public required DateTimeOffset Expiration { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// A URL of a Plaid-hosted Link flow that will use the Link token returned by this request. Only present if the session is enabled for Hosted Link. To enable the session for Hosted Link, send a <c>hosted_link</c> object in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hosted_link_url")]
    public string? HostedLinkUrl { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
