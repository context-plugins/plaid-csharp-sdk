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
public sealed record LedgerEventSourceType : StringEnum<LedgerEventSourceType>
{
    private LedgerEventSourceType(string value) : base(value)
    {
    }

    public static readonly LedgerEventSourceType Transfer = new("TRANSFER");

    public static readonly LedgerEventSourceType Sweep = new("SWEEP");

    public static readonly LedgerEventSourceType Refund = new("REFUND");

    public static LedgerEventSourceType FromValue(string value) => FromValueCore(value);
}
