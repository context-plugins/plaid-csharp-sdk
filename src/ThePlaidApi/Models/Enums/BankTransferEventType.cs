using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of event that this bank transfer represents.
/// <para>
/// <c>pending</c>: A new transfer was created; it is in the pending state.
/// </para>
/// <para>
/// <c>cancelled</c>: The transfer was cancelled by the client.
/// </para>
/// <para>
/// <c>failed</c>: The transfer failed, no funds were moved.
/// </para>
/// <para>
/// <c>posted</c>: The transfer has been successfully submitted to the payment network.
/// </para>
/// <para>
/// <c>reversed</c>: A posted transfer was reversed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferEventType>))]
public sealed record BankTransferEventType : OpenStringEnum<BankTransferEventType>
{
    private BankTransferEventType(string value) : base(value)
    {
    }

    public static readonly BankTransferEventType Pending = new("pending");

    public static readonly BankTransferEventType Cancelled = new("cancelled");

    public static readonly BankTransferEventType Failed = new("failed");

    public static readonly BankTransferEventType Posted = new("posted");

    public static readonly BankTransferEventType Reversed = new("reversed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCancelled,
        Func<TResult> onFailed,
        Func<TResult> onPosted,
        Func<TResult> onReversed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Failed => onFailed(),
            _ when this == Posted => onPosted(),
            _ when this == Reversed => onReversed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onCancelled,
        Action onFailed,
        Action onPosted,
        Action onReversed,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Cancelled) onCancelled();
        else if (this == Failed) onFailed();
        else if (this == Posted) onPosted();
        else if (this == Reversed) onReversed();
        else otherwise(Value);
    }
}
