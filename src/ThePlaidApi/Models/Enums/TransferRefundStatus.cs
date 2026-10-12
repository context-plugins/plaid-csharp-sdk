using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the refund.
/// <para>
/// <c>pending</c>: A new refund was created; it is in the pending state.
/// <c>posted</c>: The refund has been successfully submitted to the payment network.
/// <c>settled</c>: Credits have been refunded to the Plaid linked account.
/// <c>cancelled</c>: The refund was cancelled by the client.
/// <c>failed</c>: The refund has failed.
/// <c>returned</c>: The refund was returned.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRefundStatus>))]
public sealed record TransferRefundStatus : OpenStringEnum<TransferRefundStatus>
{
    private TransferRefundStatus(string value) : base(value)
    {
    }

    public static readonly TransferRefundStatus Pending = new("pending");

    public static readonly TransferRefundStatus Posted = new("posted");

    public static readonly TransferRefundStatus Cancelled = new("cancelled");

    public static readonly TransferRefundStatus Failed = new("failed");

    public static readonly TransferRefundStatus Settled = new("settled");

    public static readonly TransferRefundStatus Returned = new("returned");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onPosted,
        Func<TResult> onCancelled,
        Func<TResult> onFailed,
        Func<TResult> onSettled,
        Func<TResult> onReturned,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Posted => onPosted(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Failed => onFailed(),
            _ when this == Settled => onSettled(),
            _ when this == Returned => onReturned(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onPosted,
        Action onCancelled,
        Action onFailed,
        Action onSettled,
        Action onReturned,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Posted) onPosted();
        else if (this == Cancelled) onCancelled();
        else if (this == Failed) onFailed();
        else if (this == Settled) onSettled();
        else if (this == Returned) onReturned();
        else otherwise(Value);
    }
}
