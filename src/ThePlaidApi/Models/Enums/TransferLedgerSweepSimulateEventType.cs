using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, or <c>returned</c>.
/// <para>
/// An error will be returned if the event type is incompatible with the current ledger sweep status. Compatible status --&gt; event type transitions include:
/// </para>
/// <para>
/// <c>sweep.pending</c> --&gt; <c>sweep.posted</c>
/// </para>
/// <para>
/// <c>sweep.pending</c> --&gt; <c>sweep.failed</c>
/// </para>
/// <para>
/// <c>sweep.posted</c> --&gt; <c>sweep.settled</c>
/// </para>
/// <para>
/// <c>sweep.posted</c> --&gt; <c>sweep.returned</c>
/// </para>
/// <para>
/// <c>sweep.settled</c> --&gt; <c>sweep.returned</c>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferLedgerSweepSimulateEventType>))]
public sealed record TransferLedgerSweepSimulateEventType : OpenStringEnum<TransferLedgerSweepSimulateEventType>
{
    private TransferLedgerSweepSimulateEventType(string value) : base(value)
    {
    }

    public static readonly TransferLedgerSweepSimulateEventType SweepPosted = new("sweep.posted");

    public static readonly TransferLedgerSweepSimulateEventType SweepSettled = new("sweep.settled");

    public static readonly TransferLedgerSweepSimulateEventType SweepReturned = new("sweep.returned");

    public static readonly TransferLedgerSweepSimulateEventType SweepFailed = new("sweep.failed");

    public TResult Match<TResult>(Func<TResult> onSweepPosted,
        Func<TResult> onSweepSettled,
        Func<TResult> onSweepReturned,
        Func<TResult> onSweepFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SweepPosted => onSweepPosted(),
            _ when this == SweepSettled => onSweepSettled(),
            _ when this == SweepReturned => onSweepReturned(),
            _ when this == SweepFailed => onSweepFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onSweepPosted,
        Action onSweepSettled,
        Action onSweepReturned,
        Action onSweepFailed,
        Action<string> otherwise)
    {
        if (this == SweepPosted) onSweepPosted();
        else if (this == SweepSettled) onSweepSettled();
        else if (this == SweepReturned) onSweepReturned();
        else if (this == SweepFailed) onSweepFailed();
        else otherwise(Value);
    }
}
