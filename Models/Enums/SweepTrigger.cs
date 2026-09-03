using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The trigger of the sweep
/// <para>
/// <c>"manual"</c> - The sweep is created manually by the customer
/// <c>"incoming"</c> - The sweep is created by incoming funds flow (e.g. Incoming Wire)
/// <c>"balance_threshold"</c> - The sweep is created by balance threshold setting
/// <c>"automatic_aggregate"</c> - The sweep is created by the Plaid automatic aggregation process. These funds did not pass through the Plaid Ledger balance.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SweepTrigger>))]
public sealed record SweepTrigger : StringEnum<SweepTrigger>
{
    private SweepTrigger(string value) : base(value)
    {
    }

    public static readonly SweepTrigger Manual = new("manual");

    public static readonly SweepTrigger Incoming = new("incoming");

    public static readonly SweepTrigger BalanceThreshold = new("balance_threshold");

    public static readonly SweepTrigger AutomaticAggregate = new("automatic_aggregate");

    public static SweepTrigger FromValue(string value) => FromValueCore(value);
}
