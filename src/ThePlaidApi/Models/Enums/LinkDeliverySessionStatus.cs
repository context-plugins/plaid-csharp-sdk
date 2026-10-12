using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the given Hosted Link session.
/// <para>
/// <c>CREATED</c>: The session is created but not yet accessed by the user
/// </para>
/// <para>
/// <c>OPENED</c>: The session is opened by the user but not yet completed
/// </para>
/// <para>
/// <c>EXITED</c>: The session has been exited by the user
/// </para>
/// <para>
/// <c>COMPLETED</c>: The session has been completed by the user
/// </para>
/// <para>
/// <c>EXPIRED</c>: The session has expired
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliverySessionStatus>))]
public sealed record LinkDeliverySessionStatus : OpenStringEnum<LinkDeliverySessionStatus>
{
    private LinkDeliverySessionStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliverySessionStatus Created = new("CREATED");

    public static readonly LinkDeliverySessionStatus Opened = new("OPENED");

    public static readonly LinkDeliverySessionStatus Exited = new("EXITED");

    public static readonly LinkDeliverySessionStatus Completed = new("COMPLETED");

    public static readonly LinkDeliverySessionStatus Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onOpened,
        Func<TResult> onExited,
        Func<TResult> onCompleted,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Opened => onOpened(),
            _ when this == Exited => onExited(),
            _ when this == Completed => onCompleted(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated,
        Action onOpened,
        Action onExited,
        Action onCompleted,
        Action onExpired,
        Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Opened) onOpened();
        else if (this == Exited) onExited();
        else if (this == Completed) onCompleted();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
