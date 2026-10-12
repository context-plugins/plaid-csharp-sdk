using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferNetwork>))]
public sealed record BankTransferNetwork : OpenStringEnum<BankTransferNetwork>
{
    private BankTransferNetwork(string value) : base(value)
    {
    }

    public static readonly BankTransferNetwork Ach = new("ach");

    public static readonly BankTransferNetwork SameDayAch = new("same-day-ach");

    public static readonly BankTransferNetwork Wire = new("wire");

    public TResult Match<TResult>(Func<TResult> onAch,
        Func<TResult> onSameDayAch,
        Func<TResult> onWire,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == SameDayAch => onSameDayAch(),
            _ when this == Wire => onWire(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch, Action onSameDayAch, Action onWire, Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == SameDayAch) onSameDayAch();
        else if (this == Wire) onWire();
        else otherwise(Value);
    }
}
