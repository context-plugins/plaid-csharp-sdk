using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// OAuth error code
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OAuthErrorCode>))]
public sealed record OAuthErrorCode : OpenStringEnum<OAuthErrorCode>
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

    public TResult Match<TResult>(Func<TResult> onInvalidRequest,
        Func<TResult> onInvalidClient,
        Func<TResult> onInvalidGrant,
        Func<TResult> onUnauthorizedClient,
        Func<TResult> onInvalidScope,
        Func<TResult> onUnsupportedGrantType,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == InvalidClient => onInvalidClient(),
            _ when this == InvalidGrant => onInvalidGrant(),
            _ when this == UnauthorizedClient => onUnauthorizedClient(),
            _ when this == InvalidScope => onInvalidScope(),
            _ when this == UnsupportedGrantType => onUnsupportedGrantType(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidRequest,
        Action onInvalidClient,
        Action onInvalidGrant,
        Action onUnauthorizedClient,
        Action onInvalidScope,
        Action onUnsupportedGrantType,
        Action<string> otherwise)
    {
        if (this == InvalidRequest) onInvalidRequest();
        else if (this == InvalidClient) onInvalidClient();
        else if (this == InvalidGrant) onInvalidGrant();
        else if (this == UnauthorizedClient) onUnauthorizedClient();
        else if (this == InvalidScope) onInvalidScope();
        else if (this == UnsupportedGrantType) onUnsupportedGrantType();
        else otherwise(Value);
    }
}
