using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// OAuth token grant request.
/// </summary>
public record OAuthTokenRequest
{
    /// <summary>
    /// The type of OAuth grant being requested:
    /// <para>
    /// <c>client_credentials</c> allows exchanging a client id and client secret for a refresh and access token.
    /// <c>refresh_token</c> allows refreshing an access token using a refresh token. When using this grant type, only the <c>refresh_token</c> field is required (along with the <c>client_id</c> and <c>client_secret</c>).
    /// <c>urn:ietf:params:oauth:grant-type:token-exchange</c> allows exchanging a subject token for an OAuth token. When using this grant type, the <c>audience</c>, <c>subject_token</c> and <c>subject_token_type</c> fields are required.
    /// These grants are defined in their respective RFCs. <c>refresh_token</c> and <c>client_credentials</c> are defined in RFC 6749 and <c>urn:ietf:params:oauth:grant-type:token-exchange</c> is defined in RFC 8693.
    /// </para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public required OAuthGrantType GrantType { get; init; }

    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body as either <c>secret</c> or <c>client_secret</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body as either <c>secret</c> or <c>client_secret</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

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
    /// Refresh token for OAuth
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// URI of the target resource server
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resource")]
    public string? Resource { get; init; }

    /// <summary>
    /// Used when exchanging a token. The meaning depends on the <c>subject_token_type</c>:
    /// <list type="bullet">
    ///   <item><description>For <c>urn:plaid:params:tokens:user</c>: Must be the same as the <c>client_id</c>.</description></item>
    ///   <item><description>For <c>urn:plaid:params:oauth:user-token</c>: The other <c>client_id</c> to exchange tokens to.</description></item>
    ///   <item><description>For <c>urn:plaid:params:credit:multi-user</c>:  a <c>client_id</c> or one of the supported CRA partner URNs: <c>urn:plaid:params:cra-partner:experian</c>, <c>urn:plaid:params:cra-partner:fannie-mae</c>, or <c>urn:plaid:params:cra-partner:freddie-mac</c>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audience")]
    public string? Audience { get; init; }

    /// <summary>
    /// Token representing the subject. The meaning depends on the <c>subject_token_type</c>. For <c>urn:plaid:params:tokens:user</c>, the <c>subject_token</c> must be a Plaid-issued user token from the <c>/user/create</c> endpoint. For <c>urn:plaid:params:oauth:user-token</c>, the <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject_token")]
    public string? SubjectToken { get; init; }

    /// <summary>
    /// The type of the subject token.
    /// <c>urn:plaid:params:tokens:user</c> allows exchanging a Plaid-issued user token for an OAuth token. When using this token type, <c>audience</c> must be the same as the <c>client_id</c>. <c>subject_token</c> must be a Plaid-issued user token issued from the <c>/user/create</c> endpoint.
    /// <c>urn:plaid:params:oauth:user-token</c> allows exchanging a refresh token for an OAuth token to another <c>client_id</c>. The other <c>client_id</c> is provided in <c>audience</c>. <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.
    /// <c>urn:plaid:params:credit:multi-user</c> allows exchanging a Plaid-issued user token for an OAuth token. When using this token type, <c>audience</c> may be a client id or a supported CRA partner URN. <c>audience</c> supports a comma-delimited list of clients. When multiple clients are specified in the <c>audience</c> a multi-party token is created which can be used by all parties in the audience in conjunction with their <c>client_id</c> and <c>client_secret</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject_token_type")]
    public OAuthSubjectTokenType? SubjectTokenType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
