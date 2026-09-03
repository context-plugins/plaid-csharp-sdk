using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// OAuth error code
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OAuthErrorCode>))]
public sealed record OAuthErrorCode : StringEnum<OAuthErrorCode>
{
    private OAuthErrorCode(string value) : base(value)
    {
    }

    public static readonly OAuthErrorCode InvalidRequest = new("invalid_request");

    public static readonly OAuthErrorCode InvalidClient = new("invalid_client");

    public static readonly OAuthErrorCode InvalidGrant = new("invalid_grant");

    public static readonly OAuthErrorCode UnauthorizedClient = new("unauthorized_client");

    public static readonly OAuthErrorCode InvalidScope = new("invalid_scope");

    public static readonly OAuthErrorCode UnsupportedGrantType = new("unsupported_grant_type");

    public static OAuthErrorCode FromValue(string value) => FromValueCore(value);
}
