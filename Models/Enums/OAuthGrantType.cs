using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of OAuth grant being requested:
/// <para>
/// <c>client_credentials</c> allows exchanging a client id and client secret for a refresh and access token.
/// <c>refresh_token</c> allows refreshing an access token using a refresh token. When using this grant type, only the <c>refresh_token</c> field is required (along with the <c>client_id</c> and <c>client_secret</c>).
/// <c>urn:ietf:params:oauth:grant-type:token-exchange</c> allows exchanging a subject token for an OAuth token. When using this grant type, the <c>audience</c>, <c>subject_token</c> and <c>subject_token_type</c> fields are required.
/// These grants are defined in their respective RFCs. <c>refresh_token</c> and <c>client_credentials</c> are defined in RFC 6749 and <c>urn:ietf:params:oauth:grant-type:token-exchange</c> is defined in RFC 8693.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OAuthGrantType>))]
public sealed record OAuthGrantType : StringEnum<OAuthGrantType>
{
    private OAuthGrantType(string value) : base(value)
    {
    }

    public static readonly OAuthGrantType RefreshToken = new("refresh_token");

    public static readonly OAuthGrantType UrnIetfParamsOauthGrantTypeTokenExchange = new("urn:ietf:params:oauth:grant-type:token-exchange");

    public static readonly OAuthGrantType ClientCredentials = new("client_credentials");

    public static OAuthGrantType FromValue(string value) => FromValueCore(value);
}
