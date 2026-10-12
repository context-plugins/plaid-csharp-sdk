using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Response data for <c>/session/token/create</c> intended for use with the Link SDK.
/// </summary>
public record SessionTokenCreateResponseLink
{
    /// <summary>
    /// A Link token, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>.
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// The expiration date for the <c>link_token</c>, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format. A <c>link_token</c> created to generate a <c>public_token</c> that will be exchanged for a new <c>access_token</c> expires after 4 hours. A <c>link_token</c> created for an existing Item (such as when updating an existing <c>access_token</c> by launching Link in update mode) expires after 30 minutes.
    /// </summary>
    [JsonPropertyName("expiration")]
    public required DateTimeOffset Expiration { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
