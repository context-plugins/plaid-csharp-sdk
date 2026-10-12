using System;
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
public sealed record SweepTrigger : OpenStringEnum<SweepTrigger>
{
    private SweepTrigger(string value) : base(value)
    {
    }

    public static readonly SweepTrigger Manual = new("manual");

    public static readonly SweepTrigger Incoming = new("incoming");

    public static readonly SweepTrigger BalanceThreshold = new("balance_threshold");

    public static readonly SweepTrigger AutomaticAggregate = new("automatic_aggregate");

    public TResult Match<TResult>(Func<TResult> onManual,
        Func<TResult> onIncoming,
        Func<TResult> onBalanceThreshold,
        Func<TResult> onAutomaticAggregate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Manual => onManual(),
            _ when this == Incoming => onIncoming(),
            _ when this == BalanceThreshold => onBalanceThreshold(),
            _ when this == AutomaticAggregate => onAutomaticAggregate(),
            _ => otherwise(Value)
        };

    public void Match(Action onManual,
        Action onIncoming,
        Action onBalanceThreshold,
        Action onAutomaticAggregate,
        Action<string> otherwise)
    {
        if (this == Manual) onManual();
        else if (this == Incoming) onIncoming();
        else if (this == BalanceThreshold) onBalanceThreshold();
        else if (this == AutomaticAggregate) onAutomaticAggregate();
        else otherwise(Value);
    }
}
