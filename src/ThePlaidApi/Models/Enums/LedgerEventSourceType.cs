using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Source of the ledger event.
/// <para>
/// <c>"TRANSFER"</c> - The source of the ledger event is a transfer
/// <c>"SWEEP"</c> - The source of the ledger event is a sweep
/// <c>"REFUND"</c> - The source of the ledger event is a refund
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LedgerEventSourceType>))]
public sealed record LedgerEventSourceType : OpenStringEnum<LedgerEventSourceType>
{
    private LedgerEventSourceType(string value) : base(value)
    {
    }

    public static readonly LedgerEventSourceType Transfer = new("TRANSFER");

    public static readonly LedgerEventSourceType Sweep = new("SWEEP");

    public static readonly LedgerEventSourceType Refund = new("REFUND");

    public TResult Match<TResult>(Func<TResult> onTransfer,
        Func<TResult> onSweep,
        Func<TResult> onRefund,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Transfer => onTransfer(),
            _ when this == Sweep => onSweep(),
            _ when this == Refund => onRefund(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransfer, Action onSweep, Action onRefund, Action<string> otherwise)
    {
        if (this == Transfer) onTransfer();
        else if (this == Sweep) onSweep();
        else if (this == Refund) onRefund();
        else otherwise(Value);
    }
}
