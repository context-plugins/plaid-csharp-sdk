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
public sealed record TransferLedgerSweepSimulateEventType : StringEnum<TransferLedgerSweepSimulateEventType>
{
    private TransferLedgerSweepSimulateEventType(string value) : base(value)
    {
    }

    public static readonly TransferLedgerSweepSimulateEventType SweepPosted = new("sweep.posted");

    public static readonly TransferLedgerSweepSimulateEventType SweepSettled = new("sweep.settled");

    public static readonly TransferLedgerSweepSimulateEventType SweepReturned = new("sweep.returned");

    public static readonly TransferLedgerSweepSimulateEventType SweepFailed = new("sweep.failed");

    public static TransferLedgerSweepSimulateEventType FromValue(string value) => FromValueCore(value);
}
