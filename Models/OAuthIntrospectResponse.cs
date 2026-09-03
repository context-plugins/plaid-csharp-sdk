using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// OAuth token introspect response
/// </summary>
public record OAuthIntrospectResponse
{
    /// <summary>
    /// Boolean indicator of whether or not the presented token is currently active. A <c>true</c> value indicates that the token has been issued, has not been revoked, and is within the time window of validity.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// A space-separated list of scopes associated with this token, in the format described in <see href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.3">https://datatracker.ietf.org/doc/html/rfc6749#section-3.3</see>. Currently accepted values are:
    /// <para>
    /// <c>user:read</c> allows reading user data.
    /// <c>user:write</c> allows writing user data.
    /// <c>exchange</c> allows exchanging a token using the <c>urn:plaid:params:oauth:user-token</c> subject token type.
    /// <c>mcp:dashboard</c> allows access to the MCP dashboard server.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Expiration time as UNIX timestamp since January 1 1970 UTC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exp")]
    public int? Exp { get; init; }

    /// <summary>
    /// Issued at time as UNIX timestamp since January 1 1970 UTC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iat")]
    public int? Iat { get; init; }

    /// <summary>
    /// Subject of the token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sub")]
    public string? Sub { get; init; }

    /// <summary>
    /// Audience of the token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aud")]
    public string? Aud { get; init; }

    /// <summary>
    /// Issuer of the token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iss")]
    public string? Iss { get; init; }

    /// <summary>
    /// Type of the token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_type")]
    public string? TokenType { get; init; }

    /// <summary>
    /// User ID of the token
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
