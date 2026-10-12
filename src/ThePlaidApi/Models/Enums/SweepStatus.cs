using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of a sweep transfer
/// <para>
/// <c>"pending"</c> - The sweep is currently pending
/// <c>"posted"</c> - The sweep has been posted
/// <c>"settled"</c> - The sweep has settled. This is the terminal state of a successful credit sweep.
/// <c>"returned"</c> - The sweep has been returned. This is the terminal state of a returned sweep. Returns of a sweep are extremely rare, since sweeps are money movement between your own bank account and your own Ledger.
/// <c>"funds_available"</c> - Funds from the sweep have been released from hold and applied to the ledger's available balance. (Only applicable to deposits.) This is the terminal state of a successful deposit sweep.
/// <c>"failed"</c> - The sweep has failed. This is the terminal state of a failed sweep.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SweepStatus>))]
public sealed record SweepStatus : OpenStringEnum<SweepStatus>
{
    private SweepStatus(string value) : base(value)
    {
    }

    public static readonly SweepStatus Pending = new("pending");

    public static readonly SweepStatus Posted = new("posted");

    public static readonly SweepStatus Settled = new("settled");

    public static readonly SweepStatus FundsAvailable = new("funds_available");

    public static readonly SweepStatus Returned = new("returned");

    public static readonly SweepStatus Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onPosted,
        Func<TResult> onSettled,
        Func<TResult> onFundsAvailable,
        Func<TResult> onReturned,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Posted => onPosted(),
            _ when this == Settled => onSettled(),
            _ when this == FundsAvailable => onFundsAvailable(),
            _ when this == Returned => onReturned(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onPosted,
        Action onSettled,
        Action onFundsAvailable,
        Action onReturned,
        Action onFailed,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Posted) onPosted();
        else if (this == Settled) onSettled();
        else if (this == FundsAvailable) onFundsAvailable();
        else if (this == Returned) onReturned();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
