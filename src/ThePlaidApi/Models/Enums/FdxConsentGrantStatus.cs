using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current status of a consent grant. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxConsentGrantStatus>))]
public sealed record FdxConsentGrantStatus : OpenStringEnum<FdxConsentGrantStatus>
{
    private FdxConsentGrantStatus(string value) : base(value)
    {
    }

    public static readonly FdxConsentGrantStatus Active = new("ACTIVE");

    public static readonly FdxConsentGrantStatus Revoked = new("REVOKED");

    public static readonly FdxConsentGrantStatus Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onRevoked,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Revoked => onRevoked(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onRevoked, Action onExpired, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Revoked) onRevoked();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
