using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// LinkTokenGetResponse defines the response schema for <c>/link/token/get</c>
/// </summary>
public record LinkTokenGetResponse
{
    /// <summary>
    /// A <c>link_token</c>, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>, which can be exchanged for an <c>access_token</c>.
    /// </summary>
    [JsonPropertyName("link_token")]
    public required string LinkToken { get; init; }

    /// <summary>
    /// The creation timestamp for the <c>link_token</c>, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// The expiration timestamp for the <c>link_token</c>, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("expiration")]
    public required DateTimeOffset? Expiration { get; init; }

    /// <summary>
    /// Information about Link sessions created using this <c>link_token</c>. Session data will be provided for up to six hours after the session has ended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_sessions")]
    public IReadOnlyList<LinkTokenGetSessionsResponse>? LinkSessions { get; init; }

    /// <summary>
    /// An object specifying the arguments originally provided to the <c>/link/token/create</c> call.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required LinkTokenGetMetadataResponse Metadata { get; init; }

    /// <summary>
    /// A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
