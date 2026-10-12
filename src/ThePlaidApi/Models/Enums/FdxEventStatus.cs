using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Current status of indicated entity after reported event change. Not all statuses will be supported on all entity types by all data providers
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxEventStatus>))]
public sealed record FdxEventStatus : OpenStringEnum<FdxEventStatus>
{
    private FdxEventStatus(string value) : base(value)
    {
    }

    public static readonly FdxEventStatus Active = new("ACTIVE");

    public static readonly FdxEventStatus Expired = new("EXPIRED");

    public static readonly FdxEventStatus Revoked = new("REVOKED");

    public static readonly FdxEventStatus Suspended = new("SUSPENDED");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onExpired,
        Func<TResult> onRevoked,
        Func<TResult> onSuspended,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Expired => onExpired(),
            _ when this == Revoked => onRevoked(),
            _ when this == Suspended => onSuspended(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onExpired, Action onRevoked, Action onSuspended, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Expired) onExpired();
        else if (this == Revoked) onRevoked();
        else if (this == Suspended) onSuspended();
        else otherwise(Value);
    }
}
